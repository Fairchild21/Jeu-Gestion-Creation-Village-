public class Village
{
    public  string name;//{
    //     // get {return name;}
    //     // set {name = value;}
    // }
    
    private Ressources myRessources;

      public House chefHome;
      public int villageois = 0;

    public House[] listHouse;  
    

    public Village(string name)
    {
        this.name = name;
        this.myRessources = new Ressources();
        this.chefHome = new House();
        this.villageois = House.villageois;
        this.listHouse = new House[1];
        this.listHouse[0] = chefHome;
        
    }

    public string getName()
    {
        return this.name;
    }

    public int getWood()
    {
        return myRessources.getWood();
    }

    public int getStone()
    {
        return myRessources.getStone();
    }

    // Ajouter un élement au tableau
    // Incrémenter la taille du tableau
    // Créer un nouveau tableau qui aura pour taille la condition ci-dessus
    // Lui attribuer les éléments de l'ancien tableau
    // Appeler le tableau pour lui attribuer le nouvel élément
    
    private void addHouse(House maison)
    {
       House[] newTab = new House[listHouse.Length +1];

       for ( int i = 0; i < listHouse.Length; i++)
       {
        newTab[i] = listHouse[i]; // Attribut les anciennes valeurs à mon tableau à l'index [i]
       }

       newTab[newTab.Length - 1] = maison; // J'appelle le tableau à Length -1 (dernier élément) et lui attribut un nouvel élément

       listHouse = newTab; 
       this.villageois = listHouse.Length * House.villageois;
        
    }
}    