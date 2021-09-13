using Air3550.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    //This class is used for when any user logs in or logs out
    class CustomerSession
    {
        //nullable int and accountlevel
        public static int? CUSTOMER_ID;
        public static AccountLevel? ACCOUNT_LEVEL;

        //set valid id's
        public static void Login(int customerID, AccountLevel accountLevel)
        {
            CUSTOMER_ID = customerID;
            ACCOUNT_LEVEL = accountLevel;
        }
        //reset id's
        public static void logout()
        {
            CUSTOMER_ID = null;
            ACCOUNT_LEVEL = null;
        }
    }
}
