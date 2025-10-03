using System.Text.Json.Serialization;

public class LDtkTileset
{
    [JsonPropertyName("__cWid")]
    public int __CWid { get; set; } = -1;

    [JsonPropertyName("__cHei")]
    public int __CHei { get; set; } = -1;

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";

    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("relPath")]
    public string? RelPath { get; set; } = "";

    [JsonPropertyName("embedAtlas")]
    public LDtkAtlas? EmbedAtlas { get; set; } = LDtkAtlas.NullAtlas;

    [JsonPropertyName("pxWid")]
    public int PxWid { get; set; } = -1;

    [JsonPropertyName("pxHei")]
    public int PxHei { get; set; } = -1;

    [JsonPropertyName("tileGridSize")]
    public int TileGridSize { get; set; } = -1;

    [JsonPropertyName("spacing")]
    public int Spacing { get; set; } = -1;

    [JsonPropertyName("padding")]
    public int Padding { get; set; } = -1;

    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }

    [JsonPropertyName("tagsSourceEnumUid")]
    public int? TagsSourceEnumUid { get; set; } = -1;

    [JsonPropertyName("enumTags")]
    public List<LDtkEnumTag>? EnumTags { get; set; } = new List<LDtkEnumTag>();

    [JsonPropertyName("customData")]
    public List<LDtkCustomData>? CustomData { get; set; } = new List<LDtkCustomData>();

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}