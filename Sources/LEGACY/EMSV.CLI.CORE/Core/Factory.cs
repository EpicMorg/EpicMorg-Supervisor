namespace EMSV.CLI.CORE.Core {

    public interface IFactory<T> {

        T Get();

    }

    public interface IStorage<T> : IFactory<T> {

        void Set( T value );

    }

}