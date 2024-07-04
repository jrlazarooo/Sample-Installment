using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Installment
{
    public partial class frmMotor : Form
    {
        double ADVinstall = 274840.00;
        double PCXinstall = 250400.00;
        double CLICKinstall = 153800.00;

        double ADVcash = 168800.00;
        double PCXcash = 151800.00;
        double CLICKcash = 82800.00;
        
        double insurance = 4500.00;
        double registraton = 3100.00;
        
        int months = 36;
        
        double total = 0.0;
        double credit = 0.0;
 
        double taxDeduction = 0.0;
        double taxTotal = 0.0;
        double tax1 = 0.03, tax2 = 0.11;

        public frmMotor()
        {
            InitializeComponent();

            ComboBox cBox = new ComboBox();

            cboModel.Items.Add("ADV");
            cboModel.Items.Add("PCX");
            cboModel.Items.Add("CLICK");
            Controls.Add(cboModel);

            cboModel.SelectedIndexChanged += cboModel_SelectedIndexChanged;

        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModel.SelectedIndex >= 0)
            {
                string selectedText = cboModel.SelectedItem.ToString();
                {
                    switch (selectedText) 
                    {
                        case "ADV":
                            txtCash.Text = ADVcash.ToString();
                            break;

                        case "PCX":
                            txtCash.Text = PCXcash.ToString();
                            break;

                        case "CLICK":
                            txtCash.Text = CLICKcash.ToString();
                            break;

                        default:
                            txtCash.Text = " ";
                            break;


                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkInstallment.Checked == false)
            {
                txtMonthly.Text = "Fully Paid";
                txtInsurance.Text = insurance.ToString();
                txtRegistration.Text = registraton.ToString();

                double taxDeduction = double.Parse(txtCash.Text) * tax1;
                txtTax.Text = taxDeduction.ToString();
            }

            else
            {
                string selectedText = cboModel.SelectedItem.ToString();

                switch (selectedText) 
                {
                    case "ADV":
                        taxDeduction = ADVinstall * tax2;
                        taxTotal = ADVinstall + taxDeduction;

                        txtMonthly.Text = (((taxTotal - Double.Parse(txtCredit.Text)) / months).ToString());

                        txtInsurance.Text = insurance.ToString();
                        txtRegistration.Text = registraton.ToString();
                        txtTax.Text = taxDeduction.ToString();
                        break;

                    case "PCX":

                        taxDeduction = PCXinstall * tax2;
                        taxTotal = PCXinstall + taxDeduction;

                        txtMonthly.Text = (((taxTotal - Double.Parse(txtCredit.Text)) / months).ToString());

                        txtInsurance.Text = insurance.ToString();
                        txtRegistration.Text = registraton.ToString();
                        txtTax.Text = taxDeduction.ToString();
                        break;

                    case "CLICK":

                        taxDeduction = CLICKinstall * tax2;
                        taxTotal = CLICKinstall + taxDeduction;

                        txtMonthly.Text = (((taxTotal - Double.Parse(txtCredit.Text)) / months).ToString());

                        txtInsurance.Text = insurance.ToString();
                        txtRegistration.Text = registraton.ToString();
                        txtTax.Text = taxDeduction.ToString();
                        break;
                }
            }
        }
        private void chkInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstallment.Checked) 
            {
                txtCredit.ReadOnly = false;
            }

            else 
            {
                txtCredit.ReadOnly = true;
            }
        }


    }
}
