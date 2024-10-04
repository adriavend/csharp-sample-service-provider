using System.Reflection;

namespace SampleServiceProvider.Infraestructure
{
    public interface IServiceProvider
    {
        void Register<TInterface, TImplementation>() where TImplementation : TInterface;
        TInterface GetService<TInterface>();
    }

    public class ServiceProvider : IServiceProvider
    {
        private readonly Dictionary<Type, Type> _services = [];

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            if (_services.ContainsKey(typeof(TInterface)))
            {
                return;
            }

            _services[typeof(TInterface)] = typeof(TImplementation);
        }

        public TInterface GetService<TInterface>()
        {
            if (!_services.ContainsKey(typeof(TInterface)))
            {
                throw new Exception($"{typeof(TInterface)} is not registered");
            }

            Type implementationType = _services[typeof(TInterface)];
            ConstructorInfo constructorInfo = implementationType.GetConstructors()[0];
            ParameterInfo[] parameters = constructorInfo.GetParameters();
            List<object> parameterInstances = new();

            foreach (ParameterInfo param in parameters)
            {
                parameterInstances.Add(GetService(param.ParameterType));
            }

            return (TInterface)constructorInfo.Invoke(parameterInstances.ToArray());
        }

        public object GetService(Type serviceType) 
        {
            if (!_services.ContainsKey(serviceType))
            {
                throw new Exception($"{serviceType.Name} is not registered");
            }

            Type implementationType = _services[serviceType];
            ConstructorInfo constructorInfo = implementationType.GetConstructors()[0];
            ParameterInfo[] parameters = constructorInfo.GetParameters();
            List<object> parameterInstances = new();

            foreach (ParameterInfo param in parameters)
            {
                parameterInstances.Add(GetService(param.ParameterType));
            }

            return constructorInfo.Invoke(parameterInstances.ToArray());
        }
    }
}
