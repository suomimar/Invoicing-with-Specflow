using System;
using System.Collections.Generic;
using System.Linq;
using Invoicing.Interfaces;

namespace Invoicing
{
    public class CreditMemo : ICreditMemo
    {
        public string Number { get; private set; }

        public decimal Amount
        {
            get
            {
                return InvoiceRows.Sum(row => row.Amount);
            }
        }

        public IEnumerable<IInvoiceRow> InvoiceRows { get; private set; }

        public CreditMemo()
        {
        }
    }
}
