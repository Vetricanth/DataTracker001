using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTracker
{
    public partial class detailButton : Form
    {
        Button detailbutt;
        string txt;
        DataGridViewCell ugh;
        


        public detailButton(Button detailBut)
        {
            InitializeComponent();
            detailbutt = detailBut;
            richTextBox1.Text = detailBut.Text;
        }

        public detailButton(DataGridViewCell detailBut)
        {
            InitializeComponent();
            ugh = detailBut;
            richTextBox1.Text = detailBut.Value.ToString();
        }

        private void detailButton_TextChanged(object sender, EventArgs e)
        {
            if (!(detailbutt == null))
            {
                detailbutt.Text = richTextBox1.Text;
            }

            if (!(ugh == null))
            {
                ugh.Value = richTextBox1.Text;
            }
            txt = richTextBox1.Text;
        }
    }
}
