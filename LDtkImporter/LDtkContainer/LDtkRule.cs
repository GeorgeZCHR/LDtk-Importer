using System.Text.Json.Serialization;

public class LDtkRule
{
    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("active")]
    public bool Active { get; set; } = true;

    [JsonPropertyName("size")]
    public int Size { get; set; } = -1;

    [JsonPropertyName("tileRectsIds")]
    public List<List<int>> TileRectsIds { get; set; } = new List<List<int>>();

    [JsonPropertyName("alpha")]
    public float Alpha { get; set; } = 1;

    [JsonPropertyName("chance")]
    public float Chance { get; set; } = 1;

    [JsonPropertyName("breakOnMatch")]
    public bool BreakOnMatch { get; set; } = true;

    [JsonPropertyName("pattern")]
    public List<int> Pattern { get; set; } = new List<int>();

    [JsonPropertyName("flipX")]
    public bool FlipX { get; set; } = false;

    [JsonPropertyName("flipY")]
    public bool FlipY { get; set; } = false;

    [JsonPropertyName("xModulo")]
    public int XModulo { get; set; } = 1;

    [JsonPropertyName("yModulo")]
    public int YModulo { get; set; } = 1;

    [JsonPropertyName("xOffset")]
    public int XOffset { get; set; } = -1;

    [JsonPropertyName("yOffset")]
    public int YOffset { get; set; } = -1;

    [JsonPropertyName("tileXOffset")]
    public int TileXOffset { get; set; } = -1;

    [JsonPropertyName("tileYOffset")]
    public int TileYOffset { get; set; } = -1;

    [JsonPropertyName("tileRandomXMin")]
    public int TileRandomXMin { get; set; } = -1;

    [JsonPropertyName("tileRandomXMax")]
    public int TileRandomXMax { get; set; } = -1;

    [JsonPropertyName("tileRandomYMin")]
    public int TileRandomYMin { get; set; } = -1;

    [JsonPropertyName("tileRandomYMax")]
    public int TileRandomYMax { get; set; } = -1;

    [JsonPropertyName("checker")]
    public string Checker { get; set; } = "";

    [JsonPropertyName("tileMode")]
    public string TileMode { get; set; } = "";

    [JsonPropertyName("pivotX")]
    public float PivotX { get; set; } = -1;

    [JsonPropertyName("pivotY")]
    public float PivotY { get; set; } = -1;

    [JsonPropertyName("outOfBoundsValue")]
    public int? OutOfBoundsValue { get; set; } = -1;

    [JsonPropertyName("invalidated")]
    public bool Invalidated { get; set; } = false;

    [JsonPropertyName("perlinActive")]
    public bool PerlinActive { get; set; } = false;

    [JsonPropertyName("perlinSeed")]
    public int PerlinSeed { get; set; } = -1;

    [JsonPropertyName("perlinScale")]
    public float PerlinScale { get; set; } = -1;

    [JsonPropertyName("perlinOctaves")]
    public int PerlinOctaves { get; set; } = -1;

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
    
}