namespace Ass___3
{
    internal class Program
    {


        // static int Sum(int X, int Y)
        // {
        //     int Temp = X;
        //     X = Y;
        //     Y = Temp;
        // }
        //
        //----------------------------------
        //
        // static void SWAP(ref int X, ref int Y)
        // {
        //     int Temp = X;
        //     X = Y;
        //     Y = Temp;
        // }
        // 


        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}







        // static void SumSub(int X, int Y, int Z, int W, out int Sum, out int Sub)
        // {
        // 
        //     Sum = X + Y;
        //     Sub = Z - W;
        // }








        // static int IsPrime(int Number01)
        // {
        //     if (Number01 % 2 != 0 && Number01 / Number01 == 1)
        //     {
        //         Console.WriteLine("True");
        //     }
        //     else
        //     {
        //         Console.WriteLine("False");
        //     }
        //     return Number01;
        // }


        //static void MinMaxArray(int[] Arr, ref int Min, ref int Max)
        //{
        //    Min = Arr[0];
        //    Max = Arr[0];

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        if (Arr[i] > Max)
        //        {
        //            Max = Arr[i];
        //        }
        //        if (Arr[i] < Min)
        //        {
        //            Min = Arr[i];
        //        }
        //    }
        //}

        //static int GetFactorial (int x)
        //{ 
        //    int Factorial = 1;
        //    for (int i = 1; i < x; i++) 
        //    {
        //        Factorial *= i;
        //    }
        //    return Factorial;

        //}


        //static string ChangeChar(string Word, char Char, int Pos)
        //{
        //    for (int i = 0; i < Word.Length; i++)
        //    { 
        //        Pos += Char;
        //    }
        //    return Word;
        //}




