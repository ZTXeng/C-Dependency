using Autofac;
using ConsoleApp1.Component;
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

            var mainViewModel = MyContainer.Create<MainViewModel>();

            mainViewModel.Run();
          
            Console.ReadKey();
        }
    }
}