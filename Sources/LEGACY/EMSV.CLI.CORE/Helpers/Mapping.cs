using AutoMapper;
using EMSV.Api.DataTypes;
using EMSV.CLI.CORE.Api;
using EMSV.CLI.CORE.Core;

namespace EMSV.CLI.CORE.Helpers
{
    public class MappingHelper
    {

        private static readonly MappingHelper _instance = new MappingHelper();
        public static MappingHelper Instance => _instance;

        private MappingHelper() {
            Mapper.Initialize(a =>
            {
                a.ConstructServicesUsing(type => Di.Get(type));
                a.CreateMap<ISettings, ISettingsPassword>();
                a.CreateMap<ISettingsPassword, ISettingsPassword>();

                a.CreateMap<IPasswordedDemonizedProcess, InternalDemonizedProcess>().ConstructUsingServiceLocator();
                a.CreateMap<IPasswordedDemonizedProcess, IInternalDemonizedProcess>();

                a.CreateMap<InternalDemonizedProcess, PasswordedDemonizedProcess>();
                a.CreateMap<InternalDemonizedProcess, DemonizedProcessBase>();
            });
            
        }

        public void Map<TSource, TDest>( TSource source, TDest dest ) => Mapper.Map( source, dest );
        public TDest Map<TSource, TDest>(TSource source) => Mapper.Map<TSource, TDest>(source);
    }
}
