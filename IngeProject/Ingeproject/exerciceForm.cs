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
        bool endE1 = false;
        bool endE2 = false;
        bool endE3 = false;
        Label current;
        int j = 0;
        int i = 1;
        Inverter v;
        Stopwatch t = new Stopwatch();
        int[,] exercice1Tab = { 
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
        int[,] exercice2Tab = {
            { 20, 179 },
            { 400, 170 },
            { 100, 58 },
            { 100, 100 },
            { 270, 27 },
            { 40, 280 },
            { 480, 380 },
            { 150, 290 },
            { 280, 20 },
         { 160, 147 }   };
        private int cpt=0;
        
        public Attempt actual { get; set; }
        private void initialisation()
        {
            
            InitializeComponent();
            this.Width = 550;
            this.Height = 550;
            this.FormClosed += quit;
            MouseClick += onClic;
            exercice1();
        }

        private void onClic(object sender, MouseEventArgs e)
        {
            cpt++;
        }

        private void exercice4()
        {
            MessageBox.Show("Dans cet eercice vous devrez être le plus précis et le plus rapide possible et cliquer sur les petites croix. \n Attention cette fois la souris est inversée");
            if (endE3)
            {
                i = 1;
                cpt = 0;
                j = 3;
                t.Reset();
                v.Stop();
                v = new Inverter(true, true);
                v.Start();
                current = new Label();
                current.Top = 300;
                current.Left = 150;
                current.Text = "+";
                current.AutoSize = false;
                current.Width = 13;
                current.Height = 13;
                this.Controls.Add(current);
                current.Click += precisionClick2;

            }
        }

        private void exercice3()
        {
            MessageBox.Show("Dans cet eercice vous devrez être le plus précis et le plus rapide possible et cliquer sur les petites croix.");

            if (endE2)
            { 
                i = 1;
                cpt = 0;
                j = 2;
                t.Reset();
                v.Stop();
                v = new Inverter(false, false);
                v.Start();
               current = new Label();
               
                current.Top = 300;
                current.Left = 150;
                current.Text = "+";
                current.AutoSize = false;
                current.Width = 13;
                current.Height = 13;
                this.Controls.Add(current);
                MouseClick -= onClic;
                MouseClick += precisionClick;
                current.Click += precisionClick2;
                
            }
        }

        private void precisionClick2(object sender, EventArgs e)
        {
            
            int X = Control.MousePosition.X - this.Left - 13;
            int Y = Control.MousePosition.Y - this.Top - 37;
            calculation(X, Y, current.Left, current.Top);
        }

        private void precisionClick(object sender, MouseEventArgs e)
        {
            int X = e.X - 5;
            int Y = e.Y - 5;
            calculation(X, Y, current.Left, current.Top);
        }

        private void exercice2()
        {
            MessageBox.Show("Dans cet exercice vous devrez etre le plus rapide et cliquer sur toutes les boites \n Attention La souris est inversée");
            if (endE1)
            {
                j = 1;
                i = 1;
                cpt = 0;
                t.Reset();

                v.Stop();
                
                v = new Inverter(true, true);
                Button b = new Button();
                b.Top = 100;
                b.Left = 50;
                b.Click += buttonex1Click;
                v.Start();
                this.Controls.Add(b);
            }
        }

        private void exercice1()
        {

            MessageBox.Show("Dans cet exercice vous devrez etre le plus rapide et cliquer sur toutes les boites ");

            
            v = new Inverter(false, false);
            Button b = new Button();
            b.Top = 100;
            b.Left = 50;
            b.Click += buttonex1Click;
            v.Start();
            this.Controls.Add(b);

        }
        private void calculation(int x, int y,int x2,int y2)
        {
            if(i==1)
            {
                t.Start();
            }
            if (i < 10)
            {
                actual.distance[i-1, j - 2] = Math.Sqrt(Math.Pow(1.0 * (x - x2), 2) + Math.Pow(1.0 * (y - y2), 2));
                current.Visible = false;
                current = new Label();
                current.Top = exercice2Tab[i, 0];
                current.Left = exercice2Tab[i, 1];
                current.Text = "+";
                current.AutoSize = false;
                current.Width = 13;
                current.Height = 13;
                current.Click += precisionClick2;
                this.Controls.Add(current);
                i++;
            }
            else
            {
                if(i==10)
                {
                    actual.distance[i - 1, j - 2] = Math.Sqrt(Math.Pow(1.0 * (x - x2), 2) + Math.Pow(1.0 * (y - y2), 2));
                }
                t.Stop();
                actual.TimeAttempt[j] = 1000 * Convert.ToInt32(t.Elapsed.Seconds) + Convert.ToInt32(t.Elapsed.Milliseconds);
                if (!endE3)
                {
                    current.Visible = false;
                    endE3 = true;
                    exercice4();
                   
                }
                else
                {
                    MessageBox.Show("Merci");
                    actual.save();
                    this.Close();

                }
            }
           
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
        public void buttonex1Click(Object sender,EventArgs e)
        {
            if (i == 1)
            {
                t.Start();
            }
            Button old = (Button)sender;
            old.Visible = false;

            if (i < 2)
            {
                Button b = new Button();
                b.Click += buttonex1Click;
                b.Left = exercice1Tab[i, 0];
                b.Text = Convert.ToString(j);
                b.Top = exercice1Tab[i, 1];
                this.Controls.Add(b);
                i++;
            }
            else
            {
               
                t.Stop();
                actual.errorsAttempt[j] = cpt;
                actual.TimeAttempt[j] = 1000 * Convert.ToInt32(t.Elapsed.Seconds) + Convert.ToInt32(t.Elapsed.Milliseconds);

                if (!endE1)
                {
                    endE1 = true;
                    exercice2();
                }
                else
                {
                    endE2 = true;
                    exercice3();
                    
                }
               
            }
            
        }
    }
}
