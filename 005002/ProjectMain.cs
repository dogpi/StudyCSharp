using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005002
{
    class ProjectMain
    {


        static void Main(String[] Args)
        {

            MyForm form = new MyForm();
            form.Click += form.FormClick;

            form.ShowDialog();
            Console.ReadLine();
            return;
        }

    }

    class MyForm : Form
    {
        internal void FormClick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }

}
