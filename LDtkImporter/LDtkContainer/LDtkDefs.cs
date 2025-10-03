using System.Text.Json.Serialization;

public class LDtkDefs
{
    [JsonPropertyName("layers")]
    public List<LDtkLayer>? Layers { get; set; } = new List<LDtkLayer>();

    [JsonPropertyName("entities")]
    public List<LDtkEntity>? Entities { get; set; } = new List<LDtkEntity>();

    [JsonPropertyName("tilesets")]
    public List<LDtkTileset>? Tilesets { get; set; } = new List<LDtkTileset>();

    [JsonPropertyName("enums")]
    public List<LDtkEnum>? Enums { get; set; } = new List<LDtkEnum>();

    [JsonPropertyName("externalEnums")]
    public List<LDtkEnum>? ExternalEnums { get; set; } = new List<LDtkEnum>();

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}