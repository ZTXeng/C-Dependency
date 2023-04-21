using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns
{
    public sealed class Singleton
    {
        private volatile static Singleton instance;

        private OtherClass OtherClass;

        private static readonly object instanceLock = new object();

        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                //单例双重锁
                lock (instanceLock)
                {

                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }

            }
        }

        public void SetOtherClass(OtherClass other)
        {
            this.OtherClass = other;
        }

        public void UseOther()
        {
            if (this.OtherClass != null)
            {
                OtherClass.Dosomething();
            }
        }
    }
    public class OtherClass
    {
        public void Dosomething()
        {
            Console.WriteLine("Other Class is doing someting");
        }
    }
}
