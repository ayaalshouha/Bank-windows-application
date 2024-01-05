using BankDataLayer;

namespace BankBuisnessLayer
{
    public static class clsRecords
    {
        public static bool SaveLoginRecord(int UserID)
        {
            return clsLoginRecords.SaveLoginRecord(UserID);
        }

    }
}
