public class Mine
{
    static public int gain_stone = 10;
    static public int stone_cost = 2;
    static public int wood_cost = 1;
     private int level;

    public Mine()
    {
        System.Console.WriteLine("Mine created");
    }

    public int mineStone(int nbrVillageois)
    {
        return nbrVillageois * gain_stone;        
    }

    public int getLevel()
    {
        return level;
    }

     public void upgrade()
        {
            level ++;
        }
    
}