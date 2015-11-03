using System;
//using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        delegate void SetNoCallback(int [] numbers);

        Game casinoGame;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casinoGame = new Game();
            casinoGame.NextNumbers += RetrieveNumbers;
            button1.Enabled = false;

        }

        /// <summary>
        /// To be called to update numbers
        /// </summary>
        /// <param name="no"></param>
        public void RetrieveNumbers(int [] no)
        {
            if (this.textBox1.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetNoCallback d = new SetNoCallback(SetText);
                this.Invoke(d, new object[] { no });
            }
            else
                SetText(no);
        }

        private void SetText(int [] no)
        {
            textBox1.Text = no[0].ToString();
            textBox2.Text = no[1].ToString();
            textBox3.Text = no[2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            casinoGame.StopPlay();
            button1.Enabled = true;
        }
    }
}

