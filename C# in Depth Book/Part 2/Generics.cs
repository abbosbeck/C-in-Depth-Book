﻿namespace Part2
{
    class Generics<T>
    {
        public static List<string> GenerateNames()
        {
            /*string[] names = new string[5];
            names[0] = "Jon";
            names[1] = "Tom";
            names[2] = "Jerry";*/

            /*ArrayList names = new ArrayList();
            names.Add("Jon");
            names.Add("Tom");
            names.Add("Jerry");
            names.Add("Mickey");
            names.Add("Minnie");
            names.Add(15);*/

            /*StringCollection names = new StringCollection();
            names.Add("Jon");
            names.Add("Tom");
            names.Add("Jerry");
            names.Add("Mickey");
            names.Add("Minnie");*/

            List<string> names = new List<string>();
            names.Add("Jon");
            names.Add("Tom");
            names.Add("Jerry");
            names.Add("Mickey");
            names.Add("Minnie");

            return names;
        }

        /* public static void TupleCreater()
         {
             var a  = Tuple.Create("x", 10, 2.5, "fdas", "fafsa");

             // a.Item1 = "Hello"; --> compiler-time error, because Tuple is immutable - read-only;
             // if I want to change the value, I have to create a new Tuple or use ValueTuple

             Console.WriteLine(a);
         }*/

        private static int value;
        static Generics()
        {
            Console.WriteLine($"Initilizing counter for {typeof(T)}");
        }

        public static void Increment() => value++;
        public static void Display() => Console.WriteLine($"Counter for {typeof(T)}: {value}");
    }

    //  2.2.2 CLR and framework support: The Nullable<T> struct

    public struct NullableGeneric<T> where T : struct
    {
        private bool hasValue;
        private T value;
        public NullableGeneric(T value)
        {
            this.hasValue = true;
            this.value = value;
        }
        public bool HasValue { get { return hasValue; } }
        public T Value
        {
            get
            {
                if (!hasValue)
                {
                    throw new InvalidOperationException("No value");
                }
                return value;
            }
        }
    }

    class NullableValueTypes
    {
        public static void PrinValueAsInt(object o)
        {
            int? nullable = o as int?;
            Console.WriteLine(nullable.HasValue ? nullable.Value.ToString() : "null");
        }
    }

    class UsingDelegates
    {
        public delegate int Delegate1(int a, int b);

        public int Add(int a, int b)
        {
            Console.WriteLine(a + b);

            return a + b;
        }

        public int Multiple(int a, int b)
        {
            Console.WriteLine(a * b);

            return a * b;
        }

        public int Minus(int a, int b)
        {
            Console.WriteLine(a - b);

            return a - b;
        }
    }

}
