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
        }

        private void givebutton_Click(object sender, EventArgs e)
        {
            SoundPlayer registerPlayer = new SoundPlayer(Properties.Resources.register);
            registerPlayer.Play();
            
            tenderedbutton.Enabled = true;
            
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
            receiptlabel.Text = "\n\n                Pish Posh Industries";
            receiptlabel.Text += $"\n   February 29, 2022";
            receiptlabel.Text += $"\n   Cars                  x{cars} @ $100 000";
            receiptlabel.Text += $"\n   Houses              x{houses} @ $5 000 000$";
            receiptlabel.Text += $"\n   Companies         x{companies} @ 1 000 000 000";
            receiptlabel.Text += $"\n\n   Subtotal             {subtotal.ToString("C")}";
            receiptlabel.Text += $"\n   Tax                    {tax.ToString("C")}";
            receiptlabel.Text += $"\n   Total                  {total.ToString("C")}";
            receiptlabel.Text += $"\n\n   Tendered           {tendered.ToString("C")}";
            receiptlabel.Text += $"\n   Change              {change.ToString("C")}";
            receiptlabel.Text += $"\n\n   Pish Posh friend (any who gives money is a    friend)! ";

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

            changelabel.Text = "Fine, we'll return your change.";
            changeoutput.Text = $"";
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
