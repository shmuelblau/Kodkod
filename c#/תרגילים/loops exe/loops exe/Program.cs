
// 1

using System.Threading.Channels;

for (int i = 0; i<6; i++) {
    Console.WriteLine(i);
    }



//2
int i1 = 2;
while (i1 < 11)
{
    Console.WriteLine(i1);
    i1 += 2;
}

//3
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num > 0 ? "יובי" : "שלילי");

//4

while (true) {
    string str = Console.ReadLine();
    if (str == "סיום") {  break; }
}

//5

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("גישה מורשת");
}



//6
for (int i = 1; i < 21; i++)
{
    if (i % 3 != 0)
    { Console.WriteLine(i); }
}

//7

int num1 = 5;
while (num1 > 0)
{
    Console.WriteLine(num1);
    num1--;
}

// 8

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i % 2 == 0 ? "זןגי": "איזוגי");
}

//9

string str1 = Console.ReadLine();
Console.WriteLine(str1 == "8200"? "בטוח" : "");

//10
string str2;

do
{
    str2 = Console.ReadLine();
}
while (str2 != "admin");

//11

int sum = 0;    

for (int i = 0;i < 101; i++)

{
    if (i % 7 == 0) { sum++; }
}
Console.WriteLine(sum);

//12

string str3 = Console.ReadLine();
Console.WriteLine(str3.Length == 8 ? "yes" : "no" );

//13
string str4 = Console.ReadLine();

for (int i = 0; i <str4.Length; i++)
{
    if (str4[i] > 'Z' && str4[i] > 'a') { Console.WriteLine(str4[i]); }

}

//14

string str5;

do
{
    str5 = Console.ReadLine();
}
while (str5.Length <8);

//15

for (int i = 0; ; i++)
{
    bool b = false;
    for (int j = 0; j < i; j++)
    {
        if (j % j == 0)
        {
            b = true;
            break;
        }
    }
    Console.WriteLine(b ? "לא ראשוני":"ראשוני");
}

//16
bool b1 = false;

string str6;

for (int i = 0; i < 3; i++)
{
    str6 = Console.ReadLine();
    b1 = str6 == "123456";
    if (b1) { break; }
}
Console.WriteLine(b1 ? "נכנסת בהצלחה ":"גישה נדחתה");

//17

int sum3 = 0;

string str7 = Console.ReadLine();


for (int i = 0; i < str7.Length; i++)

{
    if (str7[i]<='9' && str7[i] >= '0') { sum3++; }
}
Console.WriteLine(sum3);

//18

for (int i = 1; i < 50; i++)
{
    if ((i % 10) == 0) { Console.WriteLine(); }
}

//19

int sum4 = 0;
int num5 = int.Parse(Console.ReadLine());
while (num5 > 0)
{
    sum4 += num5;
    num5 = int.Parse(Console.ReadLine());
}
Console.WriteLine(sum4);

//20

string pass = Console.ReadLine();


for (int i = 0;i < pass.Length-1; i++)
{
    Console.WriteLine(pass[i]);
    pass = pass[0..i] + "*" + pass[(i + 1)..];
}
pass = pass[0..pass.Length] + "*";


// 21
string pass1 = "12334";
string name1 = "shmuel";
string pass2;
string name2;

while (true)
{
    Console.WriteLine("הקלד שם וסיסמא");
    pass2 = Console.ReadLine();
    name2 = Console.ReadLine();

    if (pass1 == pass2 && name1== name2)
    {
        Console.WriteLine("התחברת בהצלחה");
        break;
    }

}

//22
Random rand = new Random();
string pass3 = "";

for (int i = 0; i < 6; i++)
{
    pass3 += rand.Next(0, 10);
}

//23
string pass9 = Console.ReadLine();

bool b3 , b4= false;

for (int i = 0;i < pass9.Length; i++)
{
    if (char.IsDigit(pass9[i]))
    {
        b3 = true;
        break;
    }
    else if (char.IsLetter(pass9[i]))
    {
        b3 = true;
        break;
    }

}
Console.WriteLine(b4 && b3 ? "yes": "no");

//24
string pass8 = Console.ReadLine();


for (int i = 0; i < pass8.Length - 1; i++)
{
    if (char.IsDigit(pass8[i]))
        pass8 = pass8[0..i] + "digit" + pass8[(i +1)..];


    
}
if (char.IsDigit(pass8[^1]))
    pass8 = pass8[0..^1] + "digit";


//25

string pass10= Console.ReadLine();
char[] str8 = { '8', '2', '0' };
bool b6 = false;
for (int i = 0; i < pass10.Length; i++)
{
    if (str8.Contains(pass10[i])){
        b6 = true;
        break;
    }
}
Console.WriteLine(b6 ? "מופיע":"לא מופיע");

//26
string pass11 = Console.ReadLine();
int sum10 = 0;

for (int i = 0;i < pass11.Length; i++)
{
    if ('a'==pass11[i])
    {
        sum10++;
    }
}
Console.WriteLine(sum10);

//27

