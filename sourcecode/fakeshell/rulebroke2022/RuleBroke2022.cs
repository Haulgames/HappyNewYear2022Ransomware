using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuleBrokeHappyNewYear2022
{
    public partial class RuleBroke2022 : Form
    {
        public RuleBroke2022()
        {
            InitializeComponent();
            Cursor.Hide();
            this.TransparencyKey = Color.Transparent;
            this.Text = "Shell is Overwrited";
        }

        private void RuleBroke2022_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
