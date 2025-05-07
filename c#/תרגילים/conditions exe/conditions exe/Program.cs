// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1 
Console.WriteLine(int.Parse(Console.ReadLine()) > 0 ? "pos" : "neg");

//2
Console.WriteLine("enter num");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter num");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(num2>num1 ? num2 :num1);

//3

Console.WriteLine("enter num");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine(num3 > 90 ? "מצוין" : num3 < 75 ? "צריך להשתפר " : "טוב מאוד");

//4
Console.WriteLine("enter day");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("יום ראשון");
        break;
    case 2:
        Console.WriteLine("יום שני");
        break;
    case 3:
        Console.WriteLine("יום שלישי");
        break;
    case 4:
        Console.WriteLine("יום רביעי");
        break;
    case 5:
        Console.WriteLine("יום חמישי");
        break;
    case 6:
        Console.WriteLine("יום שישי");
        break;
    case 7:
        Console.WriteLine("שבת");
        break;
}

//5

Console.WriteLine("enter num");
int num5 = int.Parse(Console.ReadLine());
Console.WriteLine(num5 > 90 ? "חם" : num5 < 75 ? " קר " : "נעים ");

//6

Console.WriteLine("enter num");
int num6 = int.Parse(Console.ReadLine());
Console.WriteLine(num6 > 17 ? "יכול" :  "לא יכול ");

//7

Console.WriteLine("enter num");
char num7 = char.Parse(Console.ReadLine());
Console.WriteLine(num7 %2 == 0 ? "זוג" : "פרד  ");
//8

Console.WriteLine("enter letter");
string str = Console.ReadLine();
Console.WriteLine('a' >= str[0]  && str[0] <= 'z' ? "קטן" : 'A' >= str[0] && str[0] <= 'Z' ?  "גדול" : "זה לא אות");

//9

Console.WriteLine("enter num");
int num8 = int.Parse(Console.ReadLine());
Console.WriteLine(num8 < 100 ? num8 : num3 > 500  ? num8 - (num8/10) : num8 - (num8 / 20));

// 10

Console.WriteLine("enter num 1 - התחבר\r\n2 - הירשם\r\n3 - יציאה");
int num9 = int.Parse(Console.ReadLine());
switch (num9)
{
    case 1:
        Console.WriteLine("התחברת בהצלחה ");
        break;
    case 2:
        Console.WriteLine("נרשמת בהצלחה ");
        break;
    case 3:
        Console.WriteLine("יצאת");
        break;
}
// 11
Console.WriteLine("enter num");
int num10 =2025 - int.Parse(Console.ReadLine());
Console.WriteLine(num10 > 17 ? "מבוגר" : num10 < 13 ? " ילד " : "נער ");

//12
Console.WriteLine("enter 3 nums");
int num11 = int.Parse(Console.ReadLine());
int num12 = int.Parse(Console.ReadLine());
int num13 = int.Parse(Console.ReadLine());
if (num11 > num12)
{
    if (num11 > num13) { Console.WriteLine(num11); }
    else { Console.WriteLine(num13); }

}
else if (num12 > num13)
    Console.WriteLine(num12);
else { Console.WriteLine(num13); }


//13


Console.WriteLine("enter num");
int num14 = int.Parse(Console.ReadLine());
Console.WriteLine(num14 % 3 == 0 ?  num14 %5 == 0 ? "FizzBuzz" : "Fizz" : "Buzz");

//17

string password = "1234";
string name = "abcd";

Console.WriteLine("enter letter");
string password1 = Console.ReadLine();
Console.WriteLine("enter letter");
string name1 = Console.ReadLine();

Console.WriteLine(password == password1 && name == name1 ? "ברוך הבא" : "פרטי התחברות שגויים");

// 18

Console.WriteLine("enter num");
double num15 = double.Parse(Console.ReadLine());
Console.WriteLine(num15 % 1.0 == 0 ? num15 > 0 ? "חיובי" : "שלילי" : "לא מספר שלם");

//19
Console.WriteLine("enter str");
string str12 = Console.ReadLine();
Console.WriteLine(str[0] == 'a' || str[0] == 'A' ? "מתחיל בA" : "לא מתחיל בA");

//20

Console.WriteLine("enter num");
int num81 = int.Parse(Console.ReadLine());
Console.WriteLine(num81<300 ? "רמה מתחילה" : num81 > 701 ? "רמה מתקדמת":"רמה בינונית");