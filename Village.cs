public class Village
{
    public  string name{
        get {return name;}
        set {name = value;}
    }
    private Ressources myRessources;

    public Village()
    {
        this.name = name;
        this.myRessources = new Ressources();
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