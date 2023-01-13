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

/*Village myVillage = new Village("Guéno le createur");
myVillage.mineStone(50); // Affichera: Il n'y a pas assez de villageois
Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood());// Affichera 10
myVillage.mineStone(6); // Affichera : Il n'y a pas assez de ressources
Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood()); // Affichera 10
myVillage.mineStone(5);myVillage.mineStone(5);
Console.WriteLine(myVillage.getStone()); // Affichera 90
Console.WriteLine(myVillage.getWood()); // Affichera 0
myVillage.mineStone(5); // Affichera : Il n'y a pas assez de ressources*/


// Console.WriteLine(Forest.gain_wood); //affichera 10
// Console.WriteLine(Forest.stone_cost); //affichera 2
// Console.WriteLine(Forest.wood_cost); //affichera 1
// Forest test = new Forest();


// Village myVillage = new Village("Guéno le createur");
// myVillage.cutWood(50); // affichera Il n'y a pas assez de villageois
// Console.WriteLine(myVillage.getStone()); // afficher 10
// Console.WriteLine(myVillage.getWood()); // afficher 10
// myVillage.cutWood(6); // affichera Il n'y a pas assez de ressource
// Console.WriteLine(myVillage.getStone()); // afficher 10
// Console.WriteLine(myVillage.getWood()); // afficher 10
// myVillage.cutWood(5);myVillage.cutWood(5); // affichera Il n'y a pas assez de ressource
// Console.WriteLine(myVillage.getStone()); // afficher 0
// Console.WriteLine(myVillage.getWood()); // afficher 55
// myVillage.cutWood(5); // affichera Il n'y a pas assez de ressource

Village myVillage = new Village("Guéno le createur");
Console.WriteLine(myVillage.getName());
myVillage.cutWood(2);
myVillage.mineStone(2);
myVillage.cutWood(4);
myVillage.mineStone(4);
Console.WriteLine(myVillage.getWood()); // affiche 58
Console.WriteLine(myVillage.getStone()); // affiche 46
myVillage.buildHouse(2);
Console.WriteLine(myVillage.listHouse.Length); // affiche 3
Console.WriteLine(myVillage.villageois); // affiche 30
myVillage.cutWood(15);
myVillage.mineStone(15); // affiche Il n'y a pas assez de ressources
Console.WriteLine(myVillage.getWood()); // affiche 187
Console.WriteLine(myVillage.getStone()); // affiche 10
myVillage.buildHouse(4); // affiche Il n'y a pas assez de ressources