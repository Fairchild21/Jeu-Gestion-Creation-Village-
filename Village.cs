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
    
    public Mine mine;

    public Forest forest;

    public Village(string name)
    {
        this.name = name;
        this.myRessources = new Ressources();
        this.chefHome = new House();
        this.villageois = House.villageois;
        this.listHouse = new House[1];
        this.listHouse[0] = chefHome;
        this.mine = new Mine();
        this.forest = new Forest();
        
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

    public void mineStone( int nbrVillageois)
    {
        // mineStone par nbrVillageois consomme 2 Stone, 1 wood et rapporte 8 gain_stone
        
        if (nbrVillageois > this.villageois)
        {
            System.Console.WriteLine("Pas assez de villageois! " + villageois + " villageois disponible");
        }
        else if (Mine.stone_cost * nbrVillageois > myRessources.getStone() || Mine.wood_cost * nbrVillageois > myRessources.getWood())
        {
            System.Console.WriteLine("Ressources insuffisantes !");
        }
        else{
            myRessources.useStone(Mine.stone_cost * nbrVillageois);
            myRessources.useWood(Mine.wood_cost * nbrVillageois);
            myRessources.addStone(mine.mineStone(nbrVillageois));
        }    
    }

    public void cutWood(int nbrVillageois)
    {
        if (nbrVillageois > this.villageois)
        {
            System.Console.WriteLine("Villageois requis");
        }
        else if (Forest.stone_cost * nbrVillageois > myRessources.getStone() || Forest.wood_cost * nbrVillageois > myRessources.getWood())
        {
            System.Console.WriteLine("Ressources insuffisantes !");
        }
        else{
            myRessources.useStone(Forest.stone_cost * nbrVillageois);
            myRessources.useWood(Forest.wood_cost * nbrVillageois);
            myRessources.addWood(forest.cutWood(nbrVillageois));
        }
    }

    public void buildHouse(int nbrHouse)
    {
         if ( House.wood_needed * nbrHouse > myRessources.getWood() || House.stone_needed * nbrHouse > getStone())
        {
            System.Console.WriteLine("Ressources insuffisantes !");
        }
        else // on va boucler sur addHouse à chaque fois qu'on utilise buildHouse
        {
            for ( int i = 0; i < nbrHouse; i++)
            {
                myRessources.useStone(House.stone_needed);
                myRessources.useWood(House.wood_needed);
                addHouse(new House());
            }
        }
    }


    public void upgradeRessources()
    {
        myRessources.upgrade();
        myRessources.level ++;
    }

    public void lookAround()
    {
        if (myRessources.level >= 1)
        {
            myRessources.addStone(1);
            myRessources.addWood(1);
        }
    }
}    