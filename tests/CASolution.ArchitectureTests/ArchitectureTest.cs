using CASolution.ArchitectureTests.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CASolution.ArchitectureTests
{
    public class ArchitectureTest
    {
        protected readonly IAssembliesProvider AssembliesProvider;
        public ArchitectureTest(IAssembliesProvider assembliesProvider)
        {
            AssembliesProvider = assembliesProvider;
        }


    }
}
