------------------------ Conditional Statements ---------------------- //
to lower

using System;
class QuadraticEquation
{
    static void Main()
    {
       	char letter = 'B';
       	if('A' <= letter && letter <= 'Z') {
       		letter += (char)('a' - 'A');
       	}
       	Console.WriteLine(letter);
    }
}

------------------------ De Morgan Laws ---------------------- //


!!A equals A
!(A || B) equals !A && !B
!(A && B) equals !A || !B


------------------------ Swich Case ---------------------- //

Using switch – Good Practices
There must be a separate case for every normal situation
Put the normal case first
Put the most frequently executed cases first and the least frequently executed last
Order cases alphabetically or numerically
In default use case that cannot be reached under normal circumstances

------------------------ Multiplication sign ---------------------- //

using System;
class QuadraticEquation
{
    static void Main()
    {	

    	int num1 = int.Parse(Console.ReadLine());
    	int num2 = int.Parse(Console.ReadLine());
    	int num3 = int.Parse(Console.ReadLine());

    	if(num1 > 0 && num2 > 0 && num3 > 0) {
    		Console.WriteLine("+");
    	} else if (num1 == 0 || num2 == 0 || num3 == 0) {
    		Console.WriteLine("0");
    	} else if ((num1 > 0 && num2 > 0 && num3 < 0 || 
    				num1 < 0 && num2 > 0 && num3 > 0 || 
    				num1 > 0 && num2 < 0 && num3 > 0 ||
    				num1 < 0 && num2 < 0 && num3 < 0 
    				)){
    		Console.WriteLine("-");
    	} else {
    		Console.WriteLine("+");
    	}
    	
    }
}