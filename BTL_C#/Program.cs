using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            Form1 form1 = new Form1();

            if (form1.ShowDialog() == DialogResult.OK)
            {
                if (Form1.LoggedInRole == "Admin")
                {
                    Application.Run(new QLThuVien());                }
                else if (Form1.LoggedInRole == "Customer")
                {
                    
                }
                else
                {
                    MessageBox.Show("Quyền truy cập không hợp lệ!");
                }
            }


        }
    }
}
