using Packt.Shared;
using static System.Console;
using static System.ValueTuple;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWorld = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardenOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new() { Name = "Alfred"});
bob.Children.Add(new() { Name = "Zoe"});
var fruit = bob.GetFruit();

BankAccount.InterestRate = 0.012M;
BankAccount jonesAccout = new()
{
    AccoutName = "Mrs. Jones",
    Balance = 2400
};


Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7),
    FavoriteAncientWorld = WondersOfTheAncientWorld.GreatPyramidOfGiza
};

//Tuples
(string TheName, int TheNumber) tupleWithNamedFields = bob.GetNamedFruit();
WriteLine($"{tupleWithNamedFields.TheName} {tupleWithNamedFields.TheNumber}");
(string name, int number) = bob.GetNamedFruit();
WriteLine($"{name} {number}");
var thing1 = ("Neville", 4);

WriteLine($"{thing1.Item1} has {thing1.Item2} children");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children");

//Deconstruct
var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var(name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine($"{jonesAccout.AccoutName} earned {jonesAccout.Balance * BankAccount.InterestRate:c} interest.");
WriteLine($"{bob.Name} has {bob.Children.Count} children");
for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"{bob.Children[childIndex].Name}");
}
WriteLine($"There are {fruit.Number} {fruit.Name}.");
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWorld,
    arg2: (int)bob.FavoriteAncientWorld);

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);

// Passing parameters into method three ways
int a = 10;
int b = 20;
WriteLine($"Before a = {a} and b = {b}");
bob.PassigngParameters(a, ref b, out int c);
WriteLine($"After a = {a}, b = {b} and c = {c}");

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1972, 1, 27)
};

sam.FavoriteIceCream = "Chocolate Fudge";
sam.FavoritePrimaryColor = "Red";
WriteLine(sam.Greeting);
WriteLine(sam.Age);
WriteLine($"Sam's favorite ice cream flavor is {sam.FavoriteIceCream}.");
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");

//indexers 
sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's first child is {sam[1].Name}");

// pattern Matching with Objects.
WriteLine("=============== pattern Matching with Objects =============");
WriteLine(" ** This works on : c# 8 ** \n");
object[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419},
    new FirstClassPassenger {AirMiles = 16_562},
    new BusinessClassPassenger(),
    new CoachClassPassenger {CarryOnKG = 25.7},
    new CoachClassPassenger {CarryOnKG = 0}
};

foreach(object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };

    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

WriteLine("\n** Enhancements to pattern matchin on c# 9 or later ** \n");
object[] passengers2 =
{
    new FirstClassPassenger { AirMiles = 1_419},
    new FirstClassPassenger {AirMiles = 16_562},
    new BusinessClassPassenger(),
    new CoachClassPassenger {CarryOnKG = 25.7},
    new CoachClassPassenger {CarryOnKG = 0}
};

foreach (object passenger in passengers2)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
        },
        BusinessClassPassenger => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };

    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}


WriteLine("\n** Relational pattern in combination with the property pattern to avoid nested switch ** ");
object[] passengers3 =
{
    new FirstClassPassenger { AirMiles = 1_419},
    new FirstClassPassenger {AirMiles = 16_562},
    new BusinessClassPassenger(),
    new CoachClassPassenger {CarryOnKG = 25.7},
    new CoachClassPassenger {CarryOnKG = 0}
};

foreach (object passenger in passengers3)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger { AirMiles: > 35000} => 1500M,
        FirstClassPassenger { AirMiles: > 15000} => 1750M,
        FirstClassPassenger => 2000M,
        BusinessClassPassenger => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };

    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}