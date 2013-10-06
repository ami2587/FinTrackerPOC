using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    enum CurrencyCode
    {
        INR,
        USD
    }
    /// <summary>
    /// 
    /// </summary>
    public class Money : BindableBase
    {
        private decimal value;
        private CurrencyCode currency;

        public decimal Value
        {
            get 
            {
                return value;
            }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }

        public CurrencyCode Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
                OnPropertyChanged("Currency");
            }
        }
    }
}