        static void Main(string[] args)
        {
            #region Q01
            // Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //

            // 1- Passing By Value : Don't Affected To (Variables) You Will Passing In Function
            // 2- Passing By Reference : Affected To (Variables) You Will Passing In Function
            //

            // 1- Passing By Value :->

            // int A = 10 , B = 20 ;
            // 
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"A : {B}");
            // 
            // Console.WriteLine("After SWAP :---->");
            // 
            // SWAP(A, B);
            // 
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"A : {B}");

            // 2 - Passing By Reference :->

            // int A = 10, B = 20;
            // 
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"A : {B}");
            // 
            // Console.WriteLine("After SWAP :---->");
            // 
            // SWAP(ref A,ref B);
            // 
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"A : {B}");

            #endregion

            #region Q02 
            // Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example

            // int[] Numbers = { 1, 2, 3 };

            // ----> Passing By Value:

            //Console.WriteLine(SumArray(Numbers));    
            //Console.WriteLine(Numbers[0]);



            // ----> Passing By Ref :

            //Console.WriteLine(SumArray(ref Numbers));  
            //                                           
            //Console.WriteLine(Numbers[0]);


            #endregion

            #region Q03
            // Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two Numbers

            // Console.WriteLine("Enter The Values : ");
            // int A = int.Parse(Console.ReadLine());
            // int B = int.Parse(Console.ReadLine());
            // int Z = int.Parse(Console.ReadLine());
            // int W = int.Parse(Console.ReadLine());
            // 
            // Console.WriteLine("-----------------------------");
            // 
            // int Sum, Sub;
            // 
            // SumSub(A, B, Z, W, out Sum, out Sub);
            // 
            // Console.WriteLine($"Sum : {Sum}");
            // Console.WriteLine($"Sub : {Sub}");

            #endregion

            #region Q04 *****
            // Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.


            #endregion

            #region Q05 
            // Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            // Console.WriteLine("Enter Your Number : ");
            // 
            // int A = int.Parse(Console.ReadLine());
            // 
            // IsPrime(A);

            #endregion

            #region Q06 
            // Create a function named MinMaxArray, to return the Minimum and Maximum values stored in an array, using reference parameters

            //int [] Arr = { 10, 15, 5, 7, 78 };

            //int Min = 0, Max = 0;

            //MinMaxArray(Arr, ref Min, ref Max);
            //Console.WriteLine($"Max Element In Array = {Max}");
            //Console.WriteLine($"Min Element In Array = {Min}");

            #endregion

            #region Q07 
            // Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write(" Enter Number ");
            //int Number = int.Parse(Console.ReadLine());

            //int Factorial = GetFactorial(Number);

            //Console.WriteLine($"Factorial For Number {Number} is {Factorial}");

            #endregion

            #region Q08 
            // Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter

            //Console.WriteLine(" Enter Word : ");
            //string Word = Console.ReadLine();

            //Console.WriteLine(" Enter Letter Change : ");
            //char Char = char.Parse(Word);

            //Console.WriteLine(" Enter position To Change : ");
            //int Pos = int.Parse(Console.ReadLine());

            //string NewWord = ChangeChar(Word, Char, Pos);

            //Console.WriteLine($"The New Word Is {NewWord}");



            #endregion

            #region Q09 **
            // Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.



            #endregion

            #region Q10 
            // Write a program in C# Sharp to find the sum of all elements of the array

            // int[] Numbers = { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 };
            // 
            // int Sum = 0;
            // 
            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     Sum += Numbers[i];
            // }
            // 
            // Console.WriteLine(" Sum Of Array = " + Sum);


            #endregion

            #region Q11 *********
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            #endregion

            #region Q12 
            //  Write a program in C# Sharp to count the frequency of each element of an array

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 1, 2, 2 };


            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] == i)
            //    {
            //        Console.WriteLine(Numbers);
            //    }
            //}





            #endregion

            #region Q13 
            // Write a program in C# Sharp to find Maximum and Minimum element in an array

            // int[] Numbers = { 52, 89, 41, 77, 17, 15 };
            // 
            // int Max = Numbers[0];
            // int Min = Numbers[0];
            // 
            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     if (Numbers[i] > Max)
            //     {
            //         Max = Numbers[i];
            //     }
            //     if (Numbers[i] < Min)
            //     {
            //         Min = Numbers[i];
            //     }
            // }

            // Console.WriteLine("The Maximum = : " + Max);
            // Console.WriteLine("The Minimum = : " + Min);

            #endregion

            #region Q14 
            // Write a program in C# Sharp to find the second largest element in an array.

            //int[] Numbers = { 52, 89, 41, 77, 17, 15 };

            //int Max = Numbers[0];
            //int SecondMax = Numbers[0];

            //for (int i = 0; i < Numbers.Length; i++) 
            //{
            //    if (Numbers[i] > Max ) 
            //    { 
            //        Max = Numbers[i];
            //    }
            //    if (SecondMax < Max)
            //    {
            //        SecondMax = Numbers[i] ;
            //    }
            //}
            //Console.WriteLine(SecondMax);


            #endregion

            #region Q15 ********
            // Consider an Array of Integer values with size N, having values as in this Example

            #endregion

            #region Q16 ******
            // 
            #endregion

            #region Q17 *******
            // Given a list of space separated words, reverse the order of the words

            #endregion

            #region Q18 
            /* Write a program to create two multidimensional arrays of same size. Accept values from 
             * the user and store them in first array. Now copy all the elements of the first array on second array and print second array */

            //Console.Write(" Enter Number Of Rows : ");
            //int Rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter Numbers Of Columns : ");
            //int Columns = int.Parse(Console.ReadLine());

            //int[,] FArray = new int[Rows, Columns];
            //int[,] SArray = new int[Rows, Columns];

            //Console.WriteLine("Enter Values Of FArray : ");

            //for (int i = 0; i < Rows; i++) 
            //{
            //    for (int j = 0; j < Columns; j++) 
            //    {
            //        Console.Write($"Elemnts Of FArray is [{i}.{j}] :");
            //        FArray[i , j ] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < Rows; i++) 
            //{
            //    for (int j = 0; j < Columns; j++) 
            //    {
            //        SArray[i,j]=FArray[i,j];
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("Elements Of SArray is:");
            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Columns; j++)
            //    {
            //        Console.Write(SArray[i , j]);
            //    }
            //}





            #endregion

            #region Q19 
            // Write a Program to Print One Dimensional Array in Reverse Order

            //int[] Numbers = { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Reverse Order Of Array : ");

            //for (int i = Numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Numbers[i] + ",");
            //}
            ///
            #endregion



        }
    }
}
