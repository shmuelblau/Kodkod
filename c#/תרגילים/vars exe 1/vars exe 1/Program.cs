// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 26
int x = 5;

//27
string name = "shmuel";
Console.WriteLine(name);

//28

int x2 = 5;
int y = 5;
int z = x2 + y;

// 29

double x3 = 5.6;
double y3 = 6.5;
Console.WriteLine((x3+y3)/2);

//30

Console.WriteLine("enter blas to the borthdey");
string name2 =Console.ReadLine();
Console.WriteLine(name2.Length);

//31

Console.WriteLine("enter name");
string name3 = Console.ReadLine();

Console.WriteLine("enter age");
string age = Console.ReadLine();

Console.WriteLine($"hello {name3} in mor 5 yeres you by {int.Parse(age)+5}yeres old");

//32 
Console.WriteLine("enter str");
string str = Console.ReadLine();
Console.WriteLine("enter num");
int num = int.Parse(Console.ReadLine());
for  (int i = 0; i < num; i++)
{
    Console.Write(str);
}

//33
Console.WriteLine("enter num");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter num");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("enter num");
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine((num1+num2+num3)/3);

//34

Console.WriteLine("enter str");
string str1 = Console.ReadLine();

Console.WriteLine(str1.ToUpper());

//35
Console.WriteLine("enter age");
int num5 = int.Parse(Console.ReadLine());
Console.WriteLine(num5>18 ? "מותר" : " אסור");


//36

Console.WriteLine("enter str");
string str4 = Console.ReadLine();
int num4 = int.Parse(str4);
Console.WriteLine(num4);

//37

Console.WriteLine("enter str");
string str5 = Console.ReadLine();

Console.WriteLine("enter str");
string str6= Console.ReadLine();

Console.WriteLine( str6==str5 ? "שווה" : " לא שווה");

//38

 static bool exe38(string str , string str1)
{
    return str == str1;
}

//39

Console.WriteLine("enter name");
string str7 = Console.ReadLine();

Console.WriteLine(str7[0] == 'A' ? "כן" : " לא ");

// 40

Console.WriteLine("enter num");
int num8 = int.Parse(Console.ReadLine());
Console.WriteLine(num8 * num8);

//41

Console.WriteLine("enter num");
int num9 = int.Parse(Console.ReadLine());
Console.WriteLine($"sm:{num9} inth:{num9 / 2.54}");

//42 

string str10 = Console.ReadLine();
Console.WriteLine(int.TryParse(str10, out int number) ? "כן" : "לא");


//43

Console.WriteLine("enter num");
int num10 = int.Parse(Console.ReadLine());

Console.WriteLine("enter num");
int num11 = int.Parse(Console.ReadLine());


Console.WriteLine("enter shepe");
string str12 = Console.ReadLine();

Console.WriteLine(str12 == "מלבן" ? num10*num11:"");
Console.WriteLine(str12 == "משולש" ? num10 * num11/2 : "");

//44

Console.WriteLine("enter full name");
string str13 = Console.ReadLine();
Console.WriteLine(str13.Split()[1]);

//45

Console.WriteLine("enter num");
int num14 = int.Parse(Console.ReadLine());

Console.WriteLine((int)Math.Sqrt(num14) * (int)Math.Sqrt(num14) == num14 ? "yesss": "noooo");
