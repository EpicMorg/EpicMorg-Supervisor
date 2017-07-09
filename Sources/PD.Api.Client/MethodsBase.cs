using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EMSV.Api.Client {

    public abstract class MethodsBase {
        private static FormUrlEncodedContent _emptyContent => new FormUrlEncodedContent( new KeyValuePair<string,string>[0] );

        protected readonly HttpClient _client;

        internal MethodsBase( string server, string path ) { _client = CreateClient( server, path ); }

        protected async Task<T> GetWithKey<T>(string query, string key) => await Get<T>(GetKeyQuery( query, key )).ConfigureAwait(false);

        protected static string GetKeyQuery( string query, string key ) => $"{query}?key={key}";

        protected async Task<T> Get<T>(string query) => await ProcessResponse<T>(await _client.GetAsync($"{query}").ConfigureAwait(false)).ConfigureAwait(false);

        internal async Task<string> PostRaw(string query, string key) => await GetResponse(await _client.PostAsync(GetKeyQuery(query, key), _emptyContent).ConfigureAwait(false)).ConfigureAwait(false);
        internal async Task<string> PostRaw(int id, string key, string action) => await PostRaw($"{id}/{action}", key ).ConfigureAwait( false );

        protected async Task<T> ProcessResponse<T>( HttpResponseMessage resp ) => JsonConvert.DeserializeObject<T>( await GetResponse( resp ).ConfigureAwait( false ) );

        internal async Task<string> GetResponse( HttpResponseMessage resp ) {
            ThrowOnNonSuccess( resp );
            return await resp.Content.ReadAsStringAsync().ConfigureAwait( false );
        }

        internal static void ThrowOnNonSuccess( HttpResponseMessage resp ) {
            if ( !resp.IsSuccessStatusCode )
                throw new Exception( $"Bad server response status code({resp.StatusCode})" );
        }

        private static HttpClient CreateClient( string server, string path ) {
            var v = new HttpClient( new HttpClientHandler() ) { BaseAddress = new Uri( new Uri( server ), path ) };
            v.DefaultRequestHeaders.Accept.Clear();
            v.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
            return v;
        }

    }

}