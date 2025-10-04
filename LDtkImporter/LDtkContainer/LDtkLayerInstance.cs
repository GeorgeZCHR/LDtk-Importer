using System.Text.Json.Serialization;

public class LDtkLayerInstance
{
    [JsonPropertyName("__identifier")]
    public string __Identifier { get; set; } = "";

    [JsonPropertyName("__type")]
    public string __Type { get; set; } = "";

    [JsonPropertyName("__cWid")]
    public int __CWid { get; set; } = -1;

    [JsonPropertyName("__cHei")]
    public int __CHei { get; set; } = -1;

    [JsonPropertyName("__gridSize")]
    public int __GridSize { get; set; } = -1;

    [JsonPropertyName("__opacity")]
    public float __Opacity { get; set; } = 1;

    [JsonPropertyName("__pxTotalOffsetX")]
    public int __PxTotalOffsetX { get; set; } = -1;

    [JsonPropertyName("__pxTotalOffsetY")]
    public int __PxTotalOffsetY { get; set; } = -1;

    [JsonPropertyName("__tilesetDefUid")]
    public int? __TilesetDefUid { get; set; } = -1;

    [JsonPropertyName("__tilesetRelPath")]
    public string? __TilesetRelPath { get; set; } = "";

    [JsonPropertyName("iid")]
    public string Iid { get; set; } = "";

    [JsonPropertyName("levelId")]
    public int LevelId { get; set; } = -1;

    [JsonPropertyName("layerDefUid")]
    public int LayerDefUid { get; set; } = -1;

    [JsonPropertyName("pxOffsetX")]
    public int PxOffsetX { get; set; } = -1;

    [JsonPropertyName("pxOffsetY")]
    public int PxOffsetY { get; set; } = -1;

    [JsonPropertyName("visible")]
    public bool Visible { get; set; } = true;

    [JsonPropertyName("intGridCsv")]
    public List<int> IntGridCsv { get; set; } = new List<int>();

    [JsonPropertyName("autoLayerTiles")]
    public List<LDtkTileInstance> AutoLayerTiles { get; set; } = new List<LDtkTileInstance>();

    [JsonPropertyName("overrideTilesetUid")]
    public int? OverrideTilesetUid { get; set; } = -1;

    [JsonPropertyName("gridTiles")]
    public List<LDtkTileInstance>? GridTiles { get; set; } = new List<LDtkTileInstance>();

    [JsonPropertyName("entityInstances")]
    public List<LDtkEntityInstance> EntityInstances { get; set; } = new List<LDtkEntityInstance>();

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }

    // For Entities It will be null
    public LDtkTileset? GetTilesetFromTilesetDefUid(LDtkFile file)
    {
        if (!__TilesetDefUid.HasValue || file.Defs.Tilesets == null) return null;

        for (int i = 0; i < file.Defs.Tilesets.Count; i++)
            if (file.Defs.Tilesets[i].Uid == __TilesetDefUid.Value)
                return file.Defs.Tilesets[i];

        return null; // No tileset
    }
}