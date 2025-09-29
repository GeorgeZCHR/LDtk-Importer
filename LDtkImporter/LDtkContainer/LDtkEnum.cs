using System.Text.Json.Serialization;

public class LDtkEnum
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";

    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("values")]
    public List<LDtkEnumValue> EnumValues { get; set; } = new List<LDtkEnumValue>();

    [JsonPropertyName("iconTilesetUid")]
    public int? IconTilesetUid { get; set; }

    [JsonPropertyName("externalRelPath")]
    public string? ExternalRelPath { get; set; }

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; } = new List<string>();
}