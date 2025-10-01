using System.Text.Json.Serialization;

public class LDtkHeader
{
    [JsonPropertyName("fileType")]
    public string FileType { get; set; } = "";

    [JsonPropertyName("app")]
    public string App { get; set; } = "";

    [JsonPropertyName("doc")]
    public string Doc { get; set; } = "";

    [JsonPropertyName("schema")]
    public string Schema { get; set; } = "";

    [JsonPropertyName("appAuthor")]
    public string AppAuthor { get; set; } = "";

    [JsonPropertyName("appVersion")]
    public string AppVersion { get; set; } = "";

    [JsonPropertyName("url")]
    public string URL { get; set; } = "";
    
    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}