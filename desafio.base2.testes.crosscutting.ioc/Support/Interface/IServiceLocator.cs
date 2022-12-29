using Autofac;

namespace desafio.base2.testes.crosscutting.ioc.Support.Interface
{
    public interface IServiceLocator
    {
        TClass GetInstance<TClass>();
    }

    public class AutoFacServiceLocator : IServiceLocator
    {
        private readonly IContainer _container;

        public AutoFacServiceLocator(IContainer container)
        {
            _container = container;
        }
        public TClass GetInstance<TClass>()
        {
            using var scope = _container.BeginLifetimeScope();
            var @class = scope.Resolve<TClass>();
            return @class;
        }
    }
}
