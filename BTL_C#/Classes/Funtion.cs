using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.Classes
{
    internal class Funtion
    {
        public void FillCombobox(ComboBox cb1, DataTable dt, String display, string value)
        {
            cb1.DataSource = dt;
            cb1.DisplayMember = display;
            cb1.ValueMember = value;
        }
    }
}
