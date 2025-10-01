using System.Text.Json.Serialization;

public class LDtkLayer
{
    [JsonPropertyName("__type")]
    public string __Type { get; set; } = "";

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";

    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("gridSize")]
    public int GridSize { get; set; } = -1;

    [JsonPropertyName("displayOpacity")]
    public float DisplayOpacity { get; set; } = 1;

    [JsonPropertyName("pxOffsetX")]
    public int PxOffsetX { get; set; } = -1;

    [JsonPropertyName("pxOffsetY")]
    public int PxOffsetY { get; set; } = -1;

    [JsonPropertyName("parallaxFactorX")]
    public float ParallaxFactorX { get; set; } = -1;

    [JsonPropertyName("parallaxFactorY")]
    public float ParallaxFactorY { get; set; } = -1;

    [JsonPropertyName("parallaxScaling")]
    public bool ParallaxScaling { get; set; } = true;

    [JsonPropertyName("intGridValues")]
    public List<LDtkIntGridValue> IntGridValues { get; set; } = new List<LDtkIntGridValue>();

    [JsonPropertyName("intGridValuesGroups")]
    public List<LDtkIntGridValuesGroup> IntGridValuesGroups { get; set; } = new List<LDtkIntGridValuesGroup>();

    [JsonPropertyName("autoSourceLayerDefUid")]
    public int? AutoSourceLayerDefUid { get; set; }

    [JsonPropertyName("tilesetDefUid")]
    public int? TilesetDefUid { get; set; }

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}