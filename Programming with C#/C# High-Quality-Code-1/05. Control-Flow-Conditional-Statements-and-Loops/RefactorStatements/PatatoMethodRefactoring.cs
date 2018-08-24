//Task 2. Refactor the following if statements
//Potato potato;
////... 
//if (potato != null)
//   if(!potato.HasNotBeenPeeled && !potato.IsRotten)
//    Cook(potato);
//and

//if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
//{
//   VisitCell();
//}

using System;

public class PatatoMethodRefactoring
{
    public void Patato()
    {
        if (potato != null && potato.isPeeled && !potato.IsRotten)
        {
            Cook(potato);
        }
    }
    public void MinMax()
    {
        if (x >= MIN_X &&
            (x <= MAX_X &&
            ((MAX_Y >= y && MIN_Y <= y) && ShouldVisitCell)))
        {
            VisitCell();
        }
    }
}
