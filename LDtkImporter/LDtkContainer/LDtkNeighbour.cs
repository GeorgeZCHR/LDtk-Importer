using System.Text.Json.Serialization;

public class LDtkNeighbour
{
    [JsonPropertyName("levelIid")]
    public string LevelIid { get; set; } = "";

    [JsonPropertyName("dir")]
    public string Dir { get; set; } = "";

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}