using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CASolution.ArchitectureTests.Providers
{
    public interface IAssembliesProvider
    {
        public Assembly DomainAssembly { get; set; }
        public Assembly ApplicationAssembly { get; set; }
        public Assembly PresentationAssembly { get; set; }
        public Assembly ContractsAssembly { get; set; }
        public Assembly InfrastructureServicesAssembly { get; set; }
        public Assembly InfrastructurePersistenceAssembly { get; set; }


    }
}
