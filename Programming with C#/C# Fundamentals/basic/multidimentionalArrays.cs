// using System;
// class HiddenMessage
// {
//     static void Main(){

//     	//int[,] matrix = new int[3,4];

//     	int[,] matrix = {
//     		{ 2, 3, 4 },
//     		{ 5, 6, 7 }
//     	};

//     	int[,,] cube = {
//     		{ 	
//     			{ 1, 2, 3 },
//     			{ 4, 5, 6 }	
//     		},
//     		{ 
//     			{ 5, 6, 7 },
//     			{ 8, 9 ,10 }    		
//     		}
//     	};


//     	for (int r = 0; r < matrix.GetLength(0); r++) {
// 	    	for (int c = 0; c < matrix.GetLength(1); c++) {
// 	    		Console.Write("{0} ",matrix[r, c]);
// 	    	}	
// 	    	Console.WriteLine();
//     	}

//     	Console.WriteLine(" - - - ");

//     	for (int row = 0; row < cube.GetLength(0); row++) {
// 	    	for (int col = 0; col < cube.GetLength(1); col++) {
// 	    		for ( int depth = 0; depth < cube.GetLength(2); depth++) {
// 	    			Console.Write(" {0} ", cube[row, col, depth]);
// 	    		}
// 	 		Console.WriteLine();
// 	    	}
//     	}
//     }   
      
// }


// - - - - - - - - - - - - - - - Finding cub sub - - - - - - - - - - - - - - - 


// using System;

// class HiddenMessage
// {
//     static void Main(){

//         int[,] matrix = {
//             {115, 15, 35, 5, 5},
//             {5, 15, 5, 5, 5}, 
//             {345, 15, 25, 35, 215}
//         };


//         int result = 0;
//         int row = 0;
//         int col = 0;

//         for (int i = 0; i < matrix.GetLength(0) - 1; i++) {
            
//             int current = i;

//             for (int j = 0; j < matrix.GetLength(1) -1 ; j++) {
                
//                 int tempResult = 0;
//                 int next = j;
//                 tempResult = matrix[current,next] + 
//                             matrix[current,next+1] + 
//                             matrix[current+1,next] + 
//                             matrix[current+1,next+1];
                

//                 if (result < tempResult) {
//                     result = tempResult;
//                     row = i;
//                     col = j;
//                 }   
//             }

//         }
//         Console.WriteLine(result);
        
//         for (int r = row; r < row + 2; r++) {

//             for (int c = col; c < col + 2; c++) {

//                 Console.Write("{0} ",matrix[r,c]);
//             }
//             Console.WriteLine(" ");
//         }

//     }   
// }


// - - - - - - - - - - - - - - - Jagged arrays - - - - - - - - - - - - - - - 
// Triangle

//         int n = 10;
//         string[][] pyramid = new string[n][];
        
//         pyramid[0] = new string[3];
//         pyramid[0][0] = "you";
//         pyramid[0][1] = "are";
//         pyramid[0][2] = "nigger";
        
//         Console.WriteLine(pyramid[0][0]);


// using System;

// class HiddenMessage
// {
//     static void Main(){        // int[][] jagged = new int[3][];
//         // jagged[0] = new int[3];
//         // jagged[0] = new int[3];
//         // jagged[0] = new int[6];

//         int n = 10;
//         int num = 0;
//         int[][] triangle = new int[n][];
        
//         for (int row = 0; row < n; row++) 
//         {
//             triangle[row] = new int[row + 1];
//             for (int col = 0; col < triangle[row].Length ; col++) {
//                triangle[row][col] = num;
//                num++;
        
//             }        
//         }

//         for (int i = 0; i < triangle.GetLength(0); i ++) {
//             for (int j = 0; j < triangle[i].Length; j++) {
//                 Console.Write("{0,3}, ",triangle[i][j]);                   
//             }   
//             Console.WriteLine(" ");
//         }
//     }   
// }

// - - - - - - - - - - - - - - - Jagged arrays and list- - - - - - - - - - - - - - - 


// using System;
// using System.Collections.Generic;

// class HiddenMessage
// {
//     static void Main(){        
        
//         int[] numbers = { 4, 5, 3, 7, 9, 5, 3, 4, 33, 2};

//         List<int>[] jagged = new List<int>[3];

//         for (int j = 0; j < jagged.Length; j++) { // declare otherwise will be null
//             jagged[j] = new List<int>();
//         }

//         for (int i = 0; i < numbers.Length; i++) { // inport
//             int index = numbers[i] % 3;
//             jagged[index].Add(numbers[i]);
//         }

//         for (int i = 0; i < jagged.Length; i++) { // print
//             Console.WriteLine(string.Join(", ", jagged[i]));
//         }
//     }   
// }

// - - - - - - - - - - - - - - - Pascal triangle- - - - - - - - - - - - - - - 

// using System;
// using System.Collections.Generic;

// class HiddenMessage
// {
//     static void Main(){        
             

//         int n = 10;
//         int[][] pyramid = new int[n][];
        

//         for (int i = 0; i < pyramid.Length; i++) 
//         {
//             pyramid[i] = new int[i + 1];
//         }

