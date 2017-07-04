using AutoMapper;
using PD.Api.DataTypes;
using PD.CLI.CORE.Api;
using PD.CLI.CORE.Core;

namespace PD.CLI.CORE.Helpers
{
    public class MappingHelper
    {

        private static readonly MappingHelper _instance = new MappingHelper();
        public static MappingHelper Instance => _instance;

        private MappingHelper() {
            Mapper.Configuration.ConstructServicesUsing( type=>Di.Get(type) );
            Mapper.CreateMap<ISettingsPassword, IInternalSettings>();
            Mapper.CreateMap<ISettings, ISettingsPassword>();
            Mapper.CreateMap<ISettingsPassword, ISettingsPassword>();

            Mapper.CreateMap<IPasswordedDemonizedProcess, InternalDemonizedProcess>().ConstructUsingServiceLocator();
            Mapper.CreateMap<IPasswordedDemonizedProcess, IInternalDemonizedProcess>();

            Mapper.CreateMap<InternalDemonizedProcess, PasswordedDemonizedProcess>();
            Mapper.CreateMap<InternalDemonizedProcess, DemonizedProcessBase>();
        }

        public void Map<TSource, TDest>( TSource source, TDest dest ) => Mapper.Map( source, dest );
        public TDest Map<TSource, TDest>(TSource source) => Mapper.Map<TSource, TDest>(source);
    }
}
