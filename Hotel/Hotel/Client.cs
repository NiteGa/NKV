using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Client
    {
        private string idClient;
        public String firstName;
        private String lastName;
        private string phoneNumber;

        public string ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }
        public string Information
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
        public Client()
        {
            this.idClient = "";
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = "";
        }
        public Client(string idClient, String name, String prename, string  phone)
        {
            this.idClient = idClient;
            this.firstName = name;
            this.lastName = prename;
            this.phoneNumber = phone;
        }
       
    }
}
