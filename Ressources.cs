public class Ressources
{
    private int woods;//{
    //     get {return woods;}
    //     set { woods = value;}
    // }
    private int stones;//{
    //     get {return stones;}
    //     set { stones = value;}
    // }

    public int getWood()
    {
        return woods;
    }  

    public int getStone()
    {
        return stones;
    }

    public void useWood(int nbr)
    {
        if (woods < nbr)
        {
            System.Console.WriteLine("Quantité insuffisante");
            return;
        }
        this.woods -= nbr;
    }

    public void useStone(int nbr)
    {
        if (stones < nbr)
        {
            System.Console.WriteLine("Quantité indisponible");
            return;
        }
        this.stones -= nbr;
    }

    public Ressources()
    {
        woods = 10;
        stones = 10;
    }

    public void addStone(int nbr)
    {
        stones += nbr;
    }

    public void addWood(int nbr)
    {
        woods +=nbr;
    }
}