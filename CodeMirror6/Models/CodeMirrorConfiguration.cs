using System.Text.Json.Serialization;

namespace CodeMirror6.Models;

/// <summary>
/// Represents the configuration of the CodeMirror editor
/// </summary>
/// <param name="doc"></param>
/// <param name="placeholder"></param>
/// <param name="themeName"></param>
/// <param name="tabSize"></param>
/// <param name="indentationUnit"></param>
/// <param name="readOnly"></param>
/// <param name="editable"></param>
/// <param name="languageName"></param>
/// <param name="autoFormatMarkdownHeaders"></param>
public class CodeMirrorConfiguration(
    string? doc,
    string? placeholder,
    string? themeName,
    int tabSize,
    int indentationUnit,
    bool readOnly,
    bool editable,
    string? languageName,
    bool autoFormatMarkdownHeaders)
{

    /// <summary>
    /// The text to display in the editor
    /// </summary>
    [JsonPropertyName("doc")] public string? Doc { get; internal set; } = doc;

    /// <summary>
    /// The placeholder to display in the editor
    /// </summary>
    [JsonPropertyName("placeholder")] public string? Placeholder { get; internal set; } = placeholder;

    /// <summary>
    /// The theme to use for the editor
    /// </summary>
    [JsonPropertyName("themeName")] public string? ThemeName { get; internal set; } = themeName;

    /// <summary>
    /// The tab size to use for the editor
    /// </summary>
    [JsonPropertyName("tabSize")] public int TabSize { get; internal set; } = tabSize;

    /// <summary>
    /// The indent unit to use for the editor
    /// </summary>
    [JsonPropertyName("indentationUnit")] public int IndentationUnit { get; internal set; } = indentationUnit;

    /// <summary>
    /// Determine whether editing functionality should apply.
    /// Not to be confused with editable, which controls whether the editor's DOM is internal set to be editable (and thus focusable).
    /// </summary>
    [JsonPropertyName("readOnly")] public bool ReadOnly { get; internal set; } = readOnly;

    /// <summary>
    /// Controls whether the editor content DOM is editable
    /// </summary>
    [JsonPropertyName("editable")] public bool Editable { get; internal set; } = editable;

    /// <summary>
    /// The language to use in the editor
    /// </summary>
    [JsonPropertyName("languageName")] public string? LanguageName { get; internal set; } = languageName;

    /// <summary>
    /// Whether to automatically format (resize) markdown headers
    /// </summary>
    [JsonPropertyName("autoFormatMarkdownHeaders")] public bool AutoFormatMarkdownHeaders { get; internal set; } = autoFormatMarkdownHeaders;
}
