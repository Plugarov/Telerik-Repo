
// ------------------------ Оператори и изрази ---------------------- //

// --------------------------Running a console ------------------------//
// 1. Set path in CMD
// 		path=%path%;c:\windows\microsoft visual ....
// 2. Then you can run csc.exe from anywhere.
// 3. Go to project folder and run csc.exe filename.cs
// 3.1 filename.exe is created
// 3.2 Then run filename.exe or csc.exe filenames.cs & filename.exe (save and run)


// --------------------------CMD commands -----------------------------//
// ctr + space + ? - scroll
// сtrl + c - break process
// prompt - maha c:\windows\... 
// -----------------------Побитови опаерации -------------------------//

// convert
// Console.WriteLine(Convert.ToString(12,2)); - to bitts 2to value e dvui4na broina sistema
// int output = Convert.ToInt32(input, 2);


// ~ e kato ! - ot 0001000 sh stane 1110111;
// | subirane kato pri deseti4nite
// & - ako dvete sa endakvi 1 ina4e 0 )
// ^ ako pone edno togava rezultata e edno ina4e e 0)
// <<
// ot tva 0000 0011   
// na tva 0000 0110
// Console.WriteLine(3 << 1);
// res 6


// - - - - - - - - - -  <<  -------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{	
// 		// murda vsi4ki bitove s edno nalqvo
// 		// int mask = 1 << 1; // 1
// 		// int mask = 1 << 2; // 2
// 		// int mask = 1 << 3; // 4
// 		// int mask = 1 << 5; // 0001 0000 - 32
// 		// int mask = 32 << 1; // 0010 0000 - 64
// 		// int mask = 35 << 1; //  0010 0011 
// 		// int mask = 46 << 2; // 0000 0000 0010 1110 
// 							   // 0000 0000 1011 1000 
// 		//int mask = 32 >> 1; - obratno
// 		Console.WriteLine(mask);
//     }
// }

// -------------------  print binary on console-------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{
// 		int result = 3;
// 		Console.WriteLine(
// 			Convert.ToString(result, 2).PadLeft(32,'0')
//     	);
//     }
// }

// - - - - - - - - - -  N-th bit -------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{
// 		int pos = 4;
// 		int num = 16; // 0001 0000

// 		int mask = 1 << pos;
// 		int numAndMask = num & mask; //   mask16
// 		int bit = numAndMask >> pos;

// 		Console.WriteLine("for {0} bit at position {1} is {2}",num,pos,bit);
//     }
// }
 
// -------------------  set Bit on position p to 0 -------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{

// 		int n = 4;	// 0000 0110
// 		int p = 35; // 0010 0010
// 					// 1000 1000
// 					// 0111 0111

// 		int mask = ~(1 << n); 
// 		int newNum = (p & mask);

// 		Console.WriteLine(newNum);
//     }
// }

// -------------------  set Bit on position p to 1 -------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{

// 		int n = 4;	// 0000 0110
// 		int p = 35; // 0010 0010
// 					// 1000 1000
// 					// 0111 0111

// 		int mask = 1 << n; 
// 		int newNum = (p | mask);

// 		Console.WriteLine(newNum);
//     }
// }



// -------------------  BitExchange ------------------ TODO

// using System;

// class SetBit
// {
// 	static void Main() 
// 	{
// 		int pos = 5;
// 		int num = 5351;

// 		int mask = 1 << pos;
// 		int result = mask & num;
// 		int bit = result >> pos;
// 		int exchange = bit << 26;
		
// 		long maskP = 1 << p + i;
//         long valuesP = (n & maskP) >> (p + i);
//         long maskQ = 1 << q + i;
//         long valuesQ = (n & maskQ) >> (q + i);
//         // checking if value is 0 or 1 and doing the exchange
//         if (valuesP == 1)
//         {
//             n = n | maskQ;
//         }
//         else if (valuesP == 0)
//         {
//             n = n & ~maskQ;
//         }
//         if (valuesQ == 1)
//         {
//             n = n | maskP;
//         }
//         else if (valuesQ == 0)
//         {
//             n = n & ~maskP;
//         }
//         }

// 	}

// }

