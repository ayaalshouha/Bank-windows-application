using System.Data;
using BankDataLayer; 

namespace BankBuisnessLayer
{
    public class clsClients
    {
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PinCode { get; set; }
        public decimal Balance { get; set; }
        private enum enMode { AddNew = 0, Update };
        private enMode Mode { get; set; }

        public clsClients()
        {
            Mode = enMode.AddNew;
            this.ID = -1;
            this.AccountNumber = "";
            this.FirstName = "";
            this.LastName = "";
            this.Balance = 0;
            this.PinCode = 0;
            this.Email = "";
            this.Phone = "";
        }

        private clsClients(stClient Client)
        {
            this.ID = Client.ID; 
            this.AccountNumber = Client.AccountNumber;
            this.FirstName = Client.FirstName;  
            this.LastName = Client.LastName;    
            this.Balance = Client.Balance;
            this.Email=Client.Email;
            this.Phone = Client.PhoneNumber;
            this.PinCode = Client.PINCode;
            Mode = enMode.Update; 
        }

        public static clsClients Find(int ID)
        {
            stClient Client = new stClient();

            if(clsClientsData.GetClientInfo(ID, ref Client))
            {
                return new clsClients(Client); 
            }
            return null; 
        }

        public static clsClients Find(string accountnumber)
        {
            stClient Client = new stClient();

            if (clsClientsData.GetClientInfo(accountnumber, ref Client))
            {
                return new clsClients(Client);
            }
            return null;
        }

        private bool _AddNewClient()
        {
            this.ID = clsClientsData.AddNew(this.FirstName, this.LastName, this.AccountNumber,
                  this.Email, this.Phone, this.Balance, this.PinCode);

            return this.ID != -1; 
        }

        private bool _UpdateClient()
        {
            return (clsClientsData.UpdateClient(this.ID, this.FirstName, this.LastName, this.AccountNumber,
                this.Email, this.Phone, this.Balance, this.PinCode)); 
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                 
                case enMode.Update:
                    return _UpdateClient();
            }
            return false; 
        }

        public bool Deposite(decimal DepositeAmount)
        {
            if(DepositeAmount >= 0)
            {
                this.Balance += DepositeAmount;
                this.Save();
                return true;
            }

            return false; 
        }

        public bool Withdraw(decimal WithdrawAmount)
        {
            if(WithdrawAmount > this.Balance)
            {
                return false;
            }

            this.Balance = (WithdrawAmount < 0) ? this.Balance + WithdrawAmount : this.Balance - WithdrawAmount;
            this.Save();
            return true; 
        }

        public bool Transfer(clsClients Client2, decimal TransferedeAmount)
        {
            if (this.Withdraw(TransferedeAmount) && Client2.Deposite(TransferedeAmount))
                return true;
            else
                return false; 
        }

        public static bool Delete(int ID)
        {
            return clsClientsData.DeleteClient(ID);
        }

        public static bool Delete(string AccountNumber) {
            return clsClientsData.DeleteClient(AccountNumber);
        }

        public static bool isExist(int ID)
        {
            return clsClientsData.isClientExist(ID);
        }

        public static bool isExist(string AccountNumber)
        {
            return clsClientsData.isClientExist(AccountNumber);
        }

        public static DataTable ClientsList()
        {
            return clsClientsData.ClientsList();
        }
    }
}
