namespace Playground2.Behavioral.Specification
{
    using System.Collections.Generic;

    public interface IInvoiceService
    {
        IEnumerable<Invoice> GetAllInvoices();

        void SendForCollection(Invoice invoice);

        void SendNotice(Invoice invoice);

        bool IsSentForCollection(Invoice invoice);
    }
}
