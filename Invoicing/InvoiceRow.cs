using System;
using Invoicing.Interfaces;

namespace Invoicing
{
    public class InvoiceRow : IInvoiceRow
    {
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
    }
}
