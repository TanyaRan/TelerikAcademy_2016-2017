using System;

namespace GenericListTasks
{
    public class GenericListSatrtup
    {
        public static void Main()
        {
            Console.WriteLine("Add elements 118, 2, -33, 4, -100");
            GenericList<int> testList = new GenericList<int>(1);
            testList.AddElement(118);
            testList.AddElement(2);
            testList.AddElement(-33);
            testList.AddElement(4);
            testList.AddElement(-100);

            Console.WriteLine(testList);

            Console.WriteLine("Remove element at index 3");
            testList.RemoveElemAtIndex(3);
            Console.WriteLine(testList);

            Console.WriteLine("Insert element at index 2");
            testList.InsertElemAtIndex(2, 123);
            Console.WriteLine(testList);

            Console.WriteLine("Find element 123 by value");
            Console.WriteLine(testList.FindElemByValue(123));

            Console.WriteLine("Min and Max of List");
            Console.WriteLine(testList.Max());
            Console.WriteLine(testList.Min());

            Console.WriteLine("Clear List");
            testList.ClearList();
            Console.WriteLine(testList);
        }
    }
}
