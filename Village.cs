public class Village
{
    public  string name{
        get {return name;}
        set {name = value;}
    }
    private Ressources myRessources;

      public House chefHome;
      private int villageois = 0;


    public Village()
    {
        this.name = name;
        this.myRessources = new Ressources();
        this.chefHome = new House();
        this.villageois = House.villageois;
    }

    public string getName()
    {
        return name;
    }

    public int getWood()
    {
        return myRessources.getWood();
    }

    public int getStone()
    {
        return myRessources.getStone();
    }
}    