using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMLib;

namespace _1.GSM_Battery_Display_Definition
{
    class GSMTest
    {
        //Task 07
        public static void TestGSM()
        {
            Console.WriteLine("Testing GSMs:\n");

            Battery newBattery = new Battery("Tesla Battery", 300, 10, BatteryType.LiIon);

            Display newDisplay = new Display(12000000, new int[] { 10, 10 });

            GSM motorollaGSM = new GSM("T100", "Motorola", null, null, newBattery, newDisplay);
            
            GSM nokiaGSM = new GSM("c101", "Nokia", 20, "Me", new Battery("NokiaBattery"),
                new Display(2000, new int[] { 32, 64 }));
            
            GSM alcatelGSM = new GSM("alcatel", "China");

            GSM[] manyGSMs = new GSM[] { motorollaGSM, nokiaGSM, alcatelGSM };

            foreach (GSM gsm in manyGSMs)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Iphone 4S Info:");
            Console.WriteLine(motorollaGSM.IPhone4SInfo.ToString());
        }
    }
}
