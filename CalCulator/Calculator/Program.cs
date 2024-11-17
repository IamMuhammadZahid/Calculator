int ValueOne;
int ValueTwo;
int Sum;
int Subtract;
int Multiply;
float Divide;
int check;
Console.WriteLine("Enter The First Number: ");
ValueOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Second Number: ");
ValueTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter \n 1 For Sum \n 2 For Subtraction \n 3 For Multiplication \n 4 For Division");

check = Convert.ToInt32(Console.ReadLine());

switch (check)
{
    case 1:
        Sum = ValueOne + ValueTwo;
        Console.WriteLine("The Sum is: " + Sum);
        break;
    case 2:
        Subtract = ValueOne - ValueTwo;
        Console.WriteLine("The Subtract is: " + Subtract);
        break;
    case 3:
        Multiply = ValueOne * ValueTwo;
        Console.WriteLine("The Multiply is: " + Multiply);
        break;
    case 4:
        Divide = (float)ValueOne / ValueTwo;
        Console.WriteLine("The Divide is: " + Divide);
        break;
    default:
        Console.WriteLine("Invalid Input ");
        break;
        
}
