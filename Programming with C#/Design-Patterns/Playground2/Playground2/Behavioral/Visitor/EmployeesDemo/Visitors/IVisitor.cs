namespace Playground2.Behavioral.Visitor.EmployeesDemo.Employees
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Employee element);
    }
}
