using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    /// <summary>
    /// To hold first name, middle name and last name
    /// </summary>
    public class Name : BindableBase
    {
        private string firstName;
        private string lastName;
        private string middleName;

        public string FirstName
        {
            get 
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }
    }
}
