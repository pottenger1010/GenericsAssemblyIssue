using System;

namespace SharedNamespace
{

    public class Loadee
    {
        public void DoSomething()
        {
            PrintObject(new ReferencedDerived());
        }
        public void PrintObject<T>(T baseObject) where T : ReferencedBase // <= Causes LoadFromAssemblyPath to silently throw ReflectionTypeLoadException
        //public void PrintObject(ReferencedBase baseObject) // <= Works
        {
            baseObject.PrintSomething();
        }
    }
}
