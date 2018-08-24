

// - - - - - - - - - -  Вход и изход от конзолата -------------
// po korekten tui kato gurmi 


// using System;
// class ImCool
// {
// 	static void Main()
// 	{
// 		double num = 123;
// 		//Console.WriteLine("this is line {0} {1} {2}",num,num+num,"yo");
// 		//Console.WriteLine("{0,4}",42); // da parsne chisloto v 4 poleta

// 		//aligment

// 		//Console.WriteLine("{0,3} {1,3} {2,3}",231,446,584); // podredeno printrva
// 		//Console.WriteLine("{0,3} {1,3} {2,3}",651,436,284); // podredeno printrva
// 		//Console.WriteLine("{0,-3} {1,-3} {2,-3}",231,846+184,123); // podredeno printrva

// 		//format string - printva opredeleno kol nuli otzad
// 		Console.WriteLine9
//  		Console.WriteLine("{0:0.000}",12.42343);

//  	}
// }

// ---------------- ALIGMENT --------------------

// Input
// 	 Read(…) – reads a single character
// 	 ReadKey(…) – reads a combination of keys
// 	 ReadLine(…) – reads a single line of characters
// Output
//	 Write(…) – prints the specified argument on the console
//	 WriteLine(…) – prints specified data to the console and moves to the next line

// using System;
// class ImCool
// {
// 	static void Main()
// 	{
// 		Console.WriteLine("{0,4} {1,4} {2,4}",231,446,54);
// 		Console.WriteLine("{0,4} {1,4} {2,4}",2131,446,1);
//  	}
// }
	
// ----------------------- FORMAT STRING --------------------

// zakruglyane
//	Console.WriteLine("{0:0.00000}",12.434); - zakruglya - 12.23 - 12.23 00000
//  Console.WriteLine("{0:X}",1234); - shesnaisetichni chisla
//  Console.WriteLine("{0:C}",1234); - na dolar
//	MSDN - string format
//  Console.WriteLine("{0:D}",DateTime.Now);
// 	Console.WriteLine(" {0:0.00}",Math.Floor(area * 100)/100); - otrqzva
// dr variant s indexof na to4kata

// ----------------------- FORMAT STRING --------------------
// 	Console.Read(); - vrushta int
// 	shte vrushta ASCII
//	int r = Console.Read(); - za intove
// 	string r = ConsoleReadLine(); - za stringove
//	Console.WriteLine(r); 

//	string text = System.IO.File.ReadAllText(@"E:\docs\Шамиль\Desktop\git\Introduction\text.txt"); read file

//	string text = Console.ReadLine();
//	Console.WriteLine("Contents of WriteText.txt = {0}", (string)text);	

// reading keys from input

// class ReadingKeys
// {
//     static void Main()
//     {
//      	ConsoleKeyInfo key = Console.ReadKey(); <- shete vednaga
//     	    Console.WriteLine();
// 			Console.WriteLine("Key name: " + key.Key);
// 			Console.WriteLine("Key number: " + (int)key.Key);
// 			Console.WriteLine("Special keys: [{0}] ", key.Modifiers);
// 			Console.WriteLine("Character entered: " + key.KeyChar);
//     }
// }

// chete

// using System;
// class ReadingKeys
// {
//     static void Main()
//     {
//  		string text = Console.ReadLine();
//  		while(text != null) {
//  			Console.WriteLine(text);
//  			text = Console.ReadLine();
//  		}
//     }	
// }

// PARSE  ----------------------------------------------------

// using System;
// class ReadingKeys
// {
//     static void Main()
//     {
//  		string text = Console.ReadLine();
//  		int sum = int.Parse(text);
//  		Console.WriteLine(sum+5);
//     }	
// }

// parse + summ ----------------------------------------------------

// using System;
// class ReadingKeys
// {
//     static void Main()
//     {
//  		string a = Console.ReadLine();
//  		int num1 = int.Parse(a);
//  		string b = Console.ReadLine();
//  		int num2 = int.Parse(b);
//  		Console.WriteLine("{0} + {1} = {2}",num1,num2,num1+num2);
//     }	
// }

