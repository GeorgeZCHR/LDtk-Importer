using System.Text.Json.Serialization;

public class LDtkSavedSelection
{
    [JsonPropertyName("ids")]
    public List<int> Ids { get; set; } = new List<int>();

    [JsonPropertyName("mode")]
    public string Mode { get; set; } = "";
}