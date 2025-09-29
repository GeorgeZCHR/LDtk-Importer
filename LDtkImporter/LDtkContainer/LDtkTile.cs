using System.Text.Json.Serialization;

// This object represents a custom sub rectangle in a Tileset image.
public class LDtkTile
{
    [JsonPropertyName("tilesetUid")]
    public int TilesetUid { get; set; } = -1;

    [JsonPropertyName("x")]
    public int X { get; set; } = -1;

    [JsonPropertyName("y")]
    public int Y { get; set; } = -1;

    [JsonPropertyName("w")]
    public int W { get; set; } = -1;

    [JsonPropertyName("h")]
    public int H { get; set; } = -1;
}