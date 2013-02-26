using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMLib
{
    public class Display
    {
        //Task 01
        private int[] size;
        private int? colors;

        public int? Colors {
            get { return this.colors; }
            //Task 05
            private set{
                    if (value > 0)
                    {
                        this.colors = value;
                    }
            } 
        }
        public int[] Size { 
            get 
            {
                if (this.size != null)
                {
                    return new int[] { this.size[0], this.size[1] };
                }
                else
                {
                    return null;
                }
            } 
            private set 
            {
                //Task 05
                if (value != null && value[0] > 0 && value[1] > 0)
                {
                    size = new int[] { value[0], value[1] };
                }
                else
                {
                    size = null;
                }
            } 
        }

        //Task 02
        public Display(int? colors, int[] size)
        {
            this.Colors = colors;
            this.Size = size;
        }

        public Display() : this(null, null) { }

        //Copy Constructor
        public Display(Display display)
        {
            if (display != null)
            {
                this.Colors = display.Colors;
                this.Size = display.size;
            }
            else
            {
                this.Colors = null;
                this.Size = null;
            }
        }
        //End of task 02

        //Task 04
        public override string ToString()
        {
            StringBuilder resultString = new StringBuilder();

            resultString.Append("Colors: ");
            if (this.Colors != null)
            {
               resultString.Append(this.Colors);
            }
            else
            {
                resultString.Append("Uknown.");
            }
            resultString.Append(" ");

            resultString.Append("Size: ");
            if (this.size != null)
            {
                resultString.Append(this.Size[0]).Append("x").Append(this.Size[1]);
            }
            else
            {
                resultString.Append("Unknown");
            }
            return resultString.ToString();
        }
    }
}
