using System.Text.Json.Serialization;

public class LDtkEntityInstance
{
    [JsonPropertyName("__identifier")]
    public string __Identifier { get; set; } = "";

    [JsonPropertyName("__grid")]
    public int[] __Grid { get; set; } = new int[2];

    [JsonPropertyName("__pivot")]
    public float[] __Pivot { get; set; } = new float[2];

    [JsonPropertyName("__tags")]
    public List<string> __Tags { get; set; } = new List<string>();

    [JsonPropertyName("__tile")]
    public LDtkTile? __Tile { get; set; }

    [JsonPropertyName("__smartColor")]
    public string __SmartColor { get; set; } = "#000000";

    [JsonPropertyName("iid")]
    public string Iid { get; set; } = "";

    [JsonPropertyName("width")]
    public int Width { get; set; } = -1;

    [JsonPropertyName("height")]
    public int Height { get; set; } = -1;

    [JsonPropertyName("defUid")]
    public int DefUid { get; set; } = -1;

    [JsonPropertyName("px")]
    public int[] Px { get; set; } = new int[2];

    [JsonPropertyName("fieldInstances")]
    public List<LDtkFieldInstance> FieldInstances { get; set; } = new List<LDtkFieldInstance>();

    [JsonPropertyName("__worldX")]
    public int? __WorldX { get; set; } = -1;

    [JsonPropertyName("__worldY")]
    public int? __WorldY { get; set; } = -1;
}