// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*System.Console.WriteLine(House.wood_needed);
System.Console.WriteLine(House.villageois);

Village myVillage = new Village("Guéno le créateur");
myVillage.getName();
System.Console.WriteLine(myVillage.getName());
System.Console.WriteLine(myVillage.listHouse.Length);

// myVillage.addHouse(new House());
// myVillage.addHouse(new House());
System.Console.WriteLine(myVillage.listHouse.Length);
System.Console.WriteLine(myVillage.villageois);

Console.WriteLine(Mine.gain_stone); // affichera 10
Console.WriteLine(Mine.stone_cost); // affichera 2
Console.WriteLine(Mine.wood_cost); // affichera 1
*/

Village myVillage = new Village("Victor le createur");
myVillage.mineStone(50); // Affichera: Il n'y a pas assez de villageois
Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood());// Affichera 10
myVillage.mineStone(6); // Affichera : Il n'y a pas assez de ressources
Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood()); // Affichera 10
myVillage.mineStone(5);myVillage.mineStone(5);
Console.WriteLine(myVillage.getStone()); // Affichera 90
Console.WriteLine(myVillage.getWood()); // Affichera 0
myVillage.mineStone(5); // Affichera : Il n'y a pas assez de ressources