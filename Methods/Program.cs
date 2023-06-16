//Write a C# Sharp program to accept two integers and check whether they are equal or Not.




//using System.ComponentModel;

//Console.WriteLine(EqualorNot(12, 20));


//bool EqualorNot(int a, int b)
//{
//    if (a == b)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

////2)write a c # program to check whether a given no is positive or negative.

//Console.WriteLine(Positive(20));

//Console.WriteLine(" It is Positve");
//bool Positive(int a)
//{
//    if (a >= 0)
//    {
//        return true;

//    }
//    else
//    {
//        return false;
//    }
//}

////3)Write a C# Sharp program to find out whether a given year is a leap year or not.

//Console.WriteLine(LeapYear(24));

//string LeapYear(int a)
//{
//        if (a % 4 == 0)
//        {
//          return " This is Leap Year";
//        }
//        else
//        {
//            return " This is not a leap year";
//        }
//    }
////4)program to read the age of a candidate and determine whether it is eligible for casting his/her own vote
//Console.WriteLine(18);
//Console.WriteLine("Eligible for Vote");

//string AgeCrietria(int a)
//{
//    if (a <= 18)
//    {
//        return "Not Eligible for Vote";
//    }
//    else
//    {
//        return " Eligible for Vote";
//    }
//}
////5)Write a C# Sharp program to read the value of an integer m and display the value of n is 1
////when m is larger than 0, 0 whenm is 0 and -1 when m is less than 0.

//Console.WriteLine(Display(-1));

//int Display(int m)
//{
//    int n;

//    if (m > 0)
//    {
//        return n = 1;
//    }
//    else if (m == 0)
//    {
//        return n = 0;
//    }
//    else
//    {
//        return n = -1;
//    }

//}
////6)Write a program in C# Sharp to display the first 10 natural numbers.

//Console.WriteLine(NaturalNumber(Convert.ToInt32(Console.ReadLine())));
//int NaturalNumber(int a)
//{

//    for (int i = 1; i <= a; i++)
//    {
//        Console.WriteLine(i);
//    }
//    return a;
//}
////7)Write a C# Sharp program to find the sum of the first 10 natural numbers.
//Console.WriteLine("-----------------------------------------");
//Console.WriteLine("sum ot Ten natural number are");
//Console.WriteLine(SumofNumber(10));

//int SumofNumber(int a)
//{
//    int sum = 0;

//    for (int i = 1; i <= a; i++)
//    {
//        sum = sum + i;
//    }
    
//    return sum;
//}
////8)Write a C# Sharp program that displays the sum of n natural numbers.

//Console.WriteLine(SumofnNo(Convert.ToInt32(Console.ReadLine())));
//int SumofnNo(int a)
//{
//    int sum = 0;

//    for (int j = 0; j <= a; j++)
//    {
//        sum = sum + j;

//    }
//    Console.WriteLine("Sum of nos are");
//    return sum;

//}
//Console.WriteLine("...........................");
////9)Write a C# Sharp program to read 10 numbers and find their average and sum.


//Console.WriteLine(SumAvg(10));

//int SumAvg(int num)
//{
//    int sum = 0;
//    double avg = 0;
//    for (int i = 1; i <= num; i++)
//    {
//        sum=sum + i;
//        avg = avg / i;
//        Console.WriteLine(i);
//        sum += i;

//    }

   
//    Console.WriteLine(" The sum is : {0}" ,sum);
    
//    Console.WriteLine("The Avg is : {0}",avg);

    
//    return sum;
//}
////10)Write a C# Sharp program to display the cube of an integer up to given number.
//Console.WriteLine(CubeOfNum(2));
//int CubeOfNum(int num)
//{
//    int sum = 0;

//    for (int i = 1; i <= num; i++)
//    {
//        sum = i * i * i;
//        Console.Write(sum + " ");
//        Console.WriteLine();
//    }
//    return sum;
//}
////11)Write a program in C# Sharp to display the multiplication table of a given integer

////(if we dont want to return then we can use Void)
//MulofNum(2);
//void MulofNum(int num)
//{

//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine("{0} * {1} = {2}", i, num,i * num);
//    }
   

//}

////12)write a program to display the multiplication table vertically from 1 to n(8)
//MulVertically(8);
//void MulVertically(int num)
//{
//    int j;

//    for (int i = 1; i <= num; i++)
//    {
//        for (j = 1; j <= i; j++)
//        {

//            Console.Write("{0} * {1} = {2}             ", i, j, i * j);
//        }
//        Console.WriteLine();
//    }
//}
////13)Write a  program to display the n terms of odd natural numbers and their sums.

//SumofNumber(3);
//void SumofOdd(int num)
//{

//    int sum = 0;

//    //start with 1
//    //1+2 = 3
//    //3+2 = 5
//    for (int i = 1; i <= num; i += 2)
//    {
//        sum += i;
//    }
//}
////14)Write a program in C# Sharp to display a right angle triangle with an asterisk.

Astric(2);
void Astric(int rows)
{
    int i, j;

    for (i = 1; i <= rows; i++)

    {
        for (j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

    }
}
//15)Write a program to display a pattern like a right angle triangle with a number


RightAngleTriangle(3);

void RightAngleTriangle(int num)
{


    int i, j;

    

    for (i = 1; i <= num; i++)

    {
        for (j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();

    }
}
//16) Write a program to make such a pattern like a right angle triangle with a number which repeats a number in a row.
RightAngledTriangle(3);
void RightAngledTriangle(int num)
{
int col, rows;

    for (rows = 1; rows <= 5; rows++)
    {
        for (col = 1; col <= rows; col++)
        {
            Console.Write(rows);
        }
        Console.WriteLine();
    }
}
//17)Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.

Increasepattern(2);
void Increasepattern(int num)
{ }

int i, j, rows, k = 1;

Console.Write("Write any number ");
rows = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= rows; i++)
{
    for (j = 1; j <= i; j++)

        Console.Write(k++ + " ");

    Console.WriteLine();
}
//18) to calculate the factorial of a given number
//6*5*4*3*2*1=720

Factorial(2);
void Factorial(int num)
{
    int  i, fact = 1;

    Console.WriteLine("Enter any value");

    num = Convert.ToInt32(Console.ReadLine());

    for (i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    Console.WriteLine("factorial of above no is " + fact);
}














