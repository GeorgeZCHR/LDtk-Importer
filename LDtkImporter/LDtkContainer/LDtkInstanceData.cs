using System.Text.Json.Serialization;

public class LDtkInstanceData // Inside Toc
{
    [JsonPropertyName("iids")]
    public LDtkInstanceDataIids Iids { get; set; } = new LDtkInstanceDataIids();

    [JsonPropertyName("worldX")]
    public int WorldX { get; set; } = -1;

    [JsonPropertyName("worldY")]
    public int WorldY { get; set; } = -1;

    [JsonPropertyName("widPx")]
    public int? WidPx { get; set; }

    [JsonPropertyName("heiPx")]
    public int? HeiPx { get; set; }

    [JsonPropertyName("fields")] // Not enough info
    public object? Fields { get; set; }

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}