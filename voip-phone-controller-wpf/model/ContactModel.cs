using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.model
{
    class ContactModel
    {
        public string Name { get; private set; }
        public string CallNumber { get; private set; }
        public string Company { get; private set; }
        public string Role { get; private set; }

        public ContactModel(string name, string callNumber, string company, string role)
        {
            this.Name = name;
            this.CallNumber = callNumber;
            this.Company = company;
            this.Role = role;
        }
    }
}
