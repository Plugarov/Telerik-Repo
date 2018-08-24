------------------------ Arrays ---------------------- //
http://telerikacademy.com/Courses/LectureResources/Video/9182/%D0%92%D0%B8%D0%B4%D0%B5%D0%BE-1-%D0%BD%D0%BE%D0%B5%D0%BC%D0%B2%D1%80%D0%B8-2016-%D0%9A%D1%80%D0%B8%D1%81%D1%82%D0%B8%D1%8F%D0%BD
additional info


------------------------ Declaring array of integers and strings ---------------------- //

using System;
class QuadraticEquation
{
    static void Main()
    {
		  	
    	string[] numbers = new string[10];
  	int[] numbers = { 1,2,3,4,5 };
   	numbers[3] = 3;	

    	for (int i = 0; i < 10; i++) {
    		Console.WriteLine(numbers[i]);
    	}
    }
}

------------------------ Join array in string ---------------------- //

using System;
class QuadraticEquation
{
    static void Main()
    {
		int n = int.Parse(Console.ReadLine());

    	int[] numbers = new int[n];

    	for (int i = 0; i < n; i++) {
    		numbers[i] = int.Parse(Console.ReadLine());
    	}
    	Console.WriteLine(String.Join("+", numbers));
    }
}

------------------------ foreach ---------------------- //

using System;
class QuadraticEquation
{
    static void Main()
    {
		string[] names = {
			"Pesho",
			"Gosho"
		};
		//var names = new String[] { } - poznai kuv tip edin vid // polzva se za foreach

		foreach (string w in names) {
			Console.WriteLine("name: " + w);
		}
    }
}


------------------------ resize / add / remove   ---------------------- //
ne e .Length a e Count

using System;
using System.Collections.Generic;

class QuadraticEquation
{
    static void Main()
    {
		List<int> intList = new List<int>();

		for (int i = 0; i < 10; i++) {
			intList.Add(i);
		}

		intList.Remove(3);
		intList.RemoveAt(3);
		Console.WriteLine(intList.Contains(5));
		Console.WriteLine(String.Join(" ",intList));
	}	
}

------------------------ x  ---------------------- //
2h MIN TODO

------------------------ Shadow copy  ---------------------- //

using System;
using System.Collections.Generic;

class QuadraticEquation
{
    static void Main()
    {
		int[] arr = {1,2,3,4,5};
		int[] arr2 = (int[])arr.Clone();
		arr[1] = 5;

		Console.WriteLine(arr[1]);
		Console.WriteLine(arr2[1]);
	}	
}

------------------------ Allocate array  ---------------------- //


using System;

class QuadraticEquation
{
    static void Main()
    {
    	int n = int.Parse(Console.ReadLine());
		
		int[] arr = new int[n];
		for(int i = 0; i < n; i++) {
			arr[i] = i * 5;
		}
		for(int j = 0; j < n; j++) {
			Console.WriteLine(arr[j]);
		}
	}	
}



------------------------ Compare arrays  ---------------------- //


using System;

class QuadraticEquation
{
    static void Main()
    {
		int[] n = {1,2,3,4,5,4,3,2,1};    	

		bool symetric = true;
   		int startIndex =  0;
   		int endIndex = n.Length - 1;

    	while(startIndex < endIndex) {
    		if(n[startIndex] != n[endIndex]){
    			symetric = false;
    			break;
       	} 
    		++startIndex;
    		--endIndex;
    	}

    	if(symetric) {
    		Console.WriteLine("Equal");
    	} else {
    		Console.WriteLine("Not Equal");
    	}
	}	
}

------------------------ Remove elements from array ---------------------- //

using System;
using System.Collections.Generic;

class QuadraticEquation
{
    static void Main()
    {
		List<int> intList = new List<int>();

		for (int i = 0; i < 30; i++) {
			intList.Add(i);
		}
		intList.RemoveAt(3);		
		Console.WriteLine(String.Join(" ",intList));
	}	
}




