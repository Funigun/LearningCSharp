using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemoLibrary.Models
{
    internal class User
    {
        internal string Name { get; set; }

        internal CreditCard CreditCard { get; set; }

        internal User()
        {
            Name = "Test";
            CreditCard = new CreditCard();
        }
    }
}
