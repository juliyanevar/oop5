using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    public partial class Form1 : Form
    {
        int numbOfObj;
        public Form1()
        {
            InitializeComponent();
        }

        bool validate;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            validate = true;
            //textBox6.Text = "";
            int number = 0;
            if (textBox1.Text == "")
            {
                validate = false;
                errorProvider1.SetError(textBox1, "No number\n");
            }
            else
            {
                number = int.Parse(textBox1.Text);
                errorProvider1.Clear();
            }

            string type = "";

            if (comboBox1.Text == "")
            {
                validate = false;
                errorProvider1.SetError(comboBox1, "No type\n");
            }
            else
            {
                type = comboBox1.Text;
                errorProvider1.Clear();
            }

            int balance = trackBar1.Value;
            string date = maskedTextBox1.Text;
            string sms = "";
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                validate = false;
                errorProvider1.SetError(groupBox1, "No sms\n");
            }
            else
            {
                if (radioButton1.Checked)
                    sms = "yes";
                else
                    sms = "no";
                errorProvider1.Clear();
            }
            

            string banking = "";
            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                validate = false;
                errorProvider1.SetError(groupBox2, "No banking\n");
            }
            else
            {
                if (radioButton4.Checked)
                    banking = "yes";
                else
                    banking = "no";
                errorProvider1.Clear();
            }

            

            string fullName = "";
            if (textBox2.Text == "")
            {
                validate = false;
                errorProvider1.SetError(textBox2, "No name\n");
            }
            else
            {
                fullName = textBox2.Text;
                errorProvider1.Clear();
            }
            string bday = "";
            if (dateTimePicker1.Value.ToShortDateString() == "")
            {
                validate = false;
                errorProvider1.SetError(dateTimePicker1, "No date\n");
            }
            else
            {
                bday = dateTimePicker1.Value.ToShortDateString();
                errorProvider1.Clear();
            }
            string passport = "";
            if (maskedTextBox2.Text == "")
            {
                validate = false;
                errorProvider1.SetError(maskedTextBox2, "No name\n");
            }
            else
            {
                passport = maskedTextBox2.Text;
                errorProvider1.Clear();
            }

            if (validate)
            {
                Serializer serializer = new Serializer();
                serializer.WriteFile(new BankAccount(number, type, balance, date, sms, banking, new Owner(fullName, bday, passport)));
                //ViewBankAccount();

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate = true;
            //textBox6.Text = "";
            int number = 0;
            if (textBox1.Text == "")
            {
                validate = false;
                errorProvider1.SetError(textBox1, "No number\n");
            }
            else
            {
                number = int.Parse(textBox1.Text);
                errorProvider1.Clear();
            }

            string type = "";

            if (comboBox1.Text == "")
            {
                validate = false;
                errorProvider1.SetError(comboBox1, "No type\n");
            }
            else
            {
                type = comboBox1.Text;
                errorProvider1.Clear();
            }

            int balance = trackBar1.Value;
            string date = maskedTextBox1.Text;
            string sms = "";
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                validate = false;
                errorProvider1.SetError(groupBox1, "No sms\n");
            }
            else
            {
                if (radioButton1.Checked)
                    sms = "yes";
                else
                    sms = "no";
                errorProvider1.Clear();
            }


            string banking = "";
            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                validate = false;
                errorProvider1.SetError(groupBox2, "No banking\n");
            }
            else
            {
                if (radioButton4.Checked)
                    banking = "yes";
                else
                    banking = "no";
                errorProvider1.Clear();
            }



            string fullName = "";
            if (textBox2.Text == "")
            {
                validate = false;
                errorProvider1.SetError(textBox2, "No name\n");
            }
            else
            {
                fullName = textBox2.Text;
                errorProvider1.Clear();
            }
            string bday = dateTimePicker1.Value.ToShortDateString();
            string passport = "";
            if (maskedTextBox2.Text == "")
            {
                validate = false;
                errorProvider1.SetError(maskedTextBox2, "No passport\n");
            }
            else
            {
                passport = maskedTextBox2.Text;
                errorProvider1.Clear();
            }
            if (validate)
            {
                textBox6.Text = "Number: " + number + Environment.NewLine +
                       "Type: " + type + Environment.NewLine +
                       "Balance: " + balance + Environment.NewLine +
                       "Opening date: " + date + Environment.NewLine +
                       "Owner name: " + fullName + Environment.NewLine +
                       "Owner bday: " + bday + Environment.NewLine +
                       "Owner passport: " + passport + Environment.NewLine +
                       "SMS: " + sms + Environment.NewLine +
                       "Internet banking: " + banking + Environment.NewLine + Environment.NewLine;
            }
        }
        //private void ViewBankAccount()
        //{
        //    Serializer serializer = new Serializer();
        //    textBox6.Text = "";
        //    var list = serializer.ReadFile();
        //    foreach (BankAccount discipline in list)
        //    {
        //        textBox6.Text += discipline.ToString() + '\n';
        //    }
        //    numbOfObj = list.Count;
        //}

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = String.Format("Баланс: {0}", trackBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            textBox6.Text = "";
            var list = serializer.ReadFile();
            foreach (BankAccount discipline in list)
            {
                textBox6.Text += discipline.ToString() + '\n';
            }
            numbOfObj = list.Count;
        }
    }
}
