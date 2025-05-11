
//1

List <string> names = new List<string> { "shmuel", "avi", "devid", "moshe","ari"};
names.Add("yethchak");
names.Add("yakov");

names.Remove("yethchak");
names.RemoveAt(0);

foreach (string name in names)
{
    Console.WriteLine($"{names.IndexOf(name)} . {name}");

}

//2
Dictionary<string ,int> dict = new Dictionary<string, int>
{
    {"woter",3 },
    {"milk",6 },
    {"brade",5 }
};

dict["milk"] += 1;

foreach (var name in dict)
{
    Console.WriteLine($"{name.Key} : {name.Value}");
}

//3

List<Dictionary<string, string>> exe3 = new List<Dictionary<string, string>>();

Dictionary<string,string> p1 = new Dictionary<string, string>
{
    {"name" , "shmuel" },
    {"email" , "gdsg@gmail.com" },
    {"status" , "singel" }
};

Dictionary<string, string> p2 = new Dictionary<string, string>
{
    {"name" , "moshe" },
    {"email" , "eee@gmail.com" },
    {"status" , "singel" }
};

exe3.Add(p1);
exe3.Add(p2);

foreach (var person in exe3)
{
    Console.WriteLine($"{person["name"]} : {person["email"]} :{person["status"]} ");
}

//4

List<string> namesList = new List<string>
{
    "shmuel","moshe","david"
};

Console.WriteLine("enter name");
string name1 = Console.ReadLine();

int ind = namesList.IndexOf(name1);
Console.WriteLine(ind > -1 ? $"index : {ind}" : "Username not registered");

//5

Dictionary<string , List<string>> soldiers = new Dictionary<string , List<string>>();

soldiers["shmuel"] = new List<string> { "recorder" ,"map" , "notebook" };
soldiers["david"] = new List<string> { "recorder" ,"map" , "notebook" };
soldiers["moshe"] = new List<string> { "recorder" ,"map" , "notebook" };

foreach (var soldier in soldiers)
{
    Console.WriteLine(soldier.Value.Count >2 ? $"{soldier.Key} is ready for intel work"  : $"{soldier.Key} is missing tools ");}