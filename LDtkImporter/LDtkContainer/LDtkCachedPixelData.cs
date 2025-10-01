using System.Text.Json.Serialization;

public class LDtkCachedPixelData
{
    [JsonPropertyName("opaqueTiles")]
    public string OpaqueTiles { get; set; } = "";

    [JsonPropertyName("averageColors")]
    public string AverageColors { get; set; } = "";

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}