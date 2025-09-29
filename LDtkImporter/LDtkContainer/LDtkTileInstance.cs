using System.Text.Json.Serialization;

public class LDtkTileInstance
{
    [JsonPropertyName("px")]
    public int[]? Px { get; set; }

    [JsonPropertyName("src")]
    public int[] Src { get; set; } = new int[2];

    [JsonPropertyName("f")]
    public int F { get; set; } = -1;
    // "Flip bits", a 2-bits integer to represent the mirror transformations of the tile.
    // Examples: f=0 (no flip), f=1 (X flip only), f=2 (Y flip only), f=3 (both flips)

    [JsonPropertyName("t")]
    public int T { get; set; } = -1;

    [JsonPropertyName("a")]
    public float A { get; set; } = -1;
}