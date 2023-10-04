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
    public string History { get; set; } = @"MTC Philadelphia: This is Todd from MTC Philadelphia. Good morning, thank you for accepting the meeting invite.
    Sheelen, Frank: Good morning, Todd. Thank you for setting this up.
    Todd Furst: I understand you are interested in learning more about Microsoft Teams Calling.
    Sheelen, Frank: Yes, we are. We are currently using Skype for Business and we are looking to move to Teams.
    Todd Furst: Great. I can help you with that. I have a few questions to get us started. Is that okay?
    Sheelen, Frank: Sure.
    Todd Furst: Great. What is your current phone system? What are some of the challenges you are looking to overcome or may be quick wins
    Sheelen, Frank: We are using a Cisco phone system. We are looking to move to Teams to take advantage of the new features and to reduce our costs.
    Todd Furst: Great. I know that we are looking for the MTC session scheduled for September 25th if I remember correctly. Is that correct?
    Sheelen, Frank: No, actually it is scheduled for September 27th.
    Todd Furst: Oh yes. Let me make sure that is reflected on our calendar. I will send you an invite along with the agenda for the day.
    Sheelen, Frank: Great. Thank you.
    Todd Furst: You are welcome. One last question. Do we have a partner involved for this project?
    Sheelen, Frank: Yes, we are working with a partner. They are helping us with the migration.
    Todd Furst: Great. I will make sure to confirm the availability of the relvant stakeholders for the session. I will send you an invite along with the agenda for the day.
    Sheelen, Frank: Great. Thank you.
    Todd Furst: Ok, I'll see you folks on the 27th. Have a great day.
    Sheelen, Frank: You too. Bye.";
}
