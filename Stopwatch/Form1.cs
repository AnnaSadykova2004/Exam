using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public int mill, sek, min;

        private DateTime startTime;
        private TimeSpan elapsedTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            elapsedTime = DateTime.Now - startTime;
            label1.Text = elapsedTime.ToString(@"mm\:ss\.f");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Пуск";
                sek = 0;
                min = 0;
                mill = 0;
            }
            else
            {
                timer1.Start();
                button1.Text = "Стоп";
                startTime = DateTime.Now - elapsedTime;

                mill += 1;
                if(mill == 10)
                {
                    mill = 0;
                    sek += 1;
                }
                if (sek == 60)
                {
                    sek = 0;
                    min += 1;
                }             

            }

        }

        private float elapsedSeconds;
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            elapsedSeconds = 0;
            //elapsedTime = TimeSpan.Zero;
            label1.Text = "00:00.0";
            button1.Text = "Пуск";
            sek = 0;
            min = 0;
            mill = 0;
        }
    }
}
