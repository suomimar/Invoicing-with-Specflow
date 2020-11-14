namespace Invoicing.Interfaces
{
    public interface IInvoiceRow
    {
        string Description { get; }
        decimal Amount { get; }
    }
}