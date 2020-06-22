using Crepixa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crepixa.ViewModels
{
    public class SendVM
    {
        public string Message { get; set; }

        public List<SubscriberItem> subscribers { get; set; }

    }
}
