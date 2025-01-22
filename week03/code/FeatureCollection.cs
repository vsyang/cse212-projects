using System.ComponentModel;
using System.Text.Json.Serialization;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    [JsonPropertyName("type")]
    public string Type {get; set; }
    [JsonPropertyName("features")]
    public List<Feature> Features {get; set; }
}

public class Feature
{
    [JsonPropertyName("type")]
    public string Type {get; set; }
    [JsonPropertyName("properties")]
    public Properties Properties {get; set; }
    [JsonPropertyName("geometry")]
    public Geometry Geometry {get; set; }
}

public class Properties
{
    [JsonPropertyName("place")]
    public string Place {get; set; }
    [JsonPropertyName("mag")]
    public double? Magnitude {get; set; }
}

public class Geometry
{
    [JsonPropertyName("type")]
    public string Type {get; set; }
    [JsonPropertyName("coordinates")]
    public List<double> Coordinates {get; set; }
}