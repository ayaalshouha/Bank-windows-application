using System.Data;
using BankDataLayer;

namespace BankBuisnessLayer
{
    public class clsCurrencies
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public decimal Rate { get; set; }
        public string Name { get; set; }

        private enum enMode { AddNew=0, Update};
        private enMode Mode { get; set; } 

        public clsCurrencies()
        {
            this.ID = -1;
            this.Country = "";
            this.Code = "";
            this.Name = "";
            this.Rate = 0;
            Mode = enMode.AddNew; 
        }
        
        private clsCurrencies(stCurrencies Currency)
        {
            this.ID = Currency.ID;
            this.Country = Currency.Country;
            this.Code = Currency.Code;
            this.Name = Currency.Name;
            this.Rate = Currency.Rate;
            Mode = enMode.Update; 
        }

        public static clsCurrencies FindByCode(string CurrencyCode)
        {
            stCurrencies Currency = new stCurrencies();

            if (clsCurrenciesData.GetCurrencyInfo_Code(CurrencyCode, ref Currency))
            {
                return new clsCurrencies(Currency);
            }
            return null;
        }

        public static clsCurrencies FindByCountry(string Country)
        {
            stCurrencies Currency = new stCurrencies();

            if (clsCurrenciesData.GetCurrencyInfo_Country(Country, ref Currency))
            {
                return new clsCurrencies(Currency);
            }
            return null;
        }

        public static DataTable GetAllCurrencies()
        {
            return clsCurrenciesData.GetAllCurrencies();
        }

        public bool UpdateRate(decimal NewRate)
        {
            return clsCurrenciesData.UpdateRate(this.ID, NewRate); 
        }

    }
}
