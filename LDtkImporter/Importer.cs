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

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true // optional: LDtk uses camelCase
        };
        options.Converters.Add(new JsonStringEnumConverter());

        return JsonSerializer.Deserialize<LDtkFile>(json, options)
            ?? throw new InvalidDataException("Failed to deserialize LDtk file.");
    }
}