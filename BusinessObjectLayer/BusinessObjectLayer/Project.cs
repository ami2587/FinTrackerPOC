using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    /// <summary>
    /// Represents a FinTracker project
    /// </summary>
    public class Project : BusinessObjectBase
    {
        #region Private Fields

        private User owner;
        private ObservableCollection<FixedDeposit> fixedDeposits;
        private ReadOnlyObservableCollection<FixedDeposit> readOnlyFixedDeposits;
        
        #endregion

        #region Consturctor

        /// <summary>
        /// Project is at the root and has no parent
        /// </summary>
        /// <param name="id"></param>
        public Project():
            base(null)
        {
 
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Owner of the Project
        /// </summary>
        public User Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
                OnPropertyChanged("Owner");
            }
        }

        /// <summary>
        /// Read only observable collection of fixed deposits, so it can be bound to but not modified
        /// </summary>
        public ReadOnlyObservableCollection<FixedDeposit> FixedDeposits
        {
            get
            {
                if (readOnlyFixedDeposits == null)
                {
                    readOnlyFixedDeposits = new ReadOnlyObservableCollection<FixedDeposit>(fixedDeposits);
                }
                return readOnlyFixedDeposits;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Add a new fixed deposit with default values
        /// </summary>
        /// <returns></returns>
        FixedDeposit AddFixedDeposit()
        {
            FixedDeposit newFixedDeposit = new FixedDeposit(this);
            fixedDeposits.Add(newFixedDeposit);
            return newFixedDeposit;
        }

        #endregion
    }
}
