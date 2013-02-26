using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GSM_Battery_Display_Definition
{
    class InitiateTests
    {
        public static void Main(String[] args)
        {
            GSMTest.TestGSM();

            GSMCallHistoryTest.TestGSMCallHistory();
        }
    }
}
