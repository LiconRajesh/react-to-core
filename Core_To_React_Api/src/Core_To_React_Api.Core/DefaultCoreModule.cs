using Autofac;
using Core_To_React_Api.Core.Interfaces;
using Core_To_React_Api.Core.Services;

namespace Core_To_React_Api.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
