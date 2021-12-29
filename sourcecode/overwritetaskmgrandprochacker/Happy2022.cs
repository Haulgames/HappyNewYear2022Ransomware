using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy2022
{
    public partial class Happy2022 : Form
    {
        public Happy2022()
        {
            MessageBox.Show($"Are U Happy, {Environment.UserName}???" + Environment.NewLine + "Because IT'S NEW YEAR!!! :D" + Environment.NewLine + "Seriously...", "Happy 2022!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Environment.Exit(-554);
            InitializeComponent();
        }
    }
}
