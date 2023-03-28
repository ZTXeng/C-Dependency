using Autofac;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ViewModel
{
    public class ViewModelBase
    {
        public IMediator _mediator;

        public ViewModelBase()
        {
            var builder = new ContainerBuilder();

            var configBuilder = MediatRConfigurationBuilder.Create(typeof(Program).Assembly);
            configBuilder.WithAllOpenGenericHandlerTypesRegistered();

            builder.RegisterMediatR(configBuilder.Build());
            builder.RegisterAssemblyModules(typeof(Program).Assembly);

            var container = builder.Build();

            _mediator = container.Resolve<IMediator>();
        }
    }
}
