// Using directives
using System;
using System.Linq;

interface Test
{
    
}

enum EnumTest
{
    
}

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
        class SomeClass
        {
            private int x;
            private bool[,] y;

            protected static int counter;

            protected SomeClass()
            {
                
            }

            public static void main()
            {
                int[][] jaggedArray2 = new int[][]
                {
                    new int[] {1,3,5,7,9},
                    new int[] {0,2,4,6},
                    new int[] {11,22}
                };
            }

            private abstract int test(float x, bool what);


            private static int Z = 1;

            SomeClass(int a, int b)
            {
                
            }
        }

        private class AnotherClass
        {
            
        }
    }
}

namespace Y
{
    enum Test
    {
        A, B, C, D
    }

    private enum Test2
    {
        A = 1, B, C = 4,
    }
}

namespace Z
{
    public enum Test
    {
        
    }

    interface ITest : IInterface, ISomething, IDontKnow
    {
        string doSomething(string message);
        void sayHi();
        bool truthy();
        float pi();
        int sum(int a, int b);
        SomeClass hey();
    }

    interface ITest2
    {
        void what();
    }

    interface ITest3
    {

    }

    namespace A
    {
        
    }
}

enum What
{
    
}

abstract class Test : SomeClass2, Hey, System.Some.Thing
{
    /*
     * Wild comment block has appeared!
     */

    private static int x, y, z;

    Test() 
    {
        
    }

    public static System.Object[][] Function()
    {
        
    }

    private Test(int a, string str)
    {
        while (true)
        {
            int x, y = z = 1, m;
            //int.Parse("1");
        }

        for (int x = 0; x < 10; x++)
        {
            break;
            continue;
        }

        foreach (var x in numbers)
        {
            break;
            continue;
        }

        int x, y, z, i;

        //Console.WriteLine("Hello!");
    }

    public static void Something()
    {
        
    }

    public abstract int[][] SomethingAbstract();


    public void Slow()
    {
        int nthPrime = FindPrimeNumber(1000); //set higher value for more time
    }

    public int FindPrimeNumber(int n)
    {
        int count = 0;
        int a = 2;
        while (count < n)
        {
            int b = 2;
            int prime = 1;
            while (b * b <= a)
            {
                if (a % b == 0)
                {
                    prime = 0;
                    break;
                }
                something++;
                b++;
            }
            if (prime > 0)
            {
                count++;
            }
            a++;
        }
        return (--a);
    }
}

