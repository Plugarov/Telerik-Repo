namespace InheritanceAndPolymorphism.Interfaces
{       
    using System;

    interface IOffsiteCourse : ICourse
    {
        string Town { get; set; };
    }
}
