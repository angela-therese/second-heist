using System;
using System.Collections.Generic;

namespace Heist
{
    public class Bank

    {
        public int CashOnHand {get; set;}
        public int AlarmScore {get; set;}
        public int VaultScore  {get; set;}

        public int SecurityGuardScore {get; set;}

        public bool IsSecure() 
        {
            if(CashOnHand + AlarmScore + VaultScore + SecurityGuardScore <= 0){
                return false;
                
            }
            else{
                return true;
            }
        }
    }

   
}