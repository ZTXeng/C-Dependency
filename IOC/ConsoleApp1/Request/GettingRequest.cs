using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
    public class GettingRequest:IRequest<string>
    {
        public string Name { get; set; }

        public GettingRequest()
        {

        }
    }
}
