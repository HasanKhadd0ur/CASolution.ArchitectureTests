using CASolution.ArchitectureTests.Providers;
using FluentAssertions;
using NetArchTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CASolution.ArchitectureTests.Dependencies
{
    public class DependencyTests : ArchitectureTest
    {
        public DependencyTests(IAssembliesProvider assembliesProvider) : base(assembliesProvider)
        {
        }

        #region Application Layer 
        [Fact]
        public void Application_Should_Not_DependOnOtherProjectExceptDmain()
        {

            // Arrange
            var otherProject = new[]
            {
                AssembliesProvider.PresentationNamespace,
                AssembliesProvider.InfrastructurePersistenceNamespace,
                AssembliesProvider.InfrastructureServicesNamespace
            };

            // Act
            var result = Types
                .InAssembly(AssembliesProvider.ApplicationAssembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProject)
                .GetResult();

            // Assert
            result.IsSuccessful.Should().BeTrue();
        }

        #endregion Application Layer 

        #region Presentation Layer 

        [Fact]
        public void Presentation_Should_Not_DependOnOtherProjectExceptApplicationAndContracts()
        {

            // Arrange
            var otherProject = new[]
            {
                AssembliesProvider.InfrastructurePersistenceNamespace,
                AssembliesProvider.InfrastructureServicesNamespace,
                AssembliesProvider.DomainNamespace
            };


            // Act
            var result = Types
                .InAssembly(AssembliesProvider.PresentationAssembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProject)
                .GetResult();

            // Assert
            result.IsSuccessful.Should().BeTrue();
        }

        #endregion Presentation Layer 

        #region Domain Layer 
        [Fact]
        public void Domain_Should_Not_DependOnOtherProjectExceptSharedKernel()
        {

            // Arrange
            var otherProject = new[]
            {
                AssembliesProvider.PresentationNamespace,
                AssembliesProvider.InfrastructureServicesNamespace,
                AssembliesProvider.InfrastructurePersistenceNamespace,
                AssembliesProvider.ApplicationNamespace,
            };

            // Act
            var result = Types
                .InAssembly(AssembliesProvider.DomainAssembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProject)
                .GetResult();

            // Assert
            result.IsSuccessful.Should().BeTrue();
        }

        #endregion Domain Laye

        #region Persistence Layer 
        [Fact]
        public void Persistence_Should_Not_DependOnOtherProjectExceptDomain()
        {

            // Arrange
            var otherProject = new[]
            {

                AssembliesProvider.PresentationNamespace,
                AssembliesProvider.InfrastructureServicesNamespace,
                AssembliesProvider.ApplicationNamespace,
        };

            // Act
            var result = Types
                .InAssembly(AssembliesProvider.InfrastructurePersistenceAssembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProject)
                .GetResult();

            // Assert
            result.IsSuccessful.Should().BeTrue();
        }


        #endregion Persistence Layer 

        #region Services Layer 

        [Fact]
        public void Services_Should_Not_DependOnOtherProjectExceptApplication()
        {

            // Arrange
            var otherProject = new[]
            {

                AssembliesProvider.PresentationNamespace,
                AssembliesProvider.InfrastructurePersistenceNamespace,
                AssembliesProvider.DomainNamespace,
            };

            // Act
            var result = Types
                .InAssembly(AssembliesProvider.InfrastructureServicesAssembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProject)
                .GetResult();

            // Assert
            result.IsSuccessful.Should().BeTrue();
        }

        #endregion Services Layer 

    }
}
