using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Task 08
namespace GSMLib
{
    public class Call
    {
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private long callDuration;

        public DateTime DateAndTime
        {
            get 
            { 
                return new DateTime(this.dateAndTime.Ticks);
            }
            private set 
            {
                if (value != null)
                {
                    this.dateAndTime = new DateTime(value.Year,value.Month,value.Day,
                        value.Hour, value.Minute, value.Second);
                }
            }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            private set
            {
                //Only 6 or more digits are allowed as a valid number, empty space allowed also
                Match validationMatch = Regex.Match(value, "[^0-9 ]");

                //Making sure Number containing only empty spaces is not allowed
                Match emptySpacesCount = Regex.Match(value, " ");

                if (!validationMatch.Success && ((value.Length - emptySpacesCount.Groups.Count) >= 6))
                {
                    this.dialedPhoneNumber = value;
                }
                else
                {
                    this.dialedPhoneNumber = "Uknown";
                }
            }
        }

        public long CallDuration
        {
            get { return this.callDuration; }
            private set
            {
                //It is possible to have a call with zero duration if you just clip on someone
                //(call him but not wait for him to pick up)
                if (value >= 0)
                {
                    this.callDuration = value;
                }
            }
        }

        public Call(DateTime inputDateAndTime, string inputPhoneNumber, long inputCallDuration)
        {
            this.DateAndTime = inputDateAndTime;
            this.DialedPhoneNumber = inputPhoneNumber;
            this.CallDuration = inputCallDuration;
        }

        //Needed in order to Compare Calls, and remove a specific call fromthe Call History of the GSM
        public override bool Equals(object obj)
        {
            Call inputCall = (Call)obj;

            bool isEqual = false;

            isEqual = (this.dateAndTime.Equals(inputCall.dateAndTime));

            isEqual = isEqual && (this.dialedPhoneNumber.Equals(inputCall.dialedPhoneNumber,
                StringComparison.InvariantCultureIgnoreCase));

            isEqual = isEqual && (this.callDuration == inputCall.callDuration);

            return isEqual;
        }

        public override string ToString()
        {
            StringBuilder resultString = new StringBuilder();

            resultString.Append("Call Info:\n");
            resultString.Append("Date of call: ").Append(this.DateAndTime.ToShortDateString()).Append("\n");
            resultString.Append("Time of call: ").Append(this.DateAndTime.ToShortTimeString()).Append("\n");
            resultString.Append("Call Number: ").Append(this.dialedPhoneNumber).Append("\n");
            resultString.Append("Duration: ").Append(this.CallDuration).Append(" seconds");

            return resultString.ToString();
        }

    }
}
