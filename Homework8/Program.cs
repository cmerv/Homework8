namespace Homework8;
class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }
public static void ArraySum (int[] int_array)
{
    int k = 0;
    foreach (int i in int_array)
    {
        k += i; // sum up all the vals of i (each element) as we iterate through them
    }
     Console.WriteLine($"The sum of int_array is {k}");
}

public static void PrintAllOddNumber (int [ , ] array_2d)
{
    for (int x=0; x<3; x++)
    {
        for (int y=0; y<3; y++)
        {
            if (array_2d[x,y]%2!=0) // choose only non-even element values
            {
                Console.Write(array_2d[x,y]+" "); // display elements and write to console
            }
        }
    }
}

public static int ElementSum (int [ , ] array_2d)
{
    int k = 0;
    for (int x=0; x<3; x++)
    {
        for (int y=0; y<3; y++) 
        {
            k += array_2d[x,y]; // k is equal to itself plus the sum of each element value
        }
    }
    return k;
}

public static int[ , ] DoubleArray(int [ , ] array_2d) 
{
     for (int x=0; x<3; x++)
    {
        for (int y=0; y<3; y++) 
        {
            int elementValue = array_2d[x,y]; // grab element value from array
            elementValue *= 2;
            array_2d[x,y] = elementValue; // modify each element of array_2d with our new doubled element value
        }
    }
    return array_2d;
}
}