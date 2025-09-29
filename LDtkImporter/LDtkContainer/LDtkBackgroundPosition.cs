using System.Text.Json.Serialization;

public class LDtkBackgroundPosition
{
    [JsonPropertyName("cropRect")]
    public float[] CropRect { get; set; } = new float[4]; // [cropX, cropY, cropWidth, cropHeight]

    [JsonPropertyName("scale")]
    public float[] Scale { get; set; } = new float[2]; // [scaleX, scaleY]

    [JsonPropertyName("topLeftPx")]
    public int[] TopLeftPx { get; set; } = new int[2]; // [x,y]
}