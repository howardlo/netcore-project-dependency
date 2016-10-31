using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryA;

namespace ClassLibraryB
{
    public class ClassB
    {
        public ClassB()
        {
        }

        public string Say
        {
            get
            {
                var classA = new ClassA();
                return $"ClassLibraryB.ClassB requires {classA.Say}";
            }
        }
    }
}
