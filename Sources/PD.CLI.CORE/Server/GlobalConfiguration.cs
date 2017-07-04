using System;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PD.CLI.CORE.Server {

    public static class GlobalConfiguration {

        private static readonly Lazy<HttpConfiguration> HttpConfigurationLazy = new Lazy<HttpConfiguration>( BuildConfiguration );
        public static HttpConfiguration HttpConfiguration => HttpConfigurationLazy.Value;

        private static HttpConfiguration BuildConfiguration() {
            var config = new HttpConfiguration {
                Formatters = {
                    JsonFormatter = {
                        SerializerSettings = {
                            Formatting = Formatting.Indented
                        }
                    }
                }
            };
            config.Formatters.Remove( config.Formatters.XmlFormatter );
            config.MapHttpAttributeRoutes();
            config.EnsureInitialized();
            return config;
        }

    }

}