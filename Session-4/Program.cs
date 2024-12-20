namespace Session_4
{


    // 1- Class         -> Functions 
    // 2- Struct        -> Functions 
    // 3- Interfaces    -> Functions 
    // 4- Enum 


    // class NewData
    // {
    //     public int Sum;
    //     public int Mul;
    // 
    // }




    internal class Program
    {


        // static void SWAP(int x, int y)
        // {
        //     int Temp = x;
        //     x = y;
        //     y = Temp;
        // }
        //

        // static void SWAP(ref int x, ref int y)
        // {
        //     int Temp = x;
        //     x = y;
        //     y = Temp;
        // }
        // 

        // static int SumArray(int[] Arr)
        // {
        //     int Sum = 0;
        // 
        //     Arr[0] = 100;
        // 
        //     for (int i = 0; i < Arr.Length; i++)
        //     {
        //         Sum += Arr[i];
        //     }
        //     return Sum;
        // }
        //

        // static int SumArray(ref int[] Arr)
        // {
        //     int Sum = 0;
        // 
        //     Arr[0] = 100;
        // 
        //     for (int i = 0; i < Arr.Length; i++)
        //     {
        //         Sum += Arr[i];
        //     }
        //     return Sum;
        // }
        //

        // static int SumArray( int[] Arr)
        // {
        //     int Sum = 0;
        // 
        //     Arr = new int[] { 4, 5, 6 };
        // 
        //     for (int i = 0; i < Arr.Length; i++)
        //     {
        //         Sum += Arr[i];
        //     }
        //     return Sum;
        // }
        //

        // static int SumArray(ref int[] Arr)
        // {
        //     int Sum = 0;
        // 
        //     Arr = new int[] { 4, 5, 6 };
        // 
        //     for (int i = 0; i < Arr.Length; i++)
        //     {
        //         Sum += Arr[i];
        //     }
        //     return Sum;
        // }
        //

        // static int[] SumNum(int X, int Y)
        // { 
        //     int [] result = {X+Y ,X*Y};
        //     return result;
        //     
        // }
        //

        // static NewData SumNum(int X, int Y)
        // {
        //     NewData data = new NewData();
        //     data.Sum = X + Y;
        //     data.Mul = X * Y;
        // 
        //     return data;
        // }
        //

        // static void SumNum(int X, int Y, out int Sum, out int Mul)
        // {
        //     Sum = X + Y;
        //     Mul = X * Y;
        // }
        // 

        // static int SumArray(params int[] Arr)
        // {
        //     int sum = 0;
        //     for (int i = 0; i < Arr.Length; i++)
        //     {
        //         sum += Arr[i];
        //     }
        //     return sum;
        // }


        // Entry Point 
        static void Main()
        {

            #region One D Array 
            // int[] Numbers;
            // Declare for reference (Pointer) from type 'Array of integers'
            // Numbers : Can refer to object from type 'Array of Integers'
            // Numbers : Refer to Null 

            // 8 Bytes Wil be Allocated At stack for the reference 'Numbers'
            // 8 Bytes Wil be Allocated At HEAP

            // Numbers = new int[Size];

            // Numbers = new int[5];

            // New : 
            // 1- Allocate The Number Of Required Bytes For The Object At HEAP ( 4 Bytes * 5 ) 
            // 2- Initialized The Allocated Bytes With The Default Value Of The DataTypes 
            // 3- Call User-Defined Constructor if Exists 
            // 4- Assign The Object To The Reference 'Numbers'

            // Numbers[0] = 12;
            // Numbers[1] = 6;
            // Numbers[2] = 7;
            // Numbers[3] = 11;
            // Numbers[4] = 19;
            // Numbers[5] = 20; ==> Out Of Range 

            // Console.WriteLine(Numbers[0]);
            // Console.WriteLine(Numbers[1]);
            // Console.WriteLine(Numbers[2]);
            // Console.WriteLine(Numbers[3]);
            // Console.WriteLine(Numbers[4]);

            // int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            // int[] Numbers02 = new int[4] { 1, 2, 3, 4 };
            // int[] Numbers03 = new int[6] { 1, 2, 3, 4, 0, 0 };
            // int[] Numbers04 = new int[6];


            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     Console.Write($"Enter Numbers [{i}] : ");
            //     Numbers[i] = int.Parse( Console.ReadLine() );
            // }
            // 
            // Console.WriteLine("-------------------");
            // 
            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     Console.Write($"{Numbers [i]}");
            // }

            // One D Array 

            // Console.WriteLine(Numbers.Length); // ----> Size [5]
            // Console.WriteLine(Numbers.Rank);   // ----> Dimension [1] --> One Dimension
            // Console.WriteLine(Numbers);        // ----> System.Int32[] 
            #endregion

            #region Tow D Array 
            // Tow D Array 

            // int[,] Marks = new int[3, 3];

            // Marks[0, 0] = 99;
            // Marks[0, 1] = 99;
            // Marks[0, 2] = 99;
            // 
            // Marks[1, 0] = 88;
            // Marks[1, 1] = 78;
            // Marks[1, 2] = 48;
            // 
            // Marks[2, 0] = 86;
            // Marks[2, 1] = 72;
            // Marks[2, 2] = 43;
            // 
            // Console.WriteLine(Marks[0, 0]);
            // Console.WriteLine(Marks[0, 1]);
            // Console.WriteLine(Marks[0, 2]);
            // 
            // Console.WriteLine(Marks[1, 0]);
            // Console.WriteLine(Marks[1, 1]);
            // Console.WriteLine(Marks[1, 2]);
            // 
            // Console.WriteLine(Marks[2, 0]);
            // Console.WriteLine(Marks[2, 1]);
            // Console.WriteLine(Marks[2, 2]);


            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.Write($"Enter Marks[{i},{j}] : ");
            //         Marks[i, j] = int.Parse( Console.ReadLine() );
            //     }
            // }
            // 
            // Console.WriteLine("---------------------");
            // 
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.Write($"{ Marks[i,j]} ");
            //         
            //     }
            //     Console.WriteLine();
            // }

            #endregion

            #region Two D Array - Juddge 
            // int[][] Markes = new int[3][];
            // 
            // Markes[0] = new int[] { 1, 2, 3 };
            // Markes[1] = new int[] { 1, 2 };
            // Markes[1] = new int[] { 1, 2, 3, 4 };

            ///-----------------------------------------

            // int[][] Markes = new int[3][];
            // 
            // Markes[0] = new int[2];
            // Markes[1] = new int[5];
            // Markes[2] = new int[1];
            // 
            // for (int i = 0; i < 3; i++) 
            // {
            //     for (int j = 0; j< Markes[i].Length; j++) 
            //     {
            //         Console.Write($"Markes[{i},{j}]");
            //         Markes [i][j] = int.Parse(Console.ReadLine());
            //     }
            // }
            // 
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < Markes[i].Length; j++)
            //     {
            //         Console.WriteLine($"{Markes[i][j]}");
            //     }
            // } 
            #endregion

            #region Passing Parameter Value Type 
            // Passing by value
            // Passing by reference 

            // Passing Paremeter Value type :

            // 1- Passing by value

            // int A = 4;
            // int B = 5;
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"B : {B}");
            // 
            // Console.WriteLine("----AFTR SWAP--------");
            // 
            // SWAP (4,5); // --> Passing By Value 
            // SWAP (A, B); // --> Passing By Value 
            // 
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"B : {B}");



            // 2- Passing by reference 

            // int A = 4;
            // int B = 5;
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"B : {B}");
            // 
            // Console.WriteLine("----AFTR SWAP--------");
            // 
            // // SWAP(A,B); // --> Passing By ref 
            // SWAP(ref A,ref B); // --> Passing By ref 
            // 
            // Console.WriteLine($"A : {A}");
            // Console.WriteLine($"B : {B}"); 
            #endregion

            #region Passing Parameter Reference Type
            // Passing Parameter Reference Type :
            // 
            // 1- Passing By Value :

            //int[] Numbers = { 1, 2, 3 };
            //
            //int Result = SumArray(Numbers);
            //Console.WriteLine(Result);
            //
            //Console.WriteLine(Numbers[0]);



            // 2- Passing By Ref

            // int[] Numbers = { 1, 2, 3 };
            // 
            // int Result = SumArray(ref Numbers); // The Address Of The Numbers 
            // 
            // Console.WriteLine(Result);
            // 
            // Console.WriteLine(Numbers[0]); 
            #endregion

            #region Passing Parameter Reference Type 
            // Passing Parameter Reference Type 

            // int[] Numbers = { 1, 2, 3 };
            // 
            // Console.WriteLine(SumArray(Numbers));  // ----> Passing By Value  
            // Console.WriteLine(Numbers[0]);
            //

            // int[] Numbers = { 1, 2, 3 };
            // 
            // Console.WriteLine(SumArray(ref Numbers)); // ----> Passing By Ref  
            // // Copy Of Numbers 
            // Console.WriteLine(Numbers[0]); 
            #endregion

            #region Passing By Out 
            // int A = 3; int B = 5;
            // 
            // int[] Result = SumNum(A, B);
            // 
            // Console.WriteLine(Result[0]);
            // Console.WriteLine(Result[1]);


            // int A = 3; int B = 5;
            // 
            // NewData Result = SumNum(A, B);
            // 
            // Console.WriteLine(Result.Sum);
            // Console.WriteLine(Result.Mul);


            // OutPut Parameters 

            // Passing By Out 

            // int A = 4, B = 5 , Sum , Mul;
            // 
            // SumNum (B, A , out Sum , out Mul);
            // 
            // Console.WriteLine(Sum);
            // Console.WriteLine(Mul); 
            #endregion

            #region Params
            // Params 

            // int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            // 
            // Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13)); 
            #endregion

        }
    }
}
