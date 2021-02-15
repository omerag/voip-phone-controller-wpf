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

        public string Position { get; private set; }

        public string Email { get; private set; }

        public string Comment { get; private set; }

        public ContactModel(string name, string callNumber, string company, string position, string email, string comment)
        {
            Name = name;
            CallNumber = callNumber;
            Company = company;
            Position = position;
            Email = email;
            Comment = comment;
        }
    }
}
