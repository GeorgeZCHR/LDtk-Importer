using System.Text.Json.Serialization;

public class LDtkLevel
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";

    [JsonPropertyName("iid")]
    public string Iid { get; set; } = "";

    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("worldX")]
    public int WorldX { get; set; } = -1;

    [JsonPropertyName("worldY")]
    public int WorldY { get; set; } = -1;

    [JsonPropertyName("worldDepth")]
    public int WorldDepth = -1;

    [JsonPropertyName("pxWid")]
    public int PxWid { get; set; } = -1;

    [JsonPropertyName("pxHei")]
    public int PxHei { get; set; } = -1;

    [JsonPropertyName("__bgColor")]
    public string __BGColor { get; set; } = "";

    [JsonPropertyName("bgRelPath")]
    public string? BGRelPath { get; set; }

    [JsonPropertyName("__bgPos")]
    public LDtkBackgroundPosition? __BGPos { get; set; }

    [JsonPropertyName("externalRelPath")]
    public string? ExternalRelPath { get; set; }

    [JsonPropertyName("fieldInstances")]
    public List<LDtkFieldInstance>? FieldInstances { get; set; }

    [JsonPropertyName("layerInstances")]
    public List<LDtkLayerInstance>? LayerInstances { get; set; }

    //An array listing all other levels touching this one on the world map.
    [JsonPropertyName("__neighbours")]
    public List<LDtkNeighbour>? __Neighbours { get; set; }

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}