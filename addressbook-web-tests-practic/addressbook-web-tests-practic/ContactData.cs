using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookPracticTests
{
    public class ContactData
    {
        private string lastname;
        private string firstname;
        private string middlename;
        private string nickname;
        private string title;
        private string company;

        public ContactData(string lastname, string firstname, string middlename, string nickname, string title, string company)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.middlename = middlename;
            this.nickname = nickname;
            this.title = title;
            this.company = company;
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Middlename
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                middlename = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
    }
}









