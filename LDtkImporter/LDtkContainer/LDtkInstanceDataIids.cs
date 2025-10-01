using System.Text.Json.Serialization;

// This object describes the "location" of an Entity instance in the project worlds.
public class LDtkInstanceDataIids
{
    [JsonPropertyName("worldIid")]
    public string WorldIid { get; set; } = "";

    [JsonPropertyName("levelIid")]
    public string LevelIid { get; set; } = "";

    [JsonPropertyName("layerIid")]
    public string LayerIid { get; set; } = "";

    [JsonPropertyName("entityIid")]
    public string EntityIid { get; set; } = "";

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}