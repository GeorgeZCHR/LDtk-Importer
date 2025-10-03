using System.Text.Json.Serialization;

public class LDtkAutoRuleGroup
{
    [JsonPropertyName("uid")]
    public int Uid { get; set; } = -1;

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("color")]
    public string? Color { get; set; } = "#000000";

    [JsonPropertyName("icon")]
    public LDtkTile? Icon { get; set; } = new LDtkTile();// tile = icon

    [JsonPropertyName("active")]
    public bool Active { get; set; } = true;

    [JsonPropertyName("isOptional")]
    public bool IsOptional { get; set; } = false;

    [JsonPropertyName("rules")]
    public List<LDtkRule> Rules { get; set; } = new List<LDtkRule>();

    [JsonPropertyName("usesWizard")]
    public bool UsesWizard { get; set; } = true;

    [JsonPropertyName("requiredBiomeValues")]
    public List<string>? RequiredBiomeValues { get; set; } = new List<string>();

    [JsonPropertyName("biomeRequirementMode")]
    public int BiomeRequirementMode { get; set; } = 0;

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}