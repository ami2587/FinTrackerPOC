using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{


    public class FixedDeposit : BusinessObjectBase
    {
        //Amount, rate of interest per annum, lock in time period, compounded annually or what, charges if broken

        #region Private Fields

        Name nameOfDepositHolder;
        DateTime startDate;
        Money amountDeposited;

        #endregion

        public FixedDeposit(Project parent)
            : base(parent)
        {
            //Set the default values for a fixed deposir here
        }

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public Name NameOfDepositHolder
        {
            get
            {
                return nameOfDepositHolder;
            }
            set 
            {
                nameOfDepositHolder = value;
                OnPropertyChanged("NameOfDepositHolder");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        public Money AmountDeposited
        {
            get 
            {
                return amountDeposited;
            }
            set 
            {
                amountDeposited = value;
                OnPropertyChanged("AmountDeposited");
            }
        }

        #endregion
    }
}
