static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}

int a = 10;
Console.WriteLine($"a = {ToBinaryString(a)}");