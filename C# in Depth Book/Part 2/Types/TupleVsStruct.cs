﻿namespace Part2.Types
{
    public class TupleVsStruct
    {
        public static void MainMethod()
        {
            var person = (Name: "Abbos", Age: 21, isStudent: true);

            Console.WriteLine(person.isStudent);
        }
    }
}
