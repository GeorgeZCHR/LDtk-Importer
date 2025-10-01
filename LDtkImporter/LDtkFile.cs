using System.Text.Json.Serialization;

public class LDtkFile //LDtkRoot
{
    [JsonPropertyName("__header__")]
    public LDtkHeader Header { get; set; } = new LDtkHeader();

    [JsonPropertyName("iid")]
    public string Iid { get; set; } = "";

    [JsonPropertyName("jsonVersion")]
    public string JsonVersion { get; set; } = "";

    [JsonPropertyName("toc")] // toc : table of contents
    public List<LDtkContent>? TOC { get; set; }

    [JsonPropertyName("worldLayout")]
    public string? WorldLayout { get; set; }

    [JsonPropertyName("worldGridWidth")]
    public int? WorldGridWidth { get; set; }

    [JsonPropertyName("worldGridHeight")]
    public int? WorldGridHeight { get; set; }

    [JsonPropertyName("bgColor")]
    public string BGColor { get; set; } = "#000000";

    [JsonPropertyName("externalLevels")]
    public bool ExternalLevels { get; set; } = false;

    [JsonPropertyName("defs")]
    public LDtkDefs Defs { get; set; } = new LDtkDefs();

    [JsonPropertyName("levels")]
    public List<LDtkLevel> Levels { get; set; } = new List<LDtkLevel>();

    [JsonPropertyName("worlds")]
    public List<LDtkWorld>? Worlds { get; set; }

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}