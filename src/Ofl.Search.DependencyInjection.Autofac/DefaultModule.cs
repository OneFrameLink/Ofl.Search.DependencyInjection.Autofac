using System;
using Autofac;

namespace Ofl.Search.DependencyInjection.Autofac
{
    [Obsolete]
    public class DefaultModule : Module
    {
        #region Overrides of Module

        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<IndexManager>().As<IIndexManager>().SingleInstance();
        }

        #endregion
    }
}
