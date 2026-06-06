using System.Collections.Generic;

namespace CurrencyConverter
{
    public class Convert_Currency
    {
        private readonly Form1 _form;
        private string Currency_Selected;
        private Dictionary<string, decimal> rates;
        public Convert_Currency(Form1 form)
        {
            _form = form;
   
            Currency_Selected = _form.GetSelectedCurrency();
        }

    }
}