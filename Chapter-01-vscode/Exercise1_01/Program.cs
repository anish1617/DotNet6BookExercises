string path = @"D:\Code\Chapter-01";

Console.WriteLine("Press R for read-only or W for writable: ");
ConsoleKeyInfo Key = Console.ReadKey();
Console.WriteLine();

Stream? s;

if (Key.Key == ConsoleKey.R)
{
    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
}
else
{
    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
}


string message;

message = s switch
{
    FileStream writableFile when s.CanWrite
        => "the stream is file that i can write to.",
    FileStream readOnlyFile
        => "The stream is a read-only file",
    MemoryStream ms
        => "The stream is a memory address",
    null
        => "The stream is null",
    _
        => "The stream is some other type."

};
Console.WriteLine(message);