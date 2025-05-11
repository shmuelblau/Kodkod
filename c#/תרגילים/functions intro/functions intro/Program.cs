//1


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

bool IsValidAge(int age)

{

    return age > 17 && age < 66;
}

bool IsValidAge1(int age)
{
    return age > -1 && age < 121;
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

string GetLongestWord(List<string> words){

    int[] len = words.Select(word => word.Length).ToArray();
    int big = len.Max();
    string word = words.Find(word => word.Length == big);

    return word;

    
}


//Military Logistics Software
Random rand = new Random();

int fuel = rand.Next(100,400);

int totalDistance = 0;

string lastBase = "";

int lastSupplies = 0;

void StartMission(string baseName, int distance, int supplies) 
{
    if (distance * 2 > fuel)
    {
        Console.WriteLine("Not enough fuel for the mission");
    }
    else 
    {
        fuel -= distance * 2; 
        lastBase = baseName;
        lastSupplies = supplies;
    
    }

}

void EndMission(int distance) 
{
    
    totalDistance += distance;
    Console.WriteLine($"Delivered {lastSupplies} boxes to {lastBase}");

}

void Refuel(int amount) 
{
    if (amount + fuel > 400 || fuel- amount <0)
    {
        Console.WriteLine("Invalid fuel amount");
    }
    else { 
        fuel += amount;
    }

}

void ShowStatus() {
    Console.WriteLine($"Total distance: {totalDistance} \r\n Remaining fuel: {fuel} \r\n Last mission:\r\n     lastBase: {lastBase} \r\n     lastSupplies : {lastSupplies} ");

}


// הפעלה
StartMission("Base Echo" , 20, 4);
EndMission(20);
Refuel(30);
ShowStatus();
