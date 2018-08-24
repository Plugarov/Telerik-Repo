namespace Academy.Tests.Commands.Mock
{
    using Academy.Commands.Adding;
    using Academy.Core.Contracts;

    internal class AddStudentToSeasonCommandMock : AddStudentToSeasonCommand
    {
        internal AddStudentToSeasonCommandMock(IAcademyFactory factory, IEngine engine) 
            : base(factory, engine)
        {
        }

        public IEngine Engine
        {
            get
            {
                return this.engine;
            }
        }

        public IAcademyFactory AcademyFactory
        {
            get
            {
                return this.factory;
            }
        }
    }
}
