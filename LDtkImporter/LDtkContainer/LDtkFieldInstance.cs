using System.Text.Json.Serialization;

public class LDtkFieldInstance
{
    [JsonPropertyName("__identifier")]
    public string __Identifier { get; set; } = "";

    [JsonPropertyName("__type")]
    public string __Type { get; set; } = "";

    [JsonPropertyName("__value")]
    public object __Value { get; set; } = "";
    // Actual value of the field instance. The value type varies, depending on __type:
    // - For classic types (ie. Integer, Float, Boolean, String, Text and FilePath),
    //       you just get the actual value with the expected type.
    // - For Color, the value is an hexadecimal string using "#rrggbb" format.
    // - For Enum, the value is a String representing the selected enum value.
    // - For Point, the value is a GridPoint object.
    // - For Tile, the value is a TilesetRect object.
    // - For EntityRef, the value is an EntityReferenceInfos object.
    // If the field is an array, then this __value will also be a JSON array.
    // I will need to make special functions for this

    [JsonPropertyName("__tile")]
    public LDtkTile? __Tile { get; set; } = new LDtkTile();

    [JsonPropertyName("defUid")]
    public int DefUid { get; set; } = -1;

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}