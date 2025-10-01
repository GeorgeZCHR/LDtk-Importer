using System.Text.Json.Serialization;

public class LDtkCustomData
{
    [JsonPropertyName("tileId")]
    public int TileId { get; set; } = -1;

    [JsonPropertyName("data")]
    public string Data { get; set; } = "";

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}