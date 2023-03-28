using ConsoleApp1.AcModel;
using ConsoleApp1.DataModelModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Component
{
    public class MyComponet
    {
        private readonly IHellow _print_Hellow;

        private readonly Ibook _handbook;

        private PeoplesModel _peoplesModel;

        public MyComponet(IHellow hellwo,Ibook book)
        {
            _print_Hellow = hellwo;
            _handbook = book;
        }

        public void DoSomething()
        {
            CollectPeople();
            var peoples = _peoplesModel.Peoples;

            foreach (var people in peoples)
            {
                _print_Hellow.WellcomeMessage(people.Name, people.Number);

            }

            _handbook.CaptionMessage("tuch fish",1);
        }

        //add more people
        public void CollectPeople()
        {
            _peoplesModel = new PeoplesModel();
            _peoplesModel.AddPeople(People.ConverterTo("zhang",1));

            _peoplesModel.AddPeople(People.ConverterTo("wang", 1));
        }
    }
}
