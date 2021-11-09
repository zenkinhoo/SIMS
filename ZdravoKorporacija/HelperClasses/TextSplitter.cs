using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Bolnica.HelperClasses
{
    public class TextSplitter
    {
        public static int[] TextBoxTimeSplitter(TextBox tb)
        {
            int[] hoursAndMinutes = new int[2];
            string[] hoursAndMinutesFromTextbox = tb.Text.Split(':');
            hoursAndMinutes[0] = Convert.ToInt32(hoursAndMinutesFromTextbox[0]);
            hoursAndMinutes[1] = Convert.ToInt32(hoursAndMinutesFromTextbox[1]);
            return hoursAndMinutes;
        }
    }
}
