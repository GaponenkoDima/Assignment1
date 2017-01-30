///Autor: Dmytro Gaponenko
///Date: 29-01-2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class SalesBonus : Form
    {
        public SalesBonus()
        {
            InitializeComponent();
        }

        private void empIdlabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method determine the Sales Bonus earned by the employee.
        /// The result displayed in the Sales Bonus Text Field.
        /// </summary>
        private void CalculateMethod()
        {
            //converting String to Double
            double hours = Convert.ToDouble(HoursWorkedTextBox.Text);
            //if stataement to validate that accurate work hours was entered.
            if (hours < 1 || hours > 160)
            {
                //Message to inform that ivalid data has been entered.
                MessageBox.Show("Invalid Data Entered", "Input Error");

                HoursWorkedTextBox.Text = "";
            }
            //converting String to Double
            double TotalSales = Convert.ToDouble(TotalMonthlySalexTextBox.Text);
            if (TotalSales < 0)
            {
                //Validate the input.
                MessageBox.Show("Total Sales Cannot Be Less Then 1");
                TotalMonthlySalexTextBox.Text = "";
            }
            //actual calculation function of Calculate method.
            double SalesBonus = (hours / 160) * (TotalSales * 0.02);
            SalesBonusTextBox.Text = SalesBonus.ToString("C2");

        }

        /// <summary>
        /// This method uses CalculateMethod() created above and outupts required information regarding Sales Bonus.
        /// It also checks wich language are you currently use and responses with the same language.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            {
                string EmployeeName;
                double EmployeeID;
                double HoursWorked;

                CalculateMethod();
                //Validate if the Employee Name has been enterd.
                if (EmployeeNameTextBox.Text == "")
                {
                    //Error message
                    MessageBox.Show("Please Fill The Name!");
                    EmployeeNameTextBox.Text = "";
                }
                //Convert this field toString to display them using MessageBox.
                EmployeeName = Convert.ToString(EmployeeNameTextBox.Text);
                EmployeeID = Convert.ToDouble(EmployeeIDTextBox.Text);
                HoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);
                //Display MessageBox with the same language as program running.
                if (CalculateButton.Text == "Calculate")
                {
                    MessageBox.Show(EmployeeName + " earned " + SalesBonusTextBox.Text + " of bonus.");
                }
                else if (CalculateButton.Text == "Calculer") {
                    MessageBox.Show(EmployeeName + " gagné " + SalesBonusTextBox.Text + " de bonus.");
                }
                else if (CalculateButton.Text == "Calcular")
                {
                    MessageBox.Show(EmployeeName + " ganado " + SalesBonusTextBox.Text + " de bonificación.");
                }
            }

        }
        /// <summary>
        /// Set focus on Employee Name Text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Focus();
        }
        /// <summary>
        /// Set focus on Employee Id text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeNameIDBox_TextChanged(object sender, EventArgs e)
        {
            EmployeeIDTextBox.Focus();
        }
        /// <summary>
        /// This method sanitize the input to ensure that only numbers has been entered./
        /// Code retrived from:
        /// http://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalMonthlySalexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            HoursWorkedTextBox.Text = "";
            TotalMonthlySalexTextBox.Text = "";
            SalesBonusTextBox.Text = "";
        }

        

        /// <summary>
        /// This is the print method.
        /// It also checks wich language are you currently use and responses with the same language.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (PrintButton.Text == "Print")
            {
                MessageBox.Show("The form has been sent to the printer.");
            }
            else if (PrintButton.Text == "Imprimer")
            {
                MessageBox.Show("Le formulaire a été envoyé à l'imprimante.");
            }
            else if (PrintButton.Text == "Impresión")
            {
                MessageBox.Show("El formulario se ha enviado a la impresora.");
            }
            
        }
        /// <summary>
        /// This method stores English language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "English";
            radioButton2.Text = "French";
            radioButton3.Text = "Spanish";
            empNameLabel.Text = "Employee Name";
            empIdlabel.Text = "Employee ID";
            hrsWorkedlabel.Text = "Hours Worked";
            totalSalesLabel.Text = "Total Sales";
            slsBonusLabel.Text = "Sales Bonus";
            label1.Text = "Language";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            ClearButton.Text = "Clear";
            NextButton.Text = "Next";
        }
        /// <summary>
        /// This method stores French language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "Anglais";
            radioButton2.Text = "Français";
            radioButton3.Text = "Espanol";
            empNameLabel.Text = "Nom de l'employé";
            empIdlabel.Text = "ID employé";
            hrsWorkedlabel.Text = "Heures travaillées";
            totalSalesLabel.Text = "Ventes totales";
            slsBonusLabel.Text = "Bonus de vente";
            label1.Text = "La langue";
            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Imprimer";
            ClearButton.Text = "Clair";
            NextButton.Text = "Prochain";
        }

        /// <summary>
        /// This method stores Spanish language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1.Text = "Inglés";
            radioButton2.Text = "Francés";
            radioButton3.Text = "Español";
            empNameLabel.Text = "Nombre de empleado";
            empIdlabel.Text = "ID de empleado";
            hrsWorkedlabel.Text = "Horas trabajadas";
            totalSalesLabel.Text = "Ventas totales";
            slsBonusLabel.Text = "Bono de ventas";
            label1.Text = "Idioma";
            CalculateButton.Text = "Calcular";
            PrintButton.Text = "Impresión";
            ClearButton.Text = "Claro";
            NextButton.Text = "Siguiente";
        }

        /// <summary>
        /// The Next button will clear the Text Property for the Employee Name, Employee ID, 
        /// Total Hours Worked, and Sales Bonus fields. The amount of Total Monthly Sales stays at the place.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            HoursWorkedTextBox.Text = ""; 
            SalesBonusTextBox.Text = "";
        }
        /// <summary>
        /// This method sanitize the input to ensure that only numbers has been entered./
        /// Code retrived from:
        /// http://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoursWorkedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

