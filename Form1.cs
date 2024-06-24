using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            this.CancelButton = btnthoat;
        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Text = txtnhapten.Text;
            LBLLaptrinh.Text = txtnhapten.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton r=(RadioButton)sender; 
            switch (r.Name)
            {
                case "radRed":
                    LBLLaptrinh.ForeColor = Color.Red;
                    txtnhapten.ForeColor = Color.Red;
                    txtnhapten.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    LBLLaptrinh.ForeColor = Color.Green;
                    txtnhapten.ForeColor = Color.Green;
                    txtnhapten.ForeColor = Color.Green;
                    break;
                case "radBlue":
                LBLLaptrinh.ForeColor = Color.Blue;
                txtnhapten.ForeColor = Color.Blue;
                    txtnhapten.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    LBLLaptrinh.ForeColor = Color.Black;
                    txtnhapten.ForeColor = Color.Black;
                    txtnhapten.ForeColor = Color.Black;
                    break;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r = (CheckBox)sender;
            switch (r.Name)
            {
                case "chkBod":
                    LBLLaptrinh.Font=new Font(LBLLaptrinh.Font.Name,LBLLaptrinh.Font.Size,LBLLaptrinh.Font.Style^FontStyle.Bold);
                    break;
                case "chknghiengitalic":
                    LBLLaptrinh.Font = new Font(LBLLaptrinh.Font.Name, LBLLaptrinh.Font.Size, LBLLaptrinh.Font.Style ^ FontStyle.Bold);
                    break;
                case "chkgachchan":
                    LBLLaptrinh.Font = new Font(LBLLaptrinh.Font.Name, LBLLaptrinh.Font.Size, LBLLaptrinh.Font.Style ^ FontStyle.Bold);
                    break;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        }
    

