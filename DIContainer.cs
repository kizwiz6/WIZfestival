using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIZfestival
{
    public class DIContainer
    {
        private readonly Dictionary<Type, Type> _dependencyMap = new Dictionary<Type, Type>();

        /// <summary>
        /// Registering service implementation
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        public void Register<TInterface, TImplementation>()
        {
            _dependencyMap[typeof(TInterface)] = typeof(TImplementation);
        }

        /// <summary>
        /// Resolving dependencies
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <returns></returns>
        public TInterface Resolve<TInterface>()
        {
            Type implementationType = _dependencyMap[typeof(TInterface)];
            return (TInterface)Activator.CreateInstance(implementationType);
        }
    }
}
