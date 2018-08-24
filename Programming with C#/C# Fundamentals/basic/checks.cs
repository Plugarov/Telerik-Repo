check if in matrix
-----------------------------------------------------------------------------------------

if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))

-----------------------------------------------------------------------------------------

for (int i = row, j = col; i < rows; i++, j++)
                {
                    if (i + 1 < rows && j + 1 < rows && matrix[i + 1,j + 1] == matrix[row,col])

-----------------------------------------------------------------------------------------
//  string to int array
    	string[] numbers = Console.ReadLine().Split(' ');
    	
    	int[] nums = new int[numbers.Length];
    	for (int i = 0; i < numbers.Length; i++) 
    	{
    		int tmp;
    		if (int.TryParse(numbers[i], out tmp)) 
    		{
    			nums[i] = tmp;
    		}
    	}
