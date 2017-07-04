using System.Collections.Generic;
using System.Threading.Tasks;
using PD.Api.DataTypes;

namespace PD.Api {

    public interface LoginApi {

        IAuthorizeMethods Authorize { get; }

    }

    public interface IAuthorizeMethods {

        Task Authorize();

        Task Authorize( string key );

    }

    public interface IClientApi {

        IClientProcessMethods Process { get; }

    }

    public interface IClientProcessMethods {

        Task<IEnumerable<IDemonizedProcessBase>> List();

        Task<IRunningDemonizedProcess> Get( int id, string key );

        Task Start( int id, string key );

        Task Stop( int id, string key );

        Task Restart( int id, string key );
        Task<bool> CheckPassword(int id, string key);
    }

    public interface IAdminApi {

        IAdminProcessMethods Process { get; }
        ISettingsMethods Settings { get; }
        ILogMethods Log { get; }

    }

    public interface IAdminProcessMethods {

        Task<IEnumerable<IDemonizedProcessBase>> List();

        Task<IEnumerable<IRunningDemonizedProcess>> ListFull();

        Task Edit( IPasswordedDemonizedProcess model );

        Task<int> Create( IPasswordedDemonizedProcess model );

        Task<IRunningDemonizedProcess> Get( int id );

        Task Start( int id );

        Task Stop( int id );

        Task Restart( int id );

        Task Delete( int id );

        Task Show( int id );

        Task Hide( int id );

    }

    public interface ILogMethods {

        Task<IEnumerable<string>> Show( int tailCount );

    }

    public interface ISettingsMethods {

        Task<ISettings> GetSettings();

        Task SetSettings( ISettings settings );

        Task SetKey( string key );

        Task<bool> CheckKey( string key );

    }

}