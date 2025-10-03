using System.Text.Json;
using System.Text.Json.Serialization;

namespace LDtkImporter;

public static class Importer
{
    public static LDtkFile FromFile(string path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException("LDtk file not found", path);

        string json = File.ReadAllText(path);

        Console.WriteLine(json.Substring(0, 200));

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true // optional: LDtk uses camelCase
        };
        options.Converters.Add(new JsonStringEnumConverter());

        LDtkFile f = JsonSerializer.Deserialize<LDtkFile>(json, options)
            ?? throw new InvalidDataException("Failed to deserialize LDtk file.");

        //if (f != null) Console.WriteLine(f.ToString());

        return f;
    }
}