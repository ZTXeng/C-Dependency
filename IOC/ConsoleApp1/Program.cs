using Autofac;
using ConsoleApp1.Component;
using ConsoleApp1.DesignPatterns;
using ConsoleApp1.MContainer;
using ConsoleApp1.ViewModel;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region 依赖注入示例
            //var mainViewModel = MyContainer.Create<MainViewModel>();

            //mainViewModel.Run();
            #endregion
            #region 单例模式示例
            //单例模式示例
            //var instance1 = Singleton.Instance; var instance2 = Singleton.Instance;
            //var otherClass = new OtherClass();
            //instance1.SetOtherClass(otherClass);

            //if (instance1 == instance2)
            //{
            //    Console.WriteLine("Singleton works");

            //    instance1.UseOther();
            //}
            #endregion

            var factory1 = new ConcreteFactory1();
            var product1 = factory1.CreateProduct();
            product1.Name();

            var factory2 = new ConcreteFactory2();
            var product2 = factory2.CreateProduct();
            product2.Name();

            Console.ReadKey();
        }
    }

}