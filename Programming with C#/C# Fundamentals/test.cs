BE ELEGANT
http://bgcoder.com/Contests/Submissions/View/1179185


------------------------ Boby avokadoto  ---------------------- //

using System;
using System.Collections.Generic;

class QuadraticEquation
{
    static void Main()
    {
     int bobyHead = int.Parse(Console.ReadLine());
     int numOfCombs = int.Parse(Console.ReadLine());

      Console.WriteLine(Convert.ToString(bobyHead,2));

     for(int i = 0; i < numOfCombs; i++) {

       int comb = int.Parse(Console.ReadLine());
       string toBit = Convert.ToString(comb,2);
        
       bool isRightComb = (bobyHead & comb) == 0;

       if(isRightComb) {

       }

     }

    int a = 32;
    int pos = 0;
    int Mask = 1 << pos;
    int numAndMask = a & Mask;
    Console.WriteLine(numAndMask);
    
    // 0001 0000
  }
}


------------------------ Buses ---------------------- //

using System;
using System.Collections.Generic;

class QuadraticEquation
{
    static void Main()
    {
     int count = int.Parse(Console.ReadLine());

     int groupSpeed = int.MaxValue;
     int groups = 0;
     for(int i = 0; i < count; i++) {
        
       int busSpeed = int.Parse(Console.ReadLine());
       if(groupSpeed >= busSpeed) {
         groups++;
         groupSpeed = busSpeed;
       }
     }
     Console.WriteLine(groups);
 }
}


------------------------ Number of pages ---------------------- //


using System;
class ReadingKeys
{
    static void Main(){

     int digits = int.Parse(Console.ReadLine());
     int pages = 0;

     for (int page = 1; digits != 0; page++) {
        pages++;
        if (page < 10) {
          digits -= 1;
        } else if (page < 100) {
          digits -= 2;
        } else {
          digits -= 3;
        }
     }
     Console.WriteLine(pages);
    }  
}

- - - - - - - - - - - Number of Pages


------------------------ Mythical numbers ---------------------- //

ASCII
converts to integer. It takes position 57 - 48 which results 9(integer)
int fDig = '9' - '0';
Console.WriteLine(fDig.GetType() + " " + fDig);


using System;
class ReadingKeys
{
    static void Main(){

     string digits = Console.ReadLine();
     int fDig = digits[0] - '0';
     int sDig = digits[1] - '0';
     int tDig = digits[2] - '0';

     // int fDig = int.Parse((digits/100) % 10);
     // int sDig = int.Parse((digits/10) % 10);
     // int tDig = int.Parse((digits/1) % 10);

     double result = 0;

     if (tDig == 0) {
      result = (double)fDig * (double)sDig;
     } else if (0 < tDig && tDig <= 5) {
      result = ((double)fDig * (double)sDig)/(double)tDig;
     } else if (tDig > 5) {
      result = ((double)fDig + (double)sDig)*(double)tDig;
     }

     Console.WriteLine("{0:0.00}",result);

    }  
}

------------------------ Jump, Jump ---------------------- //

using System;
class JumpJump
{
    static void Main(){

    string input = Console.ReadLine();

    int position = 0;
    bool stopper = true;

    while(stopper) {
      if(position < input.Length && position >= 0){
        int pos = (int)Char.GetNumericValue(input[position]);   
         // can be dowe with 1 - '1' to convert it in int  
            
        if(pos % 2 == 0 && pos != 0) {
          position = position + pos;
        } else if (pos % 2 > 0) {
          position = position - pos;
        } else if (pos == 0) {        
          Console.WriteLine("Too drunk to go on after {0}!",position);
          stopper = false;
          break;
        } else if (pos == -1) {
          Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!",position);
          stopper = false;
          break;
        } 
      } else {
         Console.WriteLine("Fell off the dancefloor at {0}!",position);
         stopper = false;
         break;
      }  
    }
  }  
}

------------------------ Hidden Message ---------------------- //
parsing integer on empty.
continue to skip a loop. for example if empty input is given

using System;
class HiddenMessage
{
    static void Main(){

    bool end = true;
    string coded = "";

        while(end) {

          int startIndex = 0;
          string s = Console.ReadLine();
          
          if(string.IsNullOrEmpty(s)) {
            continue;
          } else if (s == "end") {
            Console.WriteLine(coded);
            end = false;
            break;
          } 
          else {
            startIndex = int.Parse(s);
          }

          int skipper = int.Parse(Console.ReadLine());
          string text = Console.ReadLine();
          int currentIndex = startIndex;
          

          for (int i = startIndex; i <= text.Length; i++) {
           if(currentIndex < text.Length) {
            coded += text[currentIndex];
            currentIndex += skipper;
           } else if(currentIndex > text.Length) {
            currentIndex += text.Length - 1;
           } 
          }
      }   
    }  
}

------------------------ Hidden Message 2 ---------------------- //

using System;
class HiddenMessage
{
    static void Main(){

      string HiddenMessage = "";

      while(true) {
        string indStr = Console.ReadLine();
        if (indStr == "end") { break; }

        int ind = int.Parse(indStr);
        int step = int.Parse(Console.ReadLine());
        string line = Console.ReadLine();

        if (ind < 0) 
          ind += line.Length;

        for (;ind < line.Length && ind >= 0; ind += step)
        {
          HiddenMessage += line[ind];
        }
      }
     
     Console.WriteLine(HiddenMessage);
    }   
}

------------------------ Mixing numbers ---------------------- //

using System;
class HiddenMessage
{
    static void Main(){

      int loopNumInput = int.Parse(Console.ReadLine());
      int prevNumber = int.Parse(Console.ReadLine());

      int[] resultDifference = new int[loopNumInput - 1];
      int[] resultMixed = new int[loopNumInput -1];

      for (int i = 0; i < loopNumInput - 1; i++) {

        int nextNumber = int.Parse(Console.ReadLine());

        resultDifference[i] = Math.Abs(prevNumber - nextNumber);
        resultMixed[i] = (prevNumber % 10) * (nextNumber / 10);

        prevNumber = nextNumber;
      }
      Console.WriteLine(String.Join(" ", resultMixed));            
      Console.WriteLine(String.Join(" ", resultDifference));
    }         
}

------------------------ Mixing numbers ---------------------- //

