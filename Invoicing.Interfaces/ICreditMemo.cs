using System;
using System.Collections.Generic;

namespace Invoicing.Interfaces
{
    public interface ICreditMemo
    {
        string Number { get; }
        decimal Amount { get; }
        IEnumerable<IInvoiceRow> InvoiceRows { get; }
    }
}
