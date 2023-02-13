using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows;
using System.IO;

namespace InvoicesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class InvoiceData
        {
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
            public string ExpenseType { get; set; }

            public InvoiceData(decimal amount, DateTime date, string expenseType)
            {
                this.Amount = amount;
                this.Date = date;
                this.ExpenseType = expenseType;
            }

            ~InvoiceData() { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    List<InvoiceData> invDataList = new List<InvoiceData>();
                    HashSet<DateTime> distinctDates = new HashSet<DateTime>();

                    string temp = reader.ReadLine();
                    decimal totalAmount = 0;
                    string[] tempSpl = temp.Split(';');
                    string lineText;
                    string[] arr = new string[3];
                    string wholeText = "";

                    while (!reader.EndOfStream)
                    {
                        lineText = reader.ReadLine();
                        arr = lineText.Split(';');
                        decimal deck = Convert.ToDecimal(arr[0], CultureInfo.InvariantCulture);

                        invDataList.Add(new InvoiceData(deck, DateTime.Parse(arr[1]), arr[2]));
                        distinctDates.Add(DateTime.Parse(arr[1]));
                    }

                    wholeText += tempSpl[0] + "\t" + tempSpl[1] + "\t\t" + tempSpl[2] + "\n";

                    foreach (InvoiceData item in invDataList)
                    {
                        totalAmount += item.Amount;
                        wholeText += "\t\t" + item.Amount.ToString() + "\t" + item.Date.ToString("yyyy-MM-dd") + "\t" + item.ExpenseType + "\n";
                    }

                    textBox2.Text = wholeText;
                    textBox3.Text = "Total expenses: " + totalAmount.ToString() + "\t\n" + "Distinct dates of payment: " + distinctDates.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("File doesn't exist!!!", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
