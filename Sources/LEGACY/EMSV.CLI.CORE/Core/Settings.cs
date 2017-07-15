using EMSV.Api.DataTypes;
using EMSV.CLI.CORE.Helpers;

namespace EMSV.CLI.CORE.Core {

    public interface ISettingsManager {

        ISettingsPassword Settings { get; set; }

    }

    public class SettingsManager : ISettingsManager {

        private ISettingsFactory _factory;

        public SettingsManager( ISettingsFactory factory ) { _factory = factory; }

        public ISettingsPassword Settings
        {
            get { return _factory.Get(); }
            set
            {
                var entry = _factory.Get();
                MappingHelper.Instance.Map<ISettingsPassword, ISettingsPassword>( value, entry );
                _factory.Set( entry );
            }
        }

    }

    public interface IInternalSettings : ISettingsPassword {

        string ConfigPath { get; }

    }

    public class InternalSettings : SettingsPassword, IInternalSettings {

        public string ConfigPath { get; }

    }

    public interface ISettingsFactory : IStorage<IInternalSettings> {

    }

    public class SettingsFactory : ISettingsFactory {

        private const string path = "settings.xml";

        private IDataStorage<InternalSettings> _dataStorage;

        public SettingsFactory( IDataStorageFactory dataStorage ) { _dataStorage = dataStorage.Get<InternalSettings>(); }

        public IInternalSettings Get() => _dataStorage.Load( path )??new InternalSettings();

        public void Set( IInternalSettings value ) => _dataStorage.Save( path, (InternalSettings)value );

    }

}