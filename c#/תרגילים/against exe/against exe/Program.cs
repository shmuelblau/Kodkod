
List<string> houseslist = new List<string>();

Dictionary<string,string> attackHousesDict = new Dictionary<string,string>();

string[] Weapons = new string[] { "Rocket", "Drone", "Tank" };

Random rand = new Random();
int size = rand.Next(10,20);

for (int i = 0; i <size; i++)
{
    houseslist.Add($"{rand.Next(100000,999999)}:{rand.Next(100000, 999999)}");
}




int num;

while (true)
{
    Console.WriteLine($"enter num (max {size}):");
    string input = Console.ReadLine();

    if (int.TryParse(input, out num) && num <= size)
        break;

    Console.WriteLine("Invalid input. Try again.");
}






for (int i = 0;i < num; i++)
{
    int x = rand.Next(0,houseslist.Count);
    string h = houseslist[x];
    houseslist.Remove(h);
    attackHousesDict.Add(h, Weapons[x%3]);
}

foreach (var hous in attackHousesDict)
{
    Console.WriteLine($"hous : {hous.Key} by : {hous.Value}");
}


