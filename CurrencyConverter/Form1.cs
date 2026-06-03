using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            API_Currency apiCurrency = new API_Currency();

            apiCurrency.Import();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var nomi = new List<string> { "Luca", "Marco", "Giulia" };
            Currency_list.DataSource = Currency_list.DataSource = Currencies_long_list.All;
            ;
            
        }
        public string GetSelectedCurrency()
        {
            return Currency_list?.Text ?? string.Empty;
        }
    }

}