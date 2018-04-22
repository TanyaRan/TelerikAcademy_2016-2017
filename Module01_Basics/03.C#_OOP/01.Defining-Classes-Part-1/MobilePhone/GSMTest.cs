using System;

namespace MobilePhone
{
    public class GSMTest
    {
        public static void Main()
        {
            PhoneTest();

            PhoneCallHistoryTest();
        }

        private static void PhoneCallHistoryTest()
        {
            GSM testPhone = new GSM("Lenovo", "NewsCorp");

            testPhone.AddCall("+359871112142", 3);
            testPhone.AddCall("+359811422242", 12);
            testPhone.AddCall("+359833312142", 41);
            testPhone.AddCall("+359833334442", 7);
            testPhone.AddCall("+359614435552", 62);

            testPhone.ShowCallHistory();

            Console.WriteLine("Total call price: " + testPhone.TotalCallPrice());

            testPhone.DeleteCall(5);
            Console.WriteLine("Removed Longest call!");

            Console.WriteLine("Total call price: " + testPhone.TotalCallPrice());

            testPhone.ClearCallHistory();
            Console.WriteLine("Cleared call history!");
            testPhone.ShowCallHistory();
        }

        private static void PhoneTest()
        {
            GSM test1 = new GSM("Nokia", "SantaCo", 140000, "HappyOwner",
                new Battery(BatteryType.NiCd, 100, 100), new Display(8, 16000000));

            GSM test2 = new GSM("Koko", "Kamerun");

            GSM test3 = new GSM("Bubka", "Zambezi", 100, "Tito", new Battery(), new Display());

            GSM[] testAll = new GSM[] { test1, test2, test3 };

            foreach (var Phone in testAll)
            {
                Console.WriteLine(Phone);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
