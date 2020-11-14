using System.Collections.Generic;

namespace Invoicing.Interfaces
{
    public interface IInvoice
    {
        string Number { get; }
        decimal Amount { get; }
        IEnumerable<IInvoiceRow> InvoiceRows { get; }
    }
}