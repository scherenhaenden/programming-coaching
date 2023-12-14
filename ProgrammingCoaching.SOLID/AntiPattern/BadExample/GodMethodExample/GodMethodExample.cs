namespace ProgrammingCoaching.SOLID.AntiPattern.BadExample.GodMethodExample;

public class GodMethodExample
{
    public void MegaUltraSuperDuperComplexMethodWithPoorNaming()
    {
        // Step 1: Get the user's name
        Console.WriteLine("Pls enter ur name: ");
        string n = Console.ReadLine();
        
        // Step 2: Calculate the sum of numbers up to a given limit
        Console.WriteLine("Enter a number, and I will add all numbers up to it: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        for (int i = 0; i <= x; i++)
        {
            sum += i;
        }
        
        // Step 3: Store the result in a database
        //DbConn db = new DbConn();
        dynamic db = new DbConn();
        db.ConnectToDatabase();
        db.ExecuteSqlQuery("INSERT INTO MegaSumResults (UserName, Result) VALUES ('" + n + "', " + sum + ")");
        db.CloseConnection();
        
        // Step 4: Write the result to a file
        try
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("result.txt");
            file.WriteLine("The mega sum result for " + n + " is " + sum);
            file.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred while writing to the file: " + e.Message);
        }
        
        // Step 5: Send an email to the user
        try
        {
            SmtpMailSender emailSender = new SmtpMailSender();
            emailSender.ConnectToSmtpServer("smtp.example.com");
            emailSender.SendEmail(n, "Your Mega Sum Result", "Hello " + n + ", your mega sum result is " + sum);
            emailSender.Disconnect();
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed to send email: " + e.Message);
        }
        
        // Step 6: Notify a remote service
        RemoteNotifier remoteNotifier = new RemoteNotifier();
        remoteNotifier.ConnectToRemoteService("https://example.com/api");
        remoteNotifier.NotifyService("MegaSumCalculated", n, sum);
        remoteNotifier.Disconnect();
        
        // Step 7: Log the result
        Logger log = new Logger();
        log.LogMessage("Mega sum calculated for " + n + " with result " + sum);
        
        // Step 8: Update the user interface
        try
        {
            UiUpdater uiUpdater = new UiUpdater();
            uiUpdater.UpdateUserInterface(n, sum);
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed to update the UI: " + e.Message);
        }
    }
}
