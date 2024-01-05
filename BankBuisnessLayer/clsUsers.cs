using BankDataLayer;
using System.Data;

namespace BankBuisnessLayer
{
    public class clsUsers
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string password { get; set; }
        public int permissions { get; set; }
        private enum enMode { AddNew = 0, Update };
        private enMode _Mode { get; set; }
        public enum enPermissions : int
        {
            pAll = -1, pDeleteClient = 1, pUsersList = 2, pAddUser = 4, pUpdateUser = 8,
            pDeleteUser = 16, pFindUser = 32
        };

        public clsUsers()
        {
            this.ID = -1;
            this.username = "";
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
            this.Email = "";
            this.password = "";
            this.permissions = 0;
            _Mode = enMode.AddNew;
        }

        private clsUsers(stUsers User)
        {
            this.ID = User.ID;
            this.username = User.username;
            this.password = User.password;
            this.permissions = User.permissions;
            this.FirstName = User.FirstName;
            this.LastName = User.LastName;
            this.Email = User.Email;
            this.Phone = User.PhoneNumber;
            _Mode = enMode.Update;
        }

        public static clsUsers Find(int ID)
        {
            stUsers User = new stUsers();

            if (clsUsersData.GetUserInfo(ID, ref User))
            {
                return new clsUsers(User);
            }
            return null;
        }

        public static clsUsers Find(string username)
        {
            stUsers User = new stUsers();

            if (clsUsersData.GetUserInfo(username, ref User))
            {
                return new clsUsers(User);
            }
            return null;
        }

        private bool _AddNewUser()
        {
            this.ID = clsUsersData.AddNew(this.FirstName, this.LastName, this.username,
             this.Email, this.Phone, this.password,this.permissions);

            return this.ID != -1;
        }

        private bool _UpdateUser()
        {
            return (clsUsersData.UpdateUser(this.ID, this.FirstName, this.LastName, this.username,
             this.Email, this.Phone, this.password, this.permissions));
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static bool Delete(int ID)
        {
            return clsUsersData.DeleteUser(ID);
        }

        public static bool Delete(string username)
        {
            return clsUsersData.DeleteUser(username);
        }

        public static bool isExist(int ID)
        {
            return clsUsersData.isUserExist(ID);
        }

        public static bool isExist(string username)
        {
            return clsUsersData.isUserExist(username);
        }

        public static clsUsers Authintication(string username, string Password)
        {
            stUsers User = new stUsers();  
            
            if (DataSettings.LoginAuthintication(username, Password, ref User))
            {
                return new clsUsers(User); 
            }
            return null; 
        }

        
        public static DataTable UsersList()
        {
            return clsUsersData.UsersList();
        }

       public bool isAccessAllowed(enPermissions permission)
       {
            if (this.permissions == (int)enPermissions.pAll)
            {
                return true; 
            }
            if(((int)permission & this.permissions) == (int)permission)
            {
                return true; 
            }

            return false;
       }

    }
}
