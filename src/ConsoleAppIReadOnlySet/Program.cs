using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 11 | IReadOnlySet<T> + Desserializacao System.Text.Json *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

IReadOnlySet<string> campeoesMundiais = new HashSet<string>()
{
    "Brasil",
    "Italia",
    "Alemanha",
    "Argentina",
    "Uruguai",
    "Franca",
    "Inglaterra",
    "Espanha"
};
var jsonData = JsonSerializer.Serialize(campeoesMundiais);

Console.WriteLine();
Console.WriteLine($"Resultado da serializacao JSON - Referencia *{nameof(jsonData)}*: ");
Console.WriteLine(jsonData);

Console.WriteLine();
Console.WriteLine("Desserializando string JSON...");
var campeoesMundiaisDeserialized =
    JsonSerializer.Deserialize<IReadOnlySet<string>>(jsonData)!;

Console.WriteLine();
Console.WriteLine($"Resultado da serializacao JSON - Referencia *{nameof(campeoesMundiaisDeserialized)}*: ");
Console.WriteLine(JsonSerializer.Serialize(campeoesMundiaisDeserialized));