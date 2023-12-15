using Bogus;

namespace ProgrammingCoaching.SOLID.Examples.Credit.Data;

public class ClassGenerateData
{
    public static List<User> Users = new List<User>();
    public static List<CreditRatingUserExternals> CreditRatingUserExternals = new List<CreditRatingUserExternals>();
    
    
    public static List<RegistredUser> RegistredUsers { get; set; } = new List<RegistredUser>();
    
    
    private static bool _isCreated = false;


    public static void CreateAll()
    {
        if(_isCreated) return;
        
        CreateUsers();
        GenerateStaticCasesConditions();
        
        _isCreated = true;
    }
    public static IEnumerable<IEnumerable<T>> SplitListByCount<T>(List<T> list, int numberOfParts)
    {
        int itemsPerPart = list.Count / numberOfParts;
        int remainder = list.Count % numberOfParts;

        int index = 0;
        for (int i = 0; i < numberOfParts; i++)
        {
            int currentPartSize = itemsPerPart + (i < remainder ? 1 : 0);
            yield return list.GetRange(index, currentPartSize);
            index += currentPartSize;
        }
    }
    
    public static IEnumerable<IEnumerable<T>> SplitList<T>(List<T> locations, int nSize)
    {
        for (int i = 0; i < locations.Count; i += nSize)
        {
            yield return locations.GetRange(i, Math.Min(nSize, locations.Count - i));
        }
    }
    
