using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softcom.Helpers
{
    public class DropDownItem
    {
        string text;
        string value;

        public DropDownItem(string t, string v)
        {
            text = t;
            value = v;
        }

        public string TextVal
        {
            get
            {
                return value;
            }
        }

        public int NumVal
        {
            get
            {
                return Convert.ToInt32(value);
            }
        }

        public override string ToString()
        {
            return text;
        }
    }
}
