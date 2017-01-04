using Ninject.Modules;
using Ninject.StandardKernelHelper;
using NUnit.Framework;

namespace DomainInventory
{
    public partial class IDomainRepositoryNHibernateIntegrationTests
    {
        [OneTimeSetUp]
        public void Configure()
        {
            DependencyHelper.Configure(new INinjectModule[] { new NHibernateDomainNinjectModule() });
        }
    }
}