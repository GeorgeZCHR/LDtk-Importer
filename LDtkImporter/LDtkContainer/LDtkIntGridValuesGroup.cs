using System.Text.Json.Serialization;

public class LDtkIntGridValuesGroup
{
    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; } = "";

    [JsonPropertyName("color")]
    public string? Color { get; set; } = "#000000";

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}