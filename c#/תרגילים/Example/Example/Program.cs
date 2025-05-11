//1


bool IsValidAge(int age)

{
    
    return age > 17 && age < 66;
}

bool IsValidAge1(int age)
{
    return age > -1 && age <121 ;
}

//2

string FormatName(string firstName, string lastName)
{
    if (firstName == "" || lastName == "")
    {
        return "Invalid input";
    }
    return firstName + "," + lastName;
}

//3

bool IsStrongPassword(string password)
{
    bool len = password.Length > 7;
    bool big = false;
    bool digit = false;
    foreach (char c in password)
    {
        if (char.IsDigit(c))
        {
            digit = true;
        }

        if (char.IsUpper(c))
        {
            big = true;
        }
    }

    return big && len && digit;
}

//4

int SumIfEven(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {

        if (number % 2 == 0) { sum += number; }
    }
    return sum;
}

//5


