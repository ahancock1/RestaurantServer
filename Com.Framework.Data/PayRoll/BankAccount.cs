﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Com.Framework.Data.PayRoll
{
    [DataContract]
    public class BankAccount
    {
        [DataMember]
        public int BankAccountID { get; set; }


    }
}
