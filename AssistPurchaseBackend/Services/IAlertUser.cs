using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssistPurchaseBackend.Services
{
    interface IAlertUser
    {
        string  UserName { get; set; }
        string UserMailId { get; set; }
        string  Product { get; set; }
    }
}
