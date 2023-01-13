public class Ressources
{
    private int woods;
    private int stones;   
    public int level;
    private int wood_max;
    private int stone_max;

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
        this.woods = 10;
        this.stones = 10;
        this.level = 1;
        this.wood_max = 250;
        this.stone_max = 250;
    }

    public void addStone(int nbr)
    {
        stones += nbr;

        if (getStone() > stone_max)
        {
            stones = stone_max;
        }
    }

    public void addWood(int nbr)
    {
        woods +=nbr;

        if (getWood() > wood_max)
        {
            woods = wood_max;
        }
    }

    public void upgrade()
    {
        if (getWood() >= wood_max * 80 / 100 || getStone() >= stone_max * 80 / 100)
        {
            woods -= (int)(wood_max *0.8);
            stones -= (int)(stone_max * 0.8);            
            wood_max = wood_max *= 2;
            stone_max = stone_max *= 2;
            level ++;
            System.Console.WriteLine("Upgrade!");
        }
        else
        {
            System.Console.WriteLine("Tu es pauvre !");
        }
    }
}