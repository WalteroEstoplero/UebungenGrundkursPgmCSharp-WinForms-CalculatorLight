using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UebungenGrundkursPgmCSharp_WinForms_Aufg3
{
    public partial class Form_calcu : Form
    {
        double result;

        public Form_calcu()
        {
            InitializeComponent();
        }

        private void Btn_calcu_Click(object sender, EventArgs e)
        {
            if (Tbx_op.Text != "") {
                if (Tbx_op.Text == "+")
                {
                    result = Convert.ToDouble(TBx_first.Text) + Convert.ToDouble(TBx_second.Text);
                    TBx_result.Text = result.ToString();
                }
                else if (Tbx_op.Text == "-")
                {
                    result = Convert.ToDouble(TBx_first.Text) - Convert.ToDouble(TBx_second.Text);
                    TBx_result.Text = result.ToString();
                }
                else if (Tbx_op.Text == "*")
                {
                    result = Convert.ToDouble(TBx_first.Text) * Convert.ToDouble(TBx_second.Text);
                    TBx_result.Text = result.ToString();
                }
                else if (Tbx_op.Text == "/")
                {
                    result = Convert.ToDouble(TBx_first.Text) / Convert.ToDouble(TBx_second.Text);
                    TBx_result.Text = result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Sie haben keinen Operator angegeben !");
            }
        }
    }
}
