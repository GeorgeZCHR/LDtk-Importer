using System.Text.Json.Serialization;

public class LDtkIntGridValue
{
    [JsonPropertyName("value")]
    public int Value { get; set; } = -1;

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; } = "";

    [JsonPropertyName("color")]
    public string Color { get; set; } = "#000000";

    [JsonPropertyName("tile")]
    public LDtkTile? Tile { get; set; } = new LDtkTile();

    [JsonPropertyName("groupUid")]
    public int GroupUid { get; set; } = -1;

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}