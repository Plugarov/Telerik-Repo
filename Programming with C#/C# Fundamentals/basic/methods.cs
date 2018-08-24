

// - - - - - - - - - - - - - - - Methods - - - - - - - - - - - - - - - 
// 1.static 
// 2.parameters
// 3.types - separate shorts fit in int array but array of shorts doesnt fit in int array

// using System;
// class HiddenMessage
// {
        
//     static void Main()
//     { 
//         string level = "Two";

//         PrintName(level);
//         PrintLogo("One");
//         FromReadLine(Console.ReadLine());
//     }   
      
//     static void PrintName(string level)
//     {
//         Console.WriteLine("Telerik Academy {0}", level);
//     }

//     static void PrintLogo(string level)
//     {
//         Console.WriteLine("C# Advanced {0}",level);
//     }
      
//     static void FromReadLine(string str)
//     {
//         Console.WriteLine("C# Advanced {0}", str);
//     }
// }

// - - - - - - - - - - - - - - - Methods - - - - - - - - - - - - - - - 


// using System;
// class HiddenMessage
// {
        
//     static void Main()
//     { 
//          PrintSign(int.Parse(Console.ReadLine()));
//     }   
      
//     static void PrintSign(string x)
//     {
//         if (num > 5) 
//         {
//             Console.WriteLine("{0} is bigger than 5",num);
//         } 
//         else if (num < 5) 
//         {
//             Console.WriteLine("{0} is smaller than 5",num);
//         }
//         else {
//             Console.WriteLine("they are equal");
//         }
//     }
    
// }

// - - - - - - - - - - - - - - - Methods - - - - - - - - - - - - - - - 



// using System;
// class HiddenMessage
// {
        
//     static void Main()
//     { 
//         PrintSign(int.Parse(Console.ReadLine()));
//     }   
      
//     static void PrintSign(int x)
//     {
        
//         string[] monthNames = 
//         {
//             "Jan", "Feb", "Mar",
//             "Apr", "May", "Jun",
//             "Jul", "Aug", "Sep",
//             "Oct", "Nov", "Dec"
//         };

//         if (x > 0 || x < monthNames.Length) 
//         { 
//             Console.WriteLine(monthNames[x - 1]);
//         } 
//         else 
//         {
//             Console.WriteLine("Out of range");
//         }
//     }
    
// }

// - - - - - - - - - - - - - - - Methods - - - - - - - - - - - - - - - 
// optional parameter


// using System;
// class HiddenMessage
// {
        
//     static void Main()
//     { 
//         PrintSign(int.Parse(Console.ReadLine()));
//     }   
      
//     static void PrintSign(int to, int from = 5)
//     {
//         for (int i = from; i <= to; i++) {
//             Console.WriteLine(i);
//         }
//     }
    
// }

// - - - - - - - - - - - - - - - Methods - - - - - - - - - - - - - - - 
// optional parameter
// optional parametrite sa vinagi poslednite
// + random
// and sreden param

// using System;
// class HiddenMessage
// {
//     static void Main()
//     { 
//         Console.WriteLine(value:"Hello");
//         PrintRandomNumber(50,155);
//         PrintRandomNumber();    
//         PrintRandomNumber(max:5);    
//     }   
     
//     static Random rand = new Random();
      
//     static void PrintRandomNumber(int min = 0, int max = 25)
//     {
//         var RandomNumber = rand.Next(min,max);
//         Console.WriteLine(RandomNumber);
//     }
// }   


// - - - - - - - - - - - - - - - Return - - - - - - - - - - - - - - - 
// ako e razl ot void trqtba da ima return
// return spira metoda

// using System;
// class HiddenMessage
// {
//     static void Main()
//     { 
//         Console.WriteLine(value:"Hello");
//         int result = PrintRandomNumber(50,155);
//         Console.WriteLine(result);
//     }   
     
//     static Random rand = new Random();
      
//     static int PrintRandomNumber(int min = 0, int max = 25)
//     {
//         var RandomNumber = rand.Next(min,max);
//         return RandomNumber;
//     }
// }   

// - - - - - - - - - - - - - - - Return - - - - - - - - - - - - - - - 
// stop with return
// 

// using System;
// class HiddenMessage
// {
//     static void Main()
//     { 
//         PrintRandomNumber();
//     }   
      
//     static void PrintRandomNumber()
//     {
//         for (int i = 0; i < 10; i++) 
//         {
//             if (i == 5) 
//             {
//                 return;
//             }
//             Console.WriteLine(i);
//         }
//     }
// }   

// - - - - - - - - - - - - - - - Return - - - - - - - - - - - - - - - 
// IS PRIME
// 

// using System;
// class HiddenMessage
// {
//     static void Main()
//     { 
//         IsPrime(int.Parse(Console.ReadLine()));
//     }   
      
//     static bool IsPrime(int number)
//     {
//         int min = 2;
//         int max = (int)Math.Sqrt(number);

//         for (int devider = min; devider < max; devider++) 
//         {
//             if (number % devider == 0) 
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
// }   

// - - - - - - - - - - - - - - - Overloading - - - - - - - - - - - - - - - 
// methods
// moje da ima dva ednakvi no trqbva da ima razl kolichestvo parametri
// tip i broi da sa razlichni

// using System;
// class HiddenMessage
// {
//     static void Main()
//     { 
//         IsPrime(int.Parse(Console.ReadLine()));
//     }   
      
//     static bool Useless()
//     {

//     }

//     static bool Useless(int number)
//     {

//     }

//     static bool Useless(bool number)
//     {

//     }
// }   

// - - - - - - - - - - - - - - - Overloading - - - - - - - - - - - - - - - 
// methods


// using System;
// class HiddenMessage
// {
//     static void Main()
//     { 
//         Useless(int.Parse(Console.ReadLine()));
//     }   
      
//     static void Useless(int numbers)
//     {

//     }

//     static void Useless(int[] number)
//     {

//     }
// }   

// - - - - - - - - - - - - - - - Params - - - - - - - - - - - - - - - 
// napulva obekta


// using System;
// class HiddenMessage
// {
//     static void Main()
//     { 
//         Console.WriteLine(Sum(new[] {1, 4, 7, 9}));
//         Console.WriteLine(Sum(1, 4, 7, 9));
//         Console.WriteLine(Sum(1, 4, 7, 4, 7, 8));
//     }

//     static int Sum(params int[] numbers)
//     {
//         var s = 0;
//         foreach (var number in numbers) 
//         {
//             s += number;
//         }
//         return s;
//     }
// }   

// - - - - - - - - - - - - - - - Best Practices - - - - - - - - - - - - - - - 
// 1. ShortNames
// 2. Describe in a short ambiguous way
// 3. Convetion - PascalCase
// 4. Params are camelCase
// 5. imenata da pokazvat deistviq
// 6. Da imat pone edin glagol ili da pokazva deistvie


// - - - - - - - - - - - - - - - excercises - - - - - - - - - - - - - - - 

using System;
class HiddenMessage
{
    static void Main()
    { 
        IsPrime(int.Parse(Console.ReadLine()));
    }   

}   
