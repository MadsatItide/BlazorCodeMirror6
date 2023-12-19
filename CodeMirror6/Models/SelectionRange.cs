using System.Text.Json.Serialization;

namespace CodeMirror6.Models;

/// <summary>
/// A single selection range.
/// When allowMultipleSelections is enabled, a selection may hold multiple ranges.
/// By default, selections hold exactly one range.
/// </summary>
/// <remarks>
/// DotNet port of the CM6 EditorSelection typescript class.
/// </remarks>
public record SelectionRange
{
    /// <summary>
    /// The lower boundary of the range.
    /// </summary>
    /// <value></value>
    [JsonPropertyName("from")] public int? From { get; set; }
    /// <summary>
    /// The upper boundary of the range.
    /// </summary>
    /// <value></value>
    [JsonPropertyName("to")] public int? To { get; set; }
}
