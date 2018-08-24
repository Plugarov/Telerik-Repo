namespace Academy.Tests.Commands.Adding.AddStudentToSeasonCommandTests
{
    using Academy.Core.Contracts;
    using Academy.Models;
    using Academy.Models.Contracts;
    using Academy.Tests.Commands.Mock;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    class Execute_Should
    {
        [Test]
        public void  ThrowArgumentException_WhenThePassedStudentIsAlreadyAPartOfThatSeason()
        {

        }
    }
}
