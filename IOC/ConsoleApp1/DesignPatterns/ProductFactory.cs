using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns
{
    internal class ProductFactory
    {
    }

    public interface IProduct
    {
        void Name();
    }

    public class ConcreteProdcut1 : IProduct
    {
        public void Name()
        {
            Console.WriteLine("这是具体产品1");
        }
    }

    public class ConcreteProdcut2 : IProduct
    {
        public void Name()
        {
            Console.WriteLine("这是具体产品2");
        }
    }

    public interface IFactroy
    {
        IProduct CreateProduct();
    }

    public class ConcreteFactory1 : IFactroy
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProdcut1();
        }
    }
    public class ConcreteFactory2 : IFactroy
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProdcut2();
        }
    }


}
