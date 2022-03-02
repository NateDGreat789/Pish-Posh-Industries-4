using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Pish_Posh_Industries
{
    public partial class Form1 : Form
    {
        double cars = 0;
        double houses = 0;
        double companies = 0;

        double subtotal = 0;
        double tax = 0;
        double total = 0;

        double tendered = 0;
        double change = 0;

        public Form1()
        {
            InitializeComponent();

            tenderedbutton.Enabled = false;
            printbutton.Enabled = false;
            morebutton.Enabled = false;
            exitbutton.Enabled = false;

            tenderedinput.Enabled = false;
        }

        private void givebutton_Click(object sender, EventArgs e)
        {
            SoundPlayer registerPlayer = new SoundPlayer(Properties.Resources.register);
            registerPlayer.Play();
            
            tenderedbutton.Enabled = true;
            tenderedinput.Enabled = true;
            
            try
            {
                cars = Convert.ToDouble(carinput.Text);
                houses = Convert.ToDouble(houseinput.Text);
                companies = Convert.ToDouble(companyinput.Text);

                subtotal = cars * 100000 + houses * 3000000 + companies * 1000000000;
                tax = subtotal * 0.13;
                total = subtotal + tax;

                subtotallabel.Text = "Sub Total:";
                taxlabel.Text = "Tax:";
                totallabel.Text = "Total:";

                subtotaloutput.Text = $"{subtotal.ToString("C")}";
                taxoutput.Text = $"{tax.ToString("C")}";
                totaloutput.Text = $"{total.ToString("C")}";

                if (cars + houses + companies < 1)
                {
                    subtotallabel.Text = "BUY!!!!";
                    taxlabel.Text = "";
                    totallabel.Text = "";

                    subtotaloutput.Text = "";
                    taxoutput.Text = "";
                    totaloutput.Text = "";

                    tenderedbutton.Enabled = false;
                    tenderedinput.Enabled = false;
                }
            }
            catch
            {
                subtotallabel.Text = "YOU DARE MOCK PISH POSH INDUSTRIES?!?!?!?!";
            }
        }

        private void tenderedbutton_Click(object sender, EventArgs e)
        {
            printbutton.Enabled = true;
            SoundPlayer registerPlayer = new SoundPlayer(Properties.Resources.register);
            registerPlayer.Play();
            
            try
            {
                changelabel.Text = "Fine, we'll return your change.";

                tendered = Convert.ToDouble(tenderedinput.Text);
                change = tendered - total;

                changeoutput.Text = $"{change.ToString("C")}";

                if (change < 0)
                {
                    printbutton.Enabled = false;
                    changelabel.Text = "MORE MONEY!!!!";
                    changeoutput.Text = "";
                }
            }
            catch
            {
                tenderedlabel.Text = "YOU DARE MOCK PISH POSH INDUSTRIES?!?!?!?!";
            }
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            SoundPlayer registerPlayer = new SoundPlayer(Properties.Resources.register);
            registerPlayer.Play();

            exitbutton.Enabled = true;
            receiptlabel.Text = "\n\n                      Pish Posh Industries";
            
            Refresh();
            Thread.Sleep(400);
            
            receiptlabel.Text += $"\n   February 29, 2022";

            if (cars > 0)
            {
                Refresh();
                Thread.Sleep(400); receiptlabel.Text += $"\n   Cars                  x{cars} @ $100 000";
            }

            if (houses > 0)
            {
                Refresh();
                Thread.Sleep(400); receiptlabel.Text += $"\n   Houses              x{houses} @ $5 000 000$";
            }

            if (companies > 0)
            {
                Refresh();
                Thread.Sleep(400); receiptlabel.Text += $"\n   Companies         x{companies} @ 1 000 000 000";
            }
            
            Refresh();
            Thread.Sleep(400); 
            
            receiptlabel.Text += $"\n\n   Subtotal             {subtotal.ToString("C")}";
            
            Refresh();
            Thread.Sleep(400); 
            
            receiptlabel.Text += $"\n   Tax                    {tax.ToString("C")}";
            
            Refresh();
            Thread.Sleep(400); 
            
            receiptlabel.Text += $"\n   Total                  {total.ToString("C")}";
            Refresh();
            
            Thread.Sleep(400); 
            
            receiptlabel.Text += $"\n\n   Tendered           {tendered.ToString("C")}";
            
            Refresh();
            Thread.Sleep(400); 
            
            receiptlabel.Text += $"\n   Change              {change.ToString("C")}";
            
            Refresh();
            Thread.Sleep(400); 
            
            receiptlabel.Text += $"\n\n   Pish Posh friend (any who gives money is a\n   friend)! ";

            morebutton.Enabled = true;
        }

        private void morebutton_Click(object sender, EventArgs e)
        {
            receiptlabel.Text = "";
            
            subtotallabel.Text = "";
            taxlabel.Text = "";
            totallabel.Text = "";

            subtotaloutput.Text = $"";
            taxoutput.Text = $"";
            totaloutput.Text = $"";

            changelabel.Text = "";
            changeoutput.Text = $"";

            carinput.Text = "0";
            houseinput.Text = "0";
            companyinput.Text = "0";

            tenderedinput.Text = "0";

            tenderedbutton.Enabled = false;
            printbutton.Enabled = false;
            morebutton.Enabled = false;
            tenderedinput.Enabled = false;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
