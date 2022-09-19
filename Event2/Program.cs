using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form f1 = new Form();
            Controller c = new Controller(f1);
            f1.ShowDialog();


            Console.ReadKey();
        }

    }

    class Controller
    {
        private Form f;

        public Controller(Form f)
        {
            if (f != null)
            {
                this.f = f;
                this.f.Click += F_Click;
            }
        }

        private void F_Click(object sender, EventArgs e)
        {
            this.f.Text = DateTime.Now.ToString();
        }
    }
}
