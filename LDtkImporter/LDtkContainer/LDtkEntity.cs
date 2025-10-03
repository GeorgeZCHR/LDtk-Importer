using System.Text.Json.Serialization;

public class LDtkEntity
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";

    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("width")]
    public int Width { get; set; } = -1;

    [JsonPropertyName("height")]
    public int Height { get; set; } = -1;

    [JsonPropertyName("color")]
    public string Color { get; set; } = "#000000";

    [JsonPropertyName("tilesetId")]
    public int? TilesetId { get; set; } = -1;

    [JsonPropertyName("tileRenderMode")]
    public LDtkTileRenderMode TileRenderMode { get; set; } = LDtkTileRenderMode.Cover;

    [JsonPropertyName("tileRect")]
    public LDtkTile? TileRect { get; set; } = new LDtkTile();

    [JsonPropertyName("uiTileRect")]
    public LDtkTile? UITileRect { get; set; } = new LDtkTile();

    [JsonPropertyName("nineSliceBorders")]
    public List<int>? NineSliceBorders { get; set; } = new List<int>();

    [JsonPropertyName("pivotX")]
    public float PivotX { get; set; } = -1;

    [JsonPropertyName("pivotY")]
    public float PivotY { get; set; } = -1;

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}