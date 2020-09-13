using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00501添加Windows.Froms
{
    class ProjectMain
    {
        static void Main(String[] Args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);


            form.ShowDialog();

            Console.ReadLine();
            return;
        }
    }

    class Controller
    {
        private Form form;
        public Controller(Form form_)
        {
            if (form_ != null)
            {
                this.form = form_;
                this.form.Click += this.FormClicked;
            }
        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
