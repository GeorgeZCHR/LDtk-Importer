using System.Text.Json.Serialization;

public class LDtkContent
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = "";

    // (Array of Reference to an Entity instance) : *WARNING: this deprecated value will 
    // be removed completely on version 1.7.0+* ** Replaced by: instancesData
    [JsonPropertyName("instances")] // instances = LDtkInstanceDataIids
    public List<LDtkInstanceDataIids>? Instances { get; set; } = new List<LDtkInstanceDataIids>();

    [JsonPropertyName("instancesData")]
    public List<LDtkInstanceData> InstancesData { get; set; } = new List<LDtkInstanceData>();

    public override string ToString()
    {
        return System.Text.Json.JsonSerializer.Serialize(this);
    }
}