// parse + bool  ----------------------------------------------------

// using System;
// class ReadingKeys
// {
//     static void Main()
//     {
//  		Console.WriteLine(bool.Parse("false"));
//     }	
// }


// CONVERT  ----------------------------------------------------

// using System;
// class ReadingKeys
// {
//     static void Main()
//     {
//     	string input = Console.ReadLine();
//  		int input2 = Convert.ToInt32(input);
//  		Console.WriteLine(input2);
//     }	
// }

// ERROR HANDLING PARSE  ----------------------------------------------------

// using System;
// class ReadingKeys
// {
//     static void Main()
//     {
//     	string str = Console.ReadLine();
//     	int number;
//     	bool f = int.TryParse(str, out number);
//     	if(f) {
//     		Console.WriteLine("true {0}",str);
//     	} else {
//     		Console.WriteLine("false");
//     	}
//     }	
// }

// EREGIONAL SETTINGS  ----------------------------------------------------

// using System;
// using System.Text;

// class ReadingKeys
// {
//     static void Main()
//     {
//     	Console.OutputEncoding = Encoding.UTF8;
//   	// Console.OutputEncoding = Encoding.ASCII;;
//     	Console.WriteLine("ыфвфв");
//     }	
// }

// DECIMAL SEPARATORS  ----------------------------------------------------
// na kratko ot regions v control panel moje da nastroim to4kata da izlza 
// kato kudrava skoba naprimer . tova e sushtoto

// using System;
// using System.Threading;
// using System.Globalization;

// class ReadingKeys
// {
//     static void Main()
//     {
//     	Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//     	Console.WriteLine(1.5);
//     }	
// }

// PRIMERI  ----------------------------------------------------

// using System;
// using System.Text;

// class ReadingKeys
// {
//     static void Main()
//     {
//     	Console.Write("Enter person name: ");
//     	string person = Console.ReadLine();

// 		Console.Write("Enter company name: ");
// 		string company = Console.ReadLine();

// 		Console.WriteLine("  Dear {0},", person);
// 		Console.WriteLine("We are pleased to tell you " +
//                   "that {1} has chosen you to take part " +
//                   "in the \"Introduction To Programming\" " +
//                   "course. {1} wishes you good luck!",
//                   person, company);

// 		Console.WriteLine("  Yours,");
// 		Console.WriteLine("  {0}", company);
//     }	
// }

// Sum of 3 numbers  ----------------------------------------------------

// using System;
// using System.Text;

// class ReadingKeys
// {
//     static void Main()
//     {

//     	int a = Convert.ToInt32(Console.ReadLine());
//     	int b = Convert.ToInt32(Console.ReadLine());
//     	int c = Convert.ToInt32(Console.ReadLine());

// 		Console.WriteLine("{0}", a+b+c);
//     }	
// }

// Company info / IsNullOrEmpty ----------------------------------------------------

// using System;
// using System.Text;

// class ReadingKeys
// {
//     static void Main()
//     {

//     	string a = Console.ReadLine();
//     	string b = Console.ReadLine();
//     	string c = Console.ReadLine();
//     	string d = Console.ReadLine();
//     	string e = Console.ReadLine();
//     	string f = Console.ReadLine();
//     	string g = Console.ReadLine();
//     	string h = Console.ReadLine();
//     	string k = Console.ReadLine();

//     	if(string.IsNullOrEmpty(d)) {
//     		d = "(No Fax)";
//     	}

// 		Console.WriteLine(@"{0}
// Address: {1}
// Tel. {2}
// Fax: {3}
// Web site: {4}
// Manager: {5} {6} (age: {7}, tel. {8})"
// ,a,b,c,d,e,f,g,h,k);
//     }	
// }

// Circle  ----------------------------------------------------

// using System;

// class ReadingKeys
// {
//     static void Main()
//     {

//     	string i = Console.ReadLine();
//     	if(string.IsNullOrEmpty(i)) {
//     		Console.WriteLine("Please enter value");
//     	} 

//     	double r = Convert.ToDouble(i);

//     	double area = 3.142 * (r * r);
//     	double perimeter = 2 * 3.142 * r;

