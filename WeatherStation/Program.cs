using Database;


namespace WetherStation;


public class Program

{

    public static void Main(string[] args)
    {
        using (var myContext = new WetherStationContext())
        {
            myContext.Database.EnsureCreated();

        }
        
        

    }


    
    

   