    public static void CreateUsers()
    {
        // Create with bogus
        var testsUsers = new Faker<User>().StrictMode(true)
            //.RuleFor(u => u.UserID, f => f.Random.Guid().ToString())
            .RuleFor(u => u.NationalIdentificationID, f => f.Random.Guid().ToString())
            //.RuleFor(u => u.AccountNumber, f => f.Random.Guid().ToString())
            .RuleFor(u => u.Name, f => f.Person.FullName)
            .RuleFor(u => u.Address, f => f.Address.FullAddress())
            .RuleFor(u => u.ContactDetails, f => f.Person.Email)
            //.RuleFor(u => u.CreditRating, f => f.Random.Double(0, 1000))
            //.RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f))
            .Generate(1000);
        //.ForEach(u => Users.Add(u));
        
        Users.AddRange(testsUsers);

        var listsOfUsers =SplitListByCount(testsUsers, 4).ToList(); //.ForEach(u => Users.AddRange(u));

        foreach (var unregistered in listsOfUsers[0])
        {
            CreditRatingUserExternals.Add(new Faker<CreditRatingUserExternals>().StrictMode(true)
                .RuleFor(u => u.NationalIdentificationID, f => unregistered.NationalIdentificationID)
                .RuleFor(u => u.CreditRating, f => f.Random.Double(0, 1000))
                .RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f)));


        }
        
        foreach (var registered in listsOfUsers[1])
        {
            RegistredUsers.Add(new Faker<RegistredUser>().StrictMode(true)
                .RuleFor(u => u.NationalIdentificationID, f => registered.NationalIdentificationID)
                .RuleFor(u => u.UserID, f => f.Random.Guid().ToString())
                .RuleFor(u => u.AccountNumber, f => f.Random.Guid().ToString())
                .RuleFor(u => u.InternalCreditRating, f => f.Random.Double(0, 1000))
                .RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f)));
            CreditRatingUserExternals.Add(new Faker<CreditRatingUserExternals>().StrictMode(true)
                .RuleFor(u => u.NationalIdentificationID, f => registered.NationalIdentificationID)
                .RuleFor(u => u.CreditRating, f => f.Random.Double(0, 1000))
                .RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f)));
            
        }
        
        foreach (var both in listsOfUsers[2])
        {
            CreditRatingUserExternals.Add(new Faker<CreditRatingUserExternals>().StrictMode(true)
                .RuleFor(u => u.NationalIdentificationID, f => both.NationalIdentificationID)
                .RuleFor(u => u.CreditRating, f => f.Random.Double(0, 10))
                .RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f)));
            
            RegistredUsers.Add(new Faker<RegistredUser>().StrictMode(true)
                .RuleFor(u => u.NationalIdentificationID, f => both.NationalIdentificationID)
                .RuleFor(u => u.UserID, f => f.Random.Guid().ToString())
                .RuleFor(u => u.AccountNumber, f => f.Random.Guid().ToString())
                .RuleFor(u => u.InternalCreditRating, f => f.Random.Double(900, 1000))
                .RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f)));
        }
        
        foreach (var both in listsOfUsers[3])
        {
            CreditRatingUserExternals.Add(new Faker<CreditRatingUserExternals>().StrictMode(true)
                .RuleFor(u => u.NationalIdentificationID, f => both.NationalIdentificationID)
                .RuleFor(u => u.CreditRating, f => f.Random.Double(900, 1000))
                .RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f)));
            
            RegistredUsers.Add(new Faker<RegistredUser>().StrictMode(true)
                .RuleFor(u => u.NationalIdentificationID, f => both.NationalIdentificationID)
                .RuleFor(u => u.UserID, f => f.Random.Guid().ToString())
                .RuleFor(u => u.AccountNumber, f => f.Random.Guid().ToString())
                .RuleFor(u => u.InternalCreditRating, f => f.Random.Double(0, 100))
                .RuleFor(u => u.IsBlackListed, f => f.Random.Bool(0.5f)));
        }
    }

    
    
    
    
    public static List<CreditConditions> CreditConditions = new List<CreditConditions>();
    
    public static void GenerateStaticCasesConditions()
    {
        var autoLoanConditions = new CreditConditions(CreditType.AutoLoan, 5000m, 50000m,
            new Dictionary<decimal, double>
            {
                { 5000m, 600.0 },
                { 15000m, 620.0 },
                { 30000m, 640.0 },
                { 50000m, 660.0 }
            },
            3.5,
            60);
        
        CreditConditions.Add(autoLoanConditions);
        
        var personalLoanConditions = new CreditConditions(CreditType.PersonalLoan, 2000m, 40000m,
            new Dictionary<decimal, double>
            {
                { 2000m, 680.0 },
                { 10000m, 700.0 },
                { 20000m, 720.0 },
                { 40000m, 740.0 }
            },
            5.0,
            48);
        
        CreditConditions.Add(personalLoanConditions);
        
        var studentLoanConditions = new CreditConditions(CreditType.StudentLoan, 1000m, 100000m,
            new Dictionary<decimal, double>
            {
                { 1000m, 650.0 },
                { 25000m, 670.0 },
                { 50000m, 690.0 },
                { 100000m, 710.0 }
            },
            4.5,
            120);

        CreditConditions.Add(studentLoanConditions);
        
        var creditCardConditions = new CreditConditions(CreditType.CreditCard, 500m, 5000m,
            new Dictionary<decimal, double>
            {
                { 500m, 600.0 },
                { 1500m, 620.0 },
                { 3000m, 640.0 },
                { 5000m, 660.0 }
            },
            15.0,
            0);
        
        CreditConditions.Add(creditCardConditions);
        
        var businessLoanConditions = new CreditConditions(CreditType.BusinessLoan, 10000m, 1000000m,
            new Dictionary<decimal, double>
            {
                { 10000m, 720.0 },
                { 100000m, 740.0 },
                { 500000m, 760.0 },
                { 1000000m, 780.0 }
            },
            6.0,
            240);
        
        CreditConditions.Add(businessLoanConditions);
        
        var homeEquityLoanConditions = new CreditConditions(CreditType.HomeEquityLoan, 10000m, 500000m,
            new Dictionary<decimal, double>
            {
                { 10000m, 680.0 },
                { 50000m, 700.0 },
                { 200000m, 720.0 },
                { 500000m, 740.0 }
            },
            4.25,
            180);
        
        CreditConditions.Add(homeEquityLoanConditions);
        
        var paydayLoanConditions = new CreditConditions(CreditType.PaydayLoan, 100m, 2000m,
            new Dictionary<decimal, double>
            {
                { 100m, 400.0 },
                { 500m, 450.0 },
                { 1000m, 500.0 },
                { 2000m, 550.0 }
            },
            15.0,
            12);

        CreditConditions.Add(paydayLoanConditions);
        
        var debtConsolidationLoanConditions = new CreditConditions(CreditType.DebtConsolidationLoan, 5000m, 50000m,
            new Dictionary<decimal, double>
            {
                { 5000m, 660.0 },
                { 15000m, 680.0 },
                { 30000m, 700.0 },
                { 50000m, 720.0 }
            },
            6.5,
            60);
        
        CreditConditions.Add(debtConsolidationLoanConditions);
        
        var mortgageConditions = new CreditConditions(CreditType.Mortgage, 50000m, 1000000m,
            new Dictionary<decimal, double>
            {
                { 50000m, 700.0 },
                { 100000m, 720.0 },
                { 500000m, 740.0 },
                { 1000000m, 760.0 }
            },
            3.5,
            360);
        
        CreditConditions.Add(mortgageConditions);
        
        var creditBuilderLoanConditions = new CreditConditions(CreditType.CreditBuilderLoan, 500m, 5000m,
            new Dictionary<decimal, double>
            {
                { 500m, 580.0 },
                { 1000m, 600.0 },
                { 3000m, 620.0 },
                { 5000m, 640.0 }
            },
            9.0,
            24);
        
        CreditConditions.Add(creditBuilderLoanConditions);
        
        var equipmentFinancingConditions = new CreditConditions(CreditType.EquipmentFinancing ,5000m, 500000m,
            new Dictionary<decimal, double>
            {
                { 5000m, 650.0 },
                { 50000m, 670.0 },
                { 200000m, 690.0 },
                { 500000m, 710.0 }
            },
            5.5,
            60);
        
        CreditConditions.Add(equipmentFinancingConditions);
        
        var greenLoanConditions = new CreditConditions(CreditType.GreenLoan, 10000m, 200000m,
            new Dictionary<decimal, double>
            {
                { 10000m, 660.0 },
                { 50000m, 680.0 },
                { 100000m, 700.0 },
                { 200000m, 720.0 }
            },
            4.0,
            84);
        
        CreditConditions.Add(greenLoanConditions);



            
            






        

    }
    
    
}