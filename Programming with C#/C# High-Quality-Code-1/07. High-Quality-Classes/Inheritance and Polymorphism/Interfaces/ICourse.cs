namespace InheritanceAndPolymorphism
{       
    using System;

    interface ICourse
    {
        string CourseName { get; set; };
        
        string TeachertName { get; set; };
        
        IList<string> Students { get; set; };
        
        void Add(string student);
        
        string ToString();
    }
}
