﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCustomerApp.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<RecepientMessage> RecepientMessages { get; set; }
        public ICollection<AdditionalInfo> AdditionalInfos { get; set; }

        public Phone()
        {
            RecepientMessages = new List<RecepientMessage>();
            AdditionalInfos = new List<AdditionalInfo>();
        }
    }
}