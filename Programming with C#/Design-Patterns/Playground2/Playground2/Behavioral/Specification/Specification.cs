namespace Playground2.Behavioral.Specification
{
    using Playground2.Behavioral.Specification.BaseLogic;
    using Playground2.Behavioral.Specification.ConcreteRules;
    using System;


    public static class Specification
    {
        public static void Run()
        {
            // composition root
            var invoiceService = new InvoiceService();

            var overDue = new OverDueSpecification();
            var noticeSent = new NoticeSentSpecification();
            var inCollection = new SentForCollectionSpecification(invoiceService);
            // end of composition root, usually is made with container

            // Example of specification pattern logic chaining
            var sendToCollection = 
                overDue
                .And(noticeSent)
                .And(inCollection.Not());

            foreach (var invoice in invoiceService.GetAllInvoices())
            {
                if (sendToCollection.IsSatisfiedBy(invoice))
                {
                    invoiceService.SendForCollection(invoice);
                }
            }

            Console.WriteLine(new string('-', 60));

            var sendNotice = overDue.And(noticeSent.Not()).And(inCollection.Not());
            foreach (var invoice in invoiceService.GetAllInvoices())
            {
                if (sendNotice.IsSatisfiedBy(invoice))
                {
                    invoiceService.SendNotice(invoice);
                }
            }
        }
    }
}
