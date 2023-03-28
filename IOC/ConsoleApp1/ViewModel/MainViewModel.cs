using ConsoleApp1.Component;
using ConsoleApp1.MContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {

        }

        public async void Run()
        {
            await _mediator.Send(new GettingRequest { Name = "Openmao" });

            var myComponet = MyContainer.Create<MyComponet>();

            myComponet.DoSomething();
        }
    }
}