//         pyramid[0][0] = 1;

//         for (int row = 0; row < pyramid.Length - 1; row++) 
//         {
//             for (int col = 0; col < pyramid[row].Length; col++) 
//             {
//                 pyramid[row + 1][col] += pyramid[row][col];
//                 pyramid[row + 1][col + 1] += pyramid[row][col];
//             }
//         }

//         for (int row = 0; row < pyramid.Length - 1; row++) 
//         {
//             for (int col = 0; col < pyramid[row].Length; col++) 
//             {
//                 Console.Write("{0}, ",pyramid[row][col]);
//             }
//             Console.WriteLine();
//         }
//     }   
// }

// - - - - - - - - - - - - - - - Properties- - - - - - - - - - - - - - - 
// Rank - get dimensions
// Length - get length
// GetLength() - get length on specific dimension
// GetEnumenator - 
// Binary Search
// IndexOf 
// LastIndexOf
// Reverse
// Clear
// BinarySearch - search in a sorted array


// using System;
// using System.Collections.Generic;

// class HiddenMessage
// {
//     static void Main(){        
    
//     // copy fist 5         
//     int[] numbers = { 4, 5, 3, 7, 9, 5, 3, 4, 33, 2};
//     int[] result new int[5];
//     Array.Copy(numbers, result, 5);
//     Console.WriteLine(string.Join(", ",result));        

//     Array.Reverse(numbers) // void // preobrushta bez da suzdava nov
//     Console.WriteLine(string.Join(", ",result));        

//     Array.Sort(numbers);
//     Console.WriteLine(string.Join(", ",result));       
//     }
       
// }

// // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
// // 

// using System;
// using System.Collections.Generic;

// class HiddenMessage
// {
//     static void Main(){        
    
//     // copy fist 5         
//     int[] numbers = { 4, 5, 3, 7, 9, 5, 3, 4, 33, 2};


//     }
       
// }

// // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
// Fill the matrix

// using System;
// class FourMatrices
// {
//     static void Main()
//     {
//         Console.Write("Enter size of matrix N: ");
//         int n = int.Parse(Console.ReadLine());
//         int[,] matrix = new int[n, n];
//         /* The counter will be filling the matrices, as the numbers in them are to be consecutive */
//         int counter;

//         // solution "A"

//         Console.WriteLine("\nSolution A:");
//         counter = 1;
//         for (int row = 0; row < n; row++)
//         {
//             for (int col = 0; col < n; col++)
//             {
//                 matrix[col, row] = counter;
//                 counter++;
//             }
//         }

//         // calling the PrintMatrix method
//         PrintMatrix(n, matrix);

//         // solution "B"
//         Console.WriteLine("Solution B:");
//         counter = 1;
//         for (int row = 0; row < n; row++)
//             for (int col = 0; col < n; col++)
//             {
//                 if (row % 2 == 0)
//                 {
//                     matrix[col, row] = counter;
//                 }
                
//                 // the odd columns will be printed backwards
//                 else
//                 {
//                     matrix[n - col - 1, row] = counter;
//                 }

//                 counter++;
//             }

//         PrintMatrix(n, matrix);

//         // solution "C"
//         Console.WriteLine("Solution C:");
//         counter = 1;
//         for (int i = n - 1; i >= 0; i--)
//         {
//             int row = i; // rows printed backwards
//             int col = 0; // columns - forward
//             do
//             {
//                 matrix[row, col] = counter;
//                 col++;
//                 row++;
//                 counter++;
//             } while (row < n);
//         }
//         for (int i = 1; i < n; i++)
//         {
//             // both rows and columns printed forward
//             int col = i;
//             int row = 0;
//             do
//             {
//                 matrix[row, col] = counter;
//                 col++;
//                 row++;
//                 counter++;
//             } while (col < n);
//         }
//         PrintMatrix(n, matrix);

//         // solution "D"
//         Console.WriteLine("Solution D:");
//         int leftColumn = 0; // First unfilled row
//         int rightColumn = n - 1; // Last unfilled row
//         int upperRow = 0; // Left unfilled column
//         int bottomRow = n - 1; // Right unfilled column
//         int count = 1; // from 1 to N*N
//         do
//         {
//             for (int i = upperRow; i <= bottomRow; i++) // filling the first available column
//             {
//                 matrix[i, leftColumn] = count;
//                 count++;
//             }
//             leftColumn++; // we go to the next column

//             for (int i = leftColumn; i <= rightColumn; i++) // filling the bottom row
//             {
//                 matrix[bottomRow, i] = count;
//                 count++;
//             }

//             bottomRow--; // we go one row up
//             for (int i = bottomRow; i >= upperRow; i--) // filling the rightmost column
//             {
//                 matrix[i, rightColumn] = count;
//                 count++;
//             }
//             rightColumn--; // we go one column to the left
//             for (int i = rightColumn; i >= leftColumn; i--) // filling top available column
//             {
//                 matrix[upperRow, i] = count;
//                 count++;
//             }
//             upperRow++; // one row down again
//         } while (count <= n * n); // and continuing the spiral until count = n*n

