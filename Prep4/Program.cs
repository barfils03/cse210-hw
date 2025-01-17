using System;
// wk01 Monica Solis LISTS
class Program
{
    static void Main(string[] args)
    {

        List<int> listUsernumbers;
        listUsernumbers = new List<int>();
        List<int> listUsernumberspositive;
        listUsernumberspositive = new List<int>();

        string varUserkeyinstring;
        int varUserkeyin;

        do {
            Console.WriteLine("Enter a number (type 0 to finish):");
        
            varUserkeyinstring =Console.ReadLine();

            varUserkeyin = int.Parse(varUserkeyinstring);
            if (varUserkeyin != 0 ){
                listUsernumbers.Add(varUserkeyin);
                if (varUserkeyin >= 1 ){
                    listUsernumberspositive.Add(varUserkeyin);
                }
            }

        } while (varUserkeyin != 0) ;


        int sumUsernumbers = listUsernumbers.Sum();

        double aveUsernumbers = listUsernumbers.Average();
        int maxUsernumbers= listUsernumbers.Max();
        int minposUsernumbers = listUsernumberspositive.Min();
        Console.WriteLine($"The sum of your numbers is {sumUsernumbers}. ");
        Console.WriteLine($"The Average {aveUsernumbers}. ");
        Console.WriteLine($"The largest number is  {maxUsernumbers}. ");
        Console.WriteLine($"The smallest positive number is {minposUsernumbers}. ");
 
        listUsernumbers.Sort();

        for (int i = 0; i < listUsernumbers.Count; i++)
        {
            Console.WriteLine(listUsernumbers[i]);           
        }   
    }

}