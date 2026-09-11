namespace EnigmaMachine.Application.DTOs;

/// <summary>
/// Data Transfer Object representing rotor wiring specifications and turnover notch positions.
/// </summary>
public record RotorDefinitionDto
{
    public string Name { get; init; } = string.Empty;
    public string Mapping { get; init; } = string.Empty;
    public string? Notch { get; init; }
}
