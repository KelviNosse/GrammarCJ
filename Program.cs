// Using directives
using System;
using System.Linq;

// Nested namespaces
namespace X
{
    namespace A
    {
        namespace B
        {
            namespace C
            {
                using System.Console;
            }
        }
    }

    namespace D
    {
        
    }
}

namespace Y
{
    enum Test
    {
        A, B, C, D
    }

    enum Test2
    {
        A = 1, B, C = 4,
    }
}

namespace Z
{
    enum Test
    {
        
    }   
}
