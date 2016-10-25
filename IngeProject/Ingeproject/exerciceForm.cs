using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingeproject
{
    public partial class exerciceForm : Form
    {
        int i = 1;
        Stopwatch t = new Stopwatch();
        int[,] tab = { 
            { 20, 179 }, 
            { 160, 147 }, 
            { 100, 58 }, 
            { 400, 170 }, 
            { 270, 27 }, 
            { 150, 290 }, 
            { 100, 100 }, 
            { 480, 380 },
            { 40, 280 }, 
            { 280, 20 } };

        public Attempt actual { get; set; }
        private void initialisation()
        {
            InitializeComponent();
            this.Width = 550;
            this.Height = 550;
            Inverter v = new Inverter(false, false);
            Button b = new Button();
            b.Top = 100;
            b.Left = 50;
            b.Click += buttonClick;
            v.Start();
            this.Controls.Add(b);
            this.FormClosed += quit;
        }

        private void quit(object sender, FormClosedEventArgs e)
        {
            actual.save();
            Application.Exit();
        }

        public exerciceForm(Attempt _actual)
        {
            actual = _actual;
            initialisation();
        }
        public exerciceForm()
        {
            initialisation();
        }
        public void buttonClick(Object sender,EventArgs e)
        {
            if(i==1)
            {
                t.Start();
            }
            //MessageBox.Show("coucou");
            Button old = (Button)sender;
            old.Visible = false;

            if (i < tab.GetLength(0))
            {
                Button b = new Button();
                b.Click += buttonClick;
                b.Left = tab[i, 0];
                b.Top = tab[i, 1];
                this.Controls.Add(b);
                i++;
            }
            else
            {
                t.Stop();
                MessageBox.Show(Convert.ToString(t.Elapsed.Seconds)+' '+Convert.ToString(t.Elapsed.Milliseconds));
            }
            
        }
    }
}
