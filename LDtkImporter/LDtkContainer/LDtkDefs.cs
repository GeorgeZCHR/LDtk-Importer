using System.Text.Json.Serialization;

public class LDtkDefs
{
    [JsonPropertyName("layers")]
    public List<LDtkLayer>? Layers { get; set; }

    [JsonPropertyName("entities")]
    public List<LDtkEntity>? Entities { get; set; }

    [JsonPropertyName("tilesets")]
    public List<LDtkTileset>? Tilesets { get; set; }

    [JsonPropertyName("enums")]
    public List<LDtkEnum>? Enums { get; set; }

    [JsonPropertyName("externalEnums")]
    public List<LDtkEnum>? ExternalEnums { get; set; }
}