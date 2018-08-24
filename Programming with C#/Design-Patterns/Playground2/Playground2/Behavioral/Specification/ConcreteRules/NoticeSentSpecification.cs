namespace Playground2.Behavioral.Specification.ConcreteRules
{
    using Playground2.Behavioral.Specification.BaseLogic;

    public class NoticeSentSpecification : ISpecification<Invoice>
    {
        public bool IsSatisfiedBy(Invoice entity)
        {
            return entity.NoticeSent;
        }
    }
}
