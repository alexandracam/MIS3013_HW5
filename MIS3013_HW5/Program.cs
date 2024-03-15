// MIS 3013


using System.ComponentModel;

DeveloperInformation("xinglong ju", "MIS 3013 HW5");

string userChoiceStr;
string menuStr = GetMenu();
do
{
    Console.WriteLine(menuStr);
    Console.Write("Enter option: ");
    userChoiceStr = Console.ReadLine();
    if (userChoiceStr == "1")
    {
        Console.WriteLine("\nAdd");
        Console.Write("Enter the first number: ");
        string num1Str = Console.ReadLine();
        double num1 = Convert.ToDouble(num1Str);

        Console.Write("Enter the second number: ");
        string num2Str = Console.ReadLine();
        double num2 = Convert.ToDouble(num2Str);

       double r = Add(num1, num2);

        string outMesStr = string.Format($"{num1:F2}+{num2:F2}={r:F2}");
        Console.WriteLine(outMesStr);
    }
    else if (userChoiceStr == "2")
    {
        Console.WriteLine("\nSubtract");
        Console.Write("Enter the first number: ");
        string num1Str = Console.ReadLine();
        double num1 = Convert.ToDouble(num1Str);

        Console.Write("Enter the second number: ");
        string num2Str = Console.ReadLine();
        double num2 = Convert.ToDouble(num2Str);

        double r = Subtract(num1, num2);

        string outMesStr = string.Format($"{num1:F2}-{num2:F2}={r:F2}");
        Console.WriteLine(outMesStr);
    }
    else if (userChoiceStr == "3")
    {
        Console.WriteLine("\nMultiply");
        Console.Write("Enter the first number: ");
        string num1Str = Console.ReadLine();
        double num1 = Convert.ToDouble(num1Str);

        Console.Write("Enter the second number: ");
        string num2Str = Console.ReadLine();
        double num2 = Convert.ToDouble(num2Str);

        double r = Multiply(num1, num2);

        string outMesStr = string.Format($"{num1:F2}*{num2:F2}={r:F2}");
        Console.WriteLine(outMesStr);
    }
    else if (userChoiceStr == "4")
    {
        Console.WriteLine("\nDivide");
        Console.Write("Enter the first number: ");
        string num1Str = Console.ReadLine();
        double num1 = Convert.ToDouble(num1Str);

        Console.Write("Enter the second number: ");
        string num2Str = Console.ReadLine();
        double num2 = Convert.ToDouble(num2Str);

        double r = Divide(num1, num2);

        string outMesStr = string.Format($"{num1:F2}/{num2:F2}={r:F2}");
        Console.WriteLine(outMesStr);
    }
    else if (userChoiceStr == "5")
    {
        Console.WriteLine("\nFactorial");
        Console.Write("Enter the number: ");
        string num1Str = Console.ReadLine();
        int num1 = Convert.ToInt32(num1Str);

        int r = Factorial(num1);
        string outMesStr = string.Format($"{num1}!=");
        Console.Write(outMesStr);

        for (int i = 1; i <= num1; i++)
        {
            Console.Write(i);
            if (i < num1)// if i is not the last number
            {
                Console.Write("*");
            }
        }
        Console.Write("=");
        Console.WriteLine(r);
    }
    else if (userChoiceStr == "6")
    {
        Console.WriteLine("\nRaise Power");
        Console.Write("Enter the base number: ");
        string num1Str = Console.ReadLine();
        int b = Convert.ToInt32(num1Str);

        Console.Write("Enter the degree number: ");
        string num2Str = Console.ReadLine();
        int d = Convert.ToInt32(num2Str);

        int r = RaisePower(b, d);

        string outMesStr = string.Format($"{b}^{d}={r}");
        Console.WriteLine(outMesStr);
    }
}
while (userChoiceStr == "1"|| userChoiceStr == "2"|| userChoiceStr == "3" || userChoiceStr == "4" || userChoiceStr == "5" || userChoiceStr == "6");

Console.WriteLine("Thank you and goodbye!");

Console.ReadKey();

double Add(double d1, double d2)
{ 
    return d1 + d2;
}

double Subtract(double d1, double d2)
{
    double r = d1 - d2;
    return r;
}

double Multiply(double d1, double d2)
{ 
    double r = d1 * d2;
    return r;
}
double Divide(double d1, double d2)
{
    double r = d1 / d2;
    return r;
}

int Factorial(int n)
{
    int r = 1;
    for (int i = 1; i <= n; i++)
    {
        r = r * i;
    }
    return r;
}

int RaisePower(int b, int d)
{
    int r = 1;

    for (int i = 1; i <= d; i++)
    {
        r = r * b;
    }
    return r;
}


string GetMenu()
{
    string rStr = "";
    rStr = string.Format($"{rStr}1.Add\n");
    rStr = string.Format($"{rStr}2.Subtract\n");
    rStr = string.Format($"{rStr}3.Multiply\n");
    rStr = string.Format($"{rStr}4.Divide\n");
    rStr = string.Format($"{rStr}5.Factorial\n");
    rStr = string.Format($"{rStr}6.RaisePower\n");
    rStr = string.Format($"{rStr}Press other keys to exit\n");

    //rStr = "1.Add\n2.Subtract\n;
    return rStr;
}
void DeveloperInformation(string name, string classStr)
{
    //Developer: Xinglong Ju for class MIS 3013 HW5
    string mesOutStr = string.Format($"Developer: {name} for class {classStr}");
    Console.WriteLine(mesOutStr);
}