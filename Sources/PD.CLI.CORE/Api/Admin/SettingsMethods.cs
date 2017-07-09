using System;
using System.Threading.Tasks;
using EMSV.Api;
using EMSV.Api.DataTypes;
using EMSV.CLI.CORE.Core;
using EMSV.CLI.CORE.Helpers;

namespace EMSV.CLI.CORE.Api {

    public class SettingsMethods : ISettingsMethods {

        private ISettingsManager _repository;

        public SettingsMethods( ISettingsManager repository ) {
            _repository = repository;
        }


        public async Task<ISettings> GetSettings() => _repository.Settings;

        public async Task SetSettings( ISettings settings ) {
            if ( settings == null ) {
                throw new ArgumentNullException();
            }
            var existing = _repository.Settings;
            MappingHelper.Instance.Map<ISettings, ISettingsPassword>( settings, existing );
            _repository.Settings = existing;
        }

        public async Task SetKey( string key ) {
            var settings = _repository.Settings;
            settings.Password = key;
            _repository.Settings = settings;
        }

        public async Task<bool> CheckKey( string key ) => _repository.Settings.Password == key;

    }

}