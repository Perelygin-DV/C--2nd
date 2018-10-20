using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex123
{
    class Foo1
    {
        public Foo1(int a) { }
    }

    class Foo2: Foo1
    {
        public Foo2(int a, int b) : base(a) { }
    }

    class Foo3 : Foo2
    {
        public Foo3(int a, int b) : base(a, b) { }
    }



}
