using _03_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    public abstract class Person : IPerson
    {

        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    
        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if(!Regex.IsMatch(value, @"^[\d]{5}$"))
                {
                    throw new ArgumentException("The ID should be 5 digits long");
                }
                this.id = value;
            }

        }

        public string FirstName
        { 
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The First name cannot be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName 
        { 
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The Last name cannot be empty");
                }
                this.lastName = value;
            } 
        }

        public override string ToString()
        {
            return string.Format("ID: {0} - First Name: {1}, Last Name: {2}",this.ID, this.FirstName, this.LastName);
        }

    }
}
