using System.Text.Json.Serialization;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;

namespace Models;

#pragma warning disable CA1812
internal class ExecuteFunctionRequest
{
    [JsonPropertyName("variables")]
    [OpenApiProperty(Description = "The variables to pass to the semantic function.")]
    public IEnumerable<ExecuteFunctionVariable> Variables { get; set; } = Enumerable.Empty<ExecuteFunctionVariable>();
}

internal class ExecuteFunctionVariable
{
    [JsonPropertyName("key")]
    [OpenApiProperty(Description = "The variable key.", Default = "input")]
    public string Key { get; set; } = string.Empty;

    [JsonPropertyName("history")]
    [OpenApiProperty(Description = "The variable history.", Default = "Meeting transcript")]
    public string History { get; set; } = @"";
}
