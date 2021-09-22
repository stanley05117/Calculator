using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result;

                string expr = string.Format(txtInput.Text);
                result = new DataTable().Compute(expr, "").ToString();

                MessageBox.Show(result,"Answer");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }

}
