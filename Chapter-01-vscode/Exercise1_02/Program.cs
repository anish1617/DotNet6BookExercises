string? password;

do
{
    Console.Write("Enter your password: ");
    password = Console.ReadLine();

}
while (password != "Pa$$w0rd");

Console.WriteLine("Correct!");