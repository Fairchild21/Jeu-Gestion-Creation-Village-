// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

System.Console.WriteLine(House.wood_needed);
System.Console.WriteLine(House.villageois);

Village myVillage = new Village("Guéno le créateur");
myVillage.getName();
System.Console.WriteLine(myVillage.getName());
System.Console.WriteLine(myVillage.listHouse.Length);
myVillage.addHouse(new House());
myVillage.addHouse(new House());
System.Console.WriteLine(myVillage.listHouse.Length);

System.Console.WriteLine(myVillage.villageois);