// 		Console.Write("{0:F2}",Math.Floor(perimeter * 100)/100);
// 		Console.WriteLine(" {0:0.00}",Math.Floor(area * 100)/100);

//     }	
// }

// Formatting Numbers----------------------------------------------------

// using System;

// class ReadingKeys
// {
//     static void Main()
//     {

//     	int a = int.Parse(Console.ReadLine());
//     	float b = float.Parse(Console.ReadLine());
//     	float c = float.Parse(Console.ReadLine());
 

//     	string aToBinary = Convert.ToString(a, 2).PadLeft(10,'0');
//     	string aTohexValue = a.ToString("X");

//     	string bToString = string.Format("{0:0.00}",b);
//     	string cToString = string.Format("{0:0.000}",c);

//  		Console.WriteLine("{0,-10} | {1,10} | {2,10} | {3,-10}",aTohexValue,aToBinary,bToString,cToString);
//     }	
// }

// Number Comparer----------------------------------------------------

// using System;
// class ReadingKeys
// {
//     static void Main()
//     {
//     	float a = float.Parse(Console.ReadLine());
//     	float b = float.Parse(Console.ReadLine());
//     	if(a > b) {
//     		Console.WriteLine(a);
//     	} else if (a < b) {
//     		Console.WriteLine(b);
//     	} else {
//     		Console.WriteLine("0");
//     	}
//     }	
// }

// Quadratic Equation---------------------------------------------------- TODO

// using System;
 
//     class QuadraticEquation
//     {
//         static void Main()
//         {
//             Console.Write("a = ");
//             double a = double.Parse(Console.ReadLine()); //2
//             Console.Write("b = ");
//             double b = double.Parse(Console.ReadLine()); //5
//             Console.Write("c = ");
//             double c = double.Parse(Console.ReadLine());//-3
//                                   //5*5      4 * 2 * -3
//             double discriminant = (b * b) - (4 * a * c);
//             if (discriminant > 0)
//             {
//                 double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
//                 double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
//                 Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
//             }
//             else if (discriminant == 0)
//             {
//                 double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
//                 Console.WriteLine("x1 = x2 = {0}", x1Andx2);
//             }
//             else if (discriminant < 0)
//             {
//                 Console.WriteLine("No real roots");
//             }
//         }
//     }

// Sum of 5 numbers---------------------------------------------------- 

// using System;
 
//     class QuadraticEquation
//     {
//         static void Main()
//         {
//             Console.Write("a = ");
//             double a = double.Parse(Console.ReadLine()); //2
//             Console.Write("b = ");
//             double b = double.Parse(Console.ReadLine()); //5
//             Console.Write("c = ");
//             double c = double.Parse(Console.ReadLine());//-3
//             Console.Write("d = ");
//             double d = double.Parse(Console.ReadLine());//-3
//             Console.Write("e = ");
//             double e = double.Parse(Console.ReadLine());//-3

//             double result = a+b+c+d+e;
//         	Console.WriteLine(result);
//         }
// 	}

// Numbers from 1 to N---------------------------------------------------- 

// using System;
//   	class QuadraticEquation
//     {
//         static void Main()
//         {
//             Console.Write("num = ");
//             double a = double.Parse(Console.ReadLine()); 

//             for(int i = 1; i <= a; i++) {
//             	Console.WriteLine(i);
//             }
//         }
// 	}

// Fibonacci Numbers----------------------------------------------------

// using System;
//   	class QuadraticEquation
//     {
//         static void Main()
//         {
//         	int len = int.Parse(Console.ReadLine()); 
//             int a = 0;
//             int b = 1;

//             for(int i = 1; i <= len; i++) {
//              int temp = a;
//             	a = b;
//             	b = temp + b;
//             	Console.WriteLine(b);
//             }
//         }
// 	}

// Interval---------------------------------------------------- 

using System;
  	class QuadraticEquation
    {
        static void Main()
        {
        	int a = int.Parse(Console.ReadLine()); 
        	int b = int.Parse(Console.ReadLine()); 

        	int difference = (b - a)/5;

        	Console.WriteLine(difference);
        }
	}

