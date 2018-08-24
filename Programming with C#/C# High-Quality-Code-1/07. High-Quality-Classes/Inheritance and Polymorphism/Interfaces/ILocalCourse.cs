namespace InheritanceAndPolymorphism.Interfaces
{       
    using System;

    interface ILocalCourse : ICourse
    {
        string Lab { get; set; };
    }
}
