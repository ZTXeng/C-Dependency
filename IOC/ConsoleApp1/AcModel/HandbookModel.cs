using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AcModel
{
    public interface Ibook { void CaptionMessage(string message, int index); }
    public class HandbookModel : Ibook
    {
        public void CaptionMessage(string message, int index)
        {
            Console.WriteLine("This is one handbook,you can read it and learn ...such as" +  message );
        }
    }
}
