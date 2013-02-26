using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMLib
{
    //Task 03
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    public class Battery
    {
        //Task 01
        private int? idleHours;
        private int? talksHours;

        public string Model { get; private set; }
        public int? IdleHours 
        {
            get { return this.idleHours; } 
            //Task 05
            private set { if (value > 0) this.idleHours = value; }
        }
        public int? TalkHours
        {
            get { return this.talksHours; }
            //Task 05
            private set { if (value > 0) this.talksHours = value; }
        }

        //Task 03
        public BatteryType? BatteryType { get; private set; }

        //Task 02
        public Battery(string model, int? idleHours, int? talkHours, BatteryType? batterType)
        {
            this.Model = model;
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.BatteryType = batterType;
        }

        public Battery(string model)
            : this(model, null, null, null)
        {
        }

        public Battery(Battery battery)
        {
            if (battery != null)
            {
                this.Model = battery.Model;
                this.IdleHours = battery.IdleHours;
                this.TalkHours = battery.TalkHours;
                this.BatteryType = battery.BatteryType;
            }
            else
            {
                this.Model = null;
                this.IdleHours = null;
                this.TalkHours = null;
                this.BatteryType = null;
            }
        }
        //End of task 02

        //Task 04
        public override string ToString()
        {
            StringBuilder resultString = new StringBuilder();

            resultString.Append("Model: ").Append(this.Model ?? "Uknown.").Append("\n");

            resultString.Append("Idle Hours: ");
            if (this.IdleHours!= null)
            {
                resultString.Append(this.IdleHours);
            }
            else
            {
                resultString.Append("Uknown");
            }
            resultString.Append("\n");

            resultString.Append("Talk Hours: ");
            if (this.TalkHours!= null)
            {
                resultString.Append(this.TalkHours);
            }
            else
            {
                resultString.Append("Uknown");
            }
            resultString.Append("\n");

            resultString.Append("Battery Type: ");
            if (this.BatteryType!= null)
            {
                resultString.Append(this.BatteryType);
            }
            else
            {
                resultString.Append("Uknown");
            }

            return resultString.ToString();
        }
    }
}
