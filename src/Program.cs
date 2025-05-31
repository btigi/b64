using System.Text;

if (args.Length == 0)
{
    Console.WriteLine("Usage: b64 [-e|-d] <text>");
    Console.WriteLine("  -e: encode to base64 (default is decode)");
    Console.WriteLine("  -d: decode from base64");
    return 1;
}

var encode = false;
var input = string.Empty;

if (args[0] == "-e")
{
    encode = true;
    input = string.Join(" ", args[1..]);
}
else if (args[0] == "-d")
{
    input = string.Join(" ", args[1..]);
}
else
{
    input = string.Join(" ", args);
}

try
{
    string result = encode 
        ? Convert.ToBase64String(Encoding.UTF8.GetBytes(input))
        : Encoding.UTF8.GetString(Convert.FromBase64String(input));
    
    Console.WriteLine(result);
    return 0;
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Error: {ex.Message}");
    return 1;
}