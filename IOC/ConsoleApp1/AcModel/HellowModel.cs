using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AcModel
{
    public interface IHellow { void WellcomeMessage(string message, int index); }


    public class HellowModel : IHellow
    {
        public void WellcomeMessage(string message,int index)
        {
            Console.WriteLine(message + ",Hellow Welcome to World Family ,"+$"you are the {index}th citizen");
        }
    }
}
