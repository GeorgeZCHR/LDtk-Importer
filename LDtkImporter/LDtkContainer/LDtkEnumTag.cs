using System.Text.Json.Serialization;

public class LDtkEnumTag
{
    [JsonPropertyName("enumValueId")]
    public string EnumValueId { get; set; } = "";

    [JsonPropertyName("tileIds")]
    public List<int> TileIds { get; set; } = new List<int>();
}