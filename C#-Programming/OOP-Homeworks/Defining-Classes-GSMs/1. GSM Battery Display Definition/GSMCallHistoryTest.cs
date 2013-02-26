using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GSMLib;

namespace _1.GSM_Battery_Display_Definition
{
    class GSMCallHistoryTest
    {
        public static void TestGSMCallHistory()
        {
            Console.WriteLine("Testing GSM Call hostory:\n");

            GSM myGSM = new GSM("C101", "Finland", 20, "Me", new Battery("LiMion", 200, 8, BatteryType.LiIon),
                new Display(20000, new int[] { 32, 64 }));

            Call firstCall = new Call(DateTime.Today, "104123 123 123", 430);

            Call secondCall = new Call(new DateTime(2013, 01, 31, 22, 43, 22), "102  2313", 120);

            Call thirdCall = new Call(new DateTime(2013, 1, 23, 12, 30, 04), "12314", 30);

            myGSM.AddCalltoCallHistory(firstCall);
            myGSM.AddCalltoCallHistory(secondCall);
            myGSM.AddCalltoCallHistory(thirdCall);

            Console.WriteLine(myGSM.PrintCallHistory());

            Console.WriteLine("Total call price: " + String.Format("{0:c2}", myGSM.GetCallValue(0.37M)));

            Console.WriteLine("\nRemoving the longest phone call from History\n");

            long longestCallDuration = 0;

            Call longestCall = null;

            //Getting the longest Call
            foreach (Call call in myGSM.CallHistory)
            {
                if (call.CallDuration > longestCallDuration)
                {
                    longestCallDuration = call.CallDuration;

                    longestCall = call;
                }
            }

            //Remove the longest Call
            myGSM.RemoveCallfromHistory(longestCall);

            Console.WriteLine("Total Price after removing the longest Call: " + 
                String.Format("{0:c2}", myGSM.GetCallValue(0.37M)));

            Console.WriteLine("\nClearing Call History.");
            myGSM.ClearHistory();

            Console.WriteLine("\nAfter clearing the history, call history is:");
            Console.WriteLine(myGSM.PrintCallHistory());
        }
    }
}
