using System.Text.Json.Serialization;

public class LDtkWorld
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";

    [JsonPropertyName("iid")]
    public string Iid { get; set; } = "";

    [JsonPropertyName("levels")]
    public List<LDtkLevel> Levels { get; set; } = new List<LDtkLevel>();

    [JsonPropertyName("worldGridWidth")]
    public int WorldGridWidth { get; set; } = -1;

    [JsonPropertyName("worldGridHeight")]
    public int WorldGridHeight { get; set; } = -1;

    [JsonPropertyName("worldLayout")]
    public LDtkLevelOrganizer WorldLayout { get; set; } = LDtkLevelOrganizer.Free;

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}