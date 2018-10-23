using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercuryHardwareTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide Panels
            pan_Ethernet.Visible = false;
            pan_RS485.Visible = false;
            pan_Comb.Visible = false;

            //Set Combobox selection to 0
            cbx_Connectivity.SelectedIndex = 0;
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            var doorCount = Convert.ToInt32(num_DoorCount.Value);
            var ep1502 = doorCount / 2;
            MessageBox.Show("EP1502 count = " + ep1502.ToString());

        }

        private void cbx_Connectivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Connectivity.SelectedIndex == 0)
            {
                //Message
                //MessageBox.Show("Please choose a connection type");
            }
            else if (cbx_Connectivity.SelectedIndex == 1)
            {
                pan_Ethernet.Visible = true;
                pan_RS485.Visible = false;
                pan_Comb.Visible = false;
            }
            else if (cbx_Connectivity.SelectedIndex == 2)
            {
                pan_Ethernet.Visible = false;
                pan_RS485.Visible = true;
                pan_Comb.Visible = false;
            }
            else
            {
                pan_Ethernet.Visible = false;
                pan_RS485.Visible = false;
                pan_Comb.Visible = true;
            }
        }
    }
}
