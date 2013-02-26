using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMLib
{
    public class GSM
    {
        //Task 01
        private double? price;

        //Task 09
        private List<Call> callHistory;

        public Battery Battery { get; private set; }
        public Display Display { get; private set; }
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public string Owner { get; private set; }
        public double? Price { 
            get { return this.price; } 
            //Task 05
            private set { if (value > 0) this.price = value; } 
        }
        //End of task 01

        //Task 06
        private static GSM iPhone4SInfo = new GSM("IPhone4S", "Taiwan", 500, "Me",
            new Battery("iPhoneBattery", 200, 8, BatteryType.LiIon), 
            new Display(16000000, new int[] { 960, 640 }));

        public GSM IPhone4SInfo { get { return GSM.iPhone4SInfo; } private set { } }

        //Task 09
        public List<Call> CallHistory
        {
            //Returning a new List of calls(if a reference to the list is returned,
            //the data will be exposed to changes from outside the class
            get
            {
                List<Call> resultList = new List<Call>();
 
                foreach(Call call in this.callHistory)
                {
                    resultList.Add(new Call(call.DateAndTime, call.DialedPhoneNumber, call.CallDuration));
                }

                return resultList;
            }
            set
            {
                //Create a new List and deep copy the Calls, otherwise it will be possible
                // to change the data outside the class
                if (value != null)
                {
                    this.callHistory = new List<Call>();

                    foreach (Call call in value)
                    {
                        this.callHistory.Add(new Call(call.DateAndTime, call.DialedPhoneNumber,
                            call.CallDuration));
                    }
                }
            }
        }

        //Task 02
        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = new Battery(battery);
            this.Display = new Display(display);

            //Initiate CallHistory also
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        { }
        //End of Task 02


        //Task 10
        public void AddCalltoCallHistory(Call inputCall)
        {
            if (inputCall != null)
            {
                //Enter a Call only if the Call is not in the CallHistory already
                if (!this.callHistory.Contains(inputCall))
                {
                    this.callHistory.Add(new Call(inputCall.DateAndTime, inputCall.DialedPhoneNumber,
                        inputCall.CallDuration));
                }
            }
        }

        //Task 10
        public void RemoveCallfromHistory(Call inputCall)
        {
            this.callHistory.Remove(inputCall);
        }
         
        //Task 10
        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        //Task 11, return calls total price
        public decimal GetCallValue(decimal price)
        {
            decimal totalCallPrice = 0.0M;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalCallPrice += (this.callHistory[i].CallDuration/60.0M)*price;
            }

            return totalCallPrice;
        }

        //Task 12, print the call history
        public string PrintCallHistory()
        {
            StringBuilder resultString = new StringBuilder();

            if (this.callHistory == null || this.callHistory.Count == 0)
            {
                return "Empty Call History.";
            }


            resultString.Append("Call History:\n");

            foreach (Call call in this.callHistory)
            {
                resultString.Append(call.ToString()).Append("\n");
            }

            return resultString.ToString();
        }

        //Task 04
        //using the toString() methods of Battery and Display classes
        public override string ToString()
        {
            StringBuilder resultString = new StringBuilder();

            resultString.Append(String.Format("GSM (Model: {0}):\n", this.Model));

            resultString.Append("Manufacturer: ").Append(this.Manufacturer??"Uknown").Append("\n");
            resultString.Append("Price: ");
            if (this.Price != null)
            {
                resultString.Append(this.Price);
            }
            else
            {
                resultString.Append("Uknown");
            }
            resultString.Append("\n");
            resultString.Append("Owner: ").Append(this.Owner ?? "Uknown").Append("\n");
            resultString.Append("Battery: (\n").Append(this.Battery.ToString()).Append(")\n");
            resultString.Append("Display: (").Append(this.Display.ToString()).Append(")");

            return resultString.ToString();
        }
    }
}
