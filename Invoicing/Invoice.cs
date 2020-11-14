using System;
using System.Collections.Generic;
using Invoicing.Interfaces;

namespace Invoicing
{
    public class Invoice : IInvoice
    {
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public IEnumerable<IInvoiceRow> InvoiceRows { get; set; }

        
    }
}
