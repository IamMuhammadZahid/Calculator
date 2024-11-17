int ValueOne;
int ValueTwo;
int Sum;
int Subtract;
int check = 0;
Console.WriteLine("Enter The First Number: ");
ValueOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Second Number: ");
ValueTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter \n 1 For Sum \n 2 For Subtraction");

check = Convert.ToInt32(Console.ReadLine());

if (check == 1)
{
    Sum = ValueOne + ValueTwo;
    Console.WriteLine("The Sum is: " + Sum);
}

else if (check == 2)
{
    Subtract = ValueOne - ValueTwo;
    Console.WriteLine("The Subtract is: " + Subtract);
}
else
{
    Console.WriteLine("Invalid Input ");
}