// //---------------------- Convert.ToInt32(num) --------------------------
// po korekten tui kato gurmi 



//-----------------------------	Offtopic ------------------------------------
// num check very useful

// using System;
// class ImCool
// {
// 	static void Main()
// 	{
// 		int? num = null;
// 		int num2 = num ?? 69;
// 		Console.WriteLine(num2);
//     }
// }



// ----------------------------- third digit -------------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{
// 		string input = Console.ReadLine();
// 		int inputLen = input.Length;

// 		if(inputLen >= 3) {
// 			int number = input[inputLen - 3] - '0';
// 			if(number == 7 ) {
// 				Console.WriteLine("true");
// 			} else {
// 				Console.WriteLine("false" + number);
// 			}
//  		}
//  	}
// }

// ----------------------------- Four digits -------------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{
// 		string input = Console.ReadLine();

// 		double sum = 0; 
// 		string reverse = "";

// 		for (int i = 0; i < 4; i ++) {
// 			sum += Char.GetNumericValue(input[i]);
// 		}

// 		for (int i = 3; i >= 0; i--) {
// 			reverse += input[i];
// 		}

// 		char tmp = input[1];
// 		input = input.Remove(1,1).Insert(1,input[2].ToString());
// 		input = input.Remove(2,1).Insert(2,tmp.ToString());

// 		Console.WriteLine(sum);
// 		Console.WriteLine(reverse);
//         Console.WriteLine(input);
//  	}
// }


// ----------------------------- is Prime  -------------------------


// using System;
// class ImCool
// {
// 	static void Main()
// 	{
		
// 		string input = Console.ReadLine();
// 		int num = Int32.Parse(input);

// 		if(num == 0 || num == 1 || num < 0 ) {
// 			Console.WriteLine("false");
// 		} else {
// 			for(int i = 2; i < num - 1; i++) {

// 				int devisor = i;
// 				if(num % devisor == 0) {
// 					Console.WriteLine("false");
// 					return;
// 				}
// 			}
// 			Console.WriteLine("true");
//  		}
// 	}
// }

// ----------------------------- Trapezoids  -------------------------


// using System;
// class ImCool
// {
// 	static void Main()
// 	{
	
// 		Console.WriteLine("Enter a b sides and height");
// 		string input = Console.ReadLine();		

// 		string[] arg = input.Split(new string[] { " " }, StringSplitOptions.None);

// 		double sideA = Double.Parse(arg[0]);
// 		double sideB = Double.Parse(arg[1]);
// 		double height = Double.Parse(arg[2]);
// 		double result = ((sideB+sideA)/2)*height;

// 		Console.WriteLine("The area is : " + "{0:0.0000000}",result);
// 	}
// }

// -------------------  FINAL N-BIT ------------------

// using System;
// class ImCool
// {
// 	static void Main()
// 	{

// 		int pos = 0; // 0010 0000
// 		int num = 5; // 0010 0011

// 		int mask = 1 << pos;
// 		int maskAndNum = mask & num;
// 		int bit = maskAndNum >> pos;
		
// 		Console.WriteLine("the bit on position {1} of number {0} is : {2} ",pos,num,bit);
// 		Console.WriteLine(
// 			Convert.ToString(num, 2).PadLeft(8,'0')
//     	);
//     }
// }

// -------------------  Modify Bit ------------------

// using System;

// class SetBit
// {
// 	static void Main() 
// 	{

	    // int numberInput = int.Parse(Console.ReadLine());
	    // int positionInput = int.Parse(Console.ReadLine());
	    // int bitValueInput = int.Parse(Console.ReadLine());

	    // int result = 0;

	    // if 0
		// грешно - выпреки че работи донякъде
		// int num = 62241;
		// int pos = 11;
		// int mask = 1 << pos;
	 	// Console.WriteLine(mask ^ num);


		// вярно
		// int num = 62241;
		// int pos = 11;
	 	// int mask = ~(1 << pos);
	 	// Console.WriteLine(mask & num);


		// if 1

		// int num = 16;
		// int pos = 3;
	 	// int mask = 1 << pos;
	 	// Console.WriteLine(mask | num);
// 	}
// }

