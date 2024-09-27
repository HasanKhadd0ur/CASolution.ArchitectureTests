using NetArchTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CASolution.ArchitectureTests.Helpers
{
    public class NamingConventionHelper
    {
        public static bool InterfaceImplementingTest(Assembly assembly ,Type type , string suffix)
        {
            var result = Types.InAssembly(assembly)
                            .That()
                            .ImplementInterface(type)
                            .Should()
                            .HaveNameEndingWith(suffix)
                            .GetResult();

            return result.IsSuccessful;
        }
    }
}
