using Autofac;
using ConsoleApp1.AcModel;
using ConsoleApp1.Component;
using ConsoleApp1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MContainer
{
    public static class MyContainer
    {
        private static IContainer _container;

        public static T Create<T>()
        {
            Configure();

            var myComponet = _container.Resolve<T>();

            return myComponet;
        }

        private static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HellowModel>().As<IHellow>().InstancePerLifetimeScope();
            builder.RegisterType<HandbookModel>().As<Ibook>().InstancePerLifetimeScope();

            builder.RegisterType<MyComponet>();

            builder.RegisterType<MainViewModel>();

            _container = builder.Build();
        }
    }
}
