using System.Text.Json.Serialization;

public class LDtkEnumValue
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("tileRect")]
    public LDtkTile TileRect { get; set; } = new LDtkTile();

    [JsonPropertyName("color")]
    public int Color { get; set; } = -1;

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}