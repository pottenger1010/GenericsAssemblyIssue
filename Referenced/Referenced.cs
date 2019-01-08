using System;

namespace SharedNamespace
{
    public abstract class ReferencedBase
    {
        public void PrintSomething()
        {
            Console.WriteLine("ReferencedBase Printing");
        }
    }
    public class ReferencedDerived : ReferencedBase { }
}
