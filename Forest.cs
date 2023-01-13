public class Forest
{
    static public int gain_wood = 10;
    static public int stone_cost = 2;
    static public int wood_cost = 1;
     private int level;

    public int cutWood(int nbrVillageois)
    {
        return nbrVillageois * gain_wood;
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