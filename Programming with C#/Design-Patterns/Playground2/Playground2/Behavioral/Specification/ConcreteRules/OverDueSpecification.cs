namespace Playground2.Behavioral.Specification.ConcreteRules
{
    using System;

    using Playground2.Behavioral.Specification.BaseLogic;

    public class OverDueSpecification : ISpecification<Invoice>
    {
        public bool IsSatisfiedBy(Invoice entity)
        {
            return entity.PayDeadline < DateTime.Now;
        }
    }
}