//         PrintMatrix(n, matrix);
//     }


//     private static void PrintMatrix(int n, int[,] matrix)
//     {

//         for (int rows = 0; rows < n; rows++)
//         {
//             for (int cols = 0; cols < n; cols++)
//             {
//                 // changed places of rows and columns, so that we can get the columns printed one by one
//                 Console.Write("{0,3}", matrix[rows, cols]); 
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
// Sequence in matrix



// using System;
// using System.Collections.Generic;

// class HiddenMessage
// {
//     static void Main()
//     {        

//         string inputRowsAndCols = Console.ReadLine();
//         string[] splitToRowsAndCols = inputRowsAndCols.Split(' ');

//         int rows = int.Parse(splitToRowsAndCols[0]);
//         int cols = int.Parse(splitToRowsAndCols[1]);

//         int[,] matrix = new int[rows,cols];

//         for (int i = 0; i < rows; i++) 
//         {

//             string rowWithNumbers = Console.ReadLine();
//             string[] colValues = rowWithNumbers.Split(' ');

//             for (int j = 0; j < cols; j++) 
//             {

//                 matrix[i,j] = int.Parse(colValues[j]);
//             }
//         }

//         int maxSequence = 1;

        // int countRow = 1;
        // for (int row = 0; row < rows; row++) 
        // {           
        //     for (int col = 0; col < cols; col++) 
        //     {
        //         if (col + 1 < cols && matrix[row,col] == matrix[row,col + 1] ) 
        //         {
        //             countRow++;
        //         } 
        //         else
        //         {
        //             if (countRow > maxSequence) 
        //             {
        //                 maxSequence = countRow;
        //             }
        //             else 
        //             {
        //                 countRow = 1;
        //             }
        //         }
        //     }
        // }
        
        // for (int row = 0; row < rows; row++)
        // {   
        //     for (int col = 0; col < cols; col++) 
        //     { 
        //         int currentLength = 1;
        //         for (int i = row; i < rows; i++)
        //         {
        //             if (i + 1 < rows && matrix[i + 1,col] == matrix[row,col])
        //             {
        //                 currentLength++;
        //             }
        //             else
        //             {
        //                 break;
        //             }        
        //         }
        //         if (currentLength > maxSequence)
        //         {
        //             maxSequence = currentLength;
        //         }
        //     } 
        // }
        
        // for (int row = 0; row < rows; row++)
        // {   
        //     for (int col = 0; col < cols; col++) 
        //     { 
        //         int currentLength = 1;
        //         for (int i = row, j = col; i < rows; i++, j++)
        //         {
        //             if (i + 1 < rows && j + 1 < rows && matrix[i + 1,j + 1] == matrix[row,col])
        //             {
        //                 currentLength++;
        //             }
        //             else
        //             {
        //                 break;
        //             }        
        //         }
        //         if (currentLength > maxSequence)
        //         {
        //             maxSequence = currentLength;
        //         }
        //     } 
        // }
        // Console.WriteLine(maxSequence);

        // for (int row = 0; row < rows; row++) 
        // {
        //     for (int col = 0; col < cols; col++) 
        //     {
        //         Console.Write("{0,3}",matrix[row,col]);
        //     }
        //     Console.WriteLine();
        // }


//     }
// }

// // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
// Largest area in matrix

// using System;
// using System.Collections.Generic;

// class HiddenMessage
// {
//     static void Main(){       

//         string[] splitToRowsAndCols = Console.ReadLine().Split(' ');
//         int rows = int.Parse(splitToRowsAndCols[0]);
//         int cols = int.Parse(splitToRowsAndCols[1]);

//         int[,] matrix = new int[rows,cols];

//         for (int i = 0; i < rows; i++) 
//         {
//             string rowWithNumbers = Console.ReadLine();
//             string[] colValues = rowWithNumbers.Split(' ');
            
//             for (int j = 0; j < cols; j++) 
//             {
//                 matrix[i,j] = int.Parse(colValues[j]);
//             }
//         }
//     }
// }
using System;
using System.Text;

class LargestAreaInMatrix
{
// input array
 static int[,] matrix = new int[,]
{ {1, 3, 2, 2, 2, 4},
{3, 3, 3, 2, 4, 4},
{4, 3, 1, 2, 3, 3},
{4, 3, 1, 3, 3, 1},
{4, 3, 3, 3, 1, 1} };

// logic
 static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

    static int DepthFirstSearch(int row, int col, int value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }
        if (visited[row, col])
        {
            return 0;
        }
        if (matrix[row, col] != value)
        {
            return 0;
        }
        visited[row, col] = true;
        return DepthFirstSearch(row, col + 1, value) + DepthFirstSearch(row, col - 1, value) +
        DepthFirstSearch(row + 1, col, value) + DepthFirstSearch(row - 1, col, value) + 1;
    }

    // printing
    static void PrintResult()
    {
        // result
        int result = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));                
            }
        }
        Console.WriteLine("\n{0} equal neighbour elements.\n", result);

        // matrix
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (matrix[rows, cols] == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write("{0,3}", matrix[rows, cols]);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        PrintResult();
    }
}

