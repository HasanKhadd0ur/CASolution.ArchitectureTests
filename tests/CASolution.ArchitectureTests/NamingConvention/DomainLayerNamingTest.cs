using CASolution.ArchitectureTests.Providers;
using CASolution.SharedKernel.DomainEvents;
using CASolution.SharedKernel.Repositories;
using FluentAssertions;
using NetArchTest.Rules;
using Xunit;

namespace CASolution.ArchitectureTests.NamingConvention
{
    public class DomainLayerNamingTest : ArchitectureTest
    {
        public DomainLayerNamingTest(IAssembliesProvider assembliesProvider) : base(assembliesProvider)
        {
        }

        #region Events Naming Convention 
        [Fact]
        public void Event_ShouldHave_NameEndingWith_Event()
        {
           Helpers
                .NamingConventionHelper
                .InterfaceImplementingTest(
                    AssembliesProvider.DomainAssembly,
                    typeof(IDomainEvent),
                    "Event"
                    ).Should().BeTrue();
        }

        #endregion Events Naming Convention


        #region Repository Naming Convention 
        [Fact]
        public void Repositories_ShouldHave_NameEndingWith_Repository()
        {
            Helpers
             .NamingConventionHelper
             .InterfaceImplementingTest(
                 AssembliesProvider.DomainAssembly,
                 typeof(IRepository<>),
                 "Repository"
                 ).Should().BeTrue();

        }

        #endregion Repository Naming Convention

    }

}
