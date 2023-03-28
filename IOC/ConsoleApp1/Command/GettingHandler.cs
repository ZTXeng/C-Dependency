
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GettingHandler : IRequestHandler<GettingRequest, string>
    {
        public Task<string> Handle(GettingRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Hellow");
            return Task.FromResult($"Hello, {request.Name}!");
        }
    }
}
