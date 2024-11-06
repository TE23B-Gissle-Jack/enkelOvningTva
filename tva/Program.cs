string[] lekia = ["vatten pistol", "hot wheels", "barbie", "bus light year", "woodie"];
string[] namn = ["Andy", "Bert", "Karl", "Carl", "Max"];
int[] betyg = [1,5,7,9,10];
for(int i = 0; i < 10; i++) 
{
    Console.WriteLine($"{namn[Random.Shared.Next(5)]} ger {lekia[Random.Shared.Next(5)]} betyget {betyg[Random.Shared.Next(5)]}");

}

List<string> cities = [];
string awns = "";
while(awns != "exit")
{
    awns = Console.ReadLine().ToLower();
    if(awns != "exit")
    {
        cities.Add(awns);
    }
}
foreach(string name in cities)
{
    Console.WriteLine(name);
}
Console.ReadLine();
