using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    /// <summary>
    /// Represents a FinTracker user
    /// </summary>
    public class User : BusinessObjectBase
    {
        #region Private Fields

        private string firstName;
        private string lastName;
        
        #endregion

        #region Consturctor

        /// <summary>
        /// User is not a part of the business objects tree i.e. has no parent child relationship with any other business object
        /// </summary>
        /// <param name="id"></param>
        public User():
            base(null)
        {
 
        }

        #endregion

        #region Public Properties
        
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

        #endregion
    }
}
