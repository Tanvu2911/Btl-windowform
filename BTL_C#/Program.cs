
using System;
using System.Windows.Forms;

namespace BTL_C_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (Form1 form1 = new Form1())
                {
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        //if (Form1.LoggedInRole == "Admin")
                        //{
                        //    Application.Run(new QLThuVien());
                        //}
                        //else if (Form1.LoggedInRole == "Customer")
                        //{
                        //    //Application.Run(new FormKhachHang());
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Quyền truy cập không hợp lệ!");
                        //    continue;
                        //}
                        Application.Run(new QLThuVien());
                    }
                    else
                    {
                        break;
                    }
                } 
            }
        }
    }
}

