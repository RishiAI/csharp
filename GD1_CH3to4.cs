public class GD1_CH3to4
{
    public static float Sale(ref float cost1, ref float cost2, ref float cost3){
        float sale = 0;
           if (cost1 <= cost2 && cost1 <= cost3)
            {
                cost1 /= 2;
            }
            else if (cost2 <= cost3 && cost2 <= cost3)
            {
                cost2 /= 2;
            }
            else if(cost3 <= cost1 && cost3 <= cost2)
            {
                cost3 /= 2;
            }
            
        sale += cost1 + cost2 + cost3;
    
        return sale;         
}
    public static int NumberOfFactors(int number)
    {
        int numfact = 0;
        for (int i = 1; i<= number; i++)
        {
            if(number%i == 0)
            {
                numfact++;
            }
        }
        return numfact;
    }

}