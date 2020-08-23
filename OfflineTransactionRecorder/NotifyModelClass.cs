using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class NotifyModelClass
    {
        private string accNo;
        private string creditDebitStatus;
        private string amount;
        private string date;
        private string info;
        private string avlBal;
        public string AccNo
        {
            get
            {
                return this.accNo;
            }
            set
            {
                this.accNo = value;
            }
        }

        public string CreditDebitStatus
        {
            get
            {
                return this.creditDebitStatus;
            }
            set
            {
                this.creditDebitStatus = value;
            }
        }

        public string Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Info
        {
            get
            {
                return this.info;
            }
            set
            {
                this.info = value;
            }
        }

        public string AvlBal
        {
            get
            {
                return this.avlBal;
            }
            set
            {
                this.avlBal = value;
            }
        }
    }
}
