using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005003
{
    class ProjectMain
    {

        static void Main(String[] Args)
        {

            MyForm form = new MyForm();
            form.ShowDialog();

            Console.ReadLine();
            return;
        }

    }

    class MyForm : Form {
        private TextBox textBox;
        private Button button;

        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.textBox.Top = 20;
            this.textBox.Left = 20;
            this.button.Top = 50;
            this.button.Left = 50;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);
            this.button.Click += this.ButtonClicked;
            this.button.Text = "button";
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello,World";
        }
    }

}
