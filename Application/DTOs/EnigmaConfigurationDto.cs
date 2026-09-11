namespace EnigmaMachine.Application.DTOs;

/// <summary>
/// Data Transfer Object representing operator settings for configuring an Enigma Machine.
/// </summary>
public record EnigmaConfigurationDto
{
    /// <summary>
    /// Names of rotors selected, ordered from Left (slow) to Right (fast).
    /// For 4-rotor setups, the Greek rotor is in position 0.
    /// </summary>
    public IReadOnlyList<string> RotorNames { get; init; } = Array.Empty<string>();

    /// <summary>
    /// Initial rotor positions (Grundstellung) from Left to Right (e.g. ['A', 'A', 'A']).
    /// </summary>
    public IReadOnlyList<char> InitialPositions { get; init; } = Array.Empty<char>();

    /// <summary>
    /// Rotor ring settings (Ringstellung) 1-26 from Left to Right (e.g. [1, 1, 1]).
    /// </summary>
    public IReadOnlyList<int> RingSettings { get; init; } = Array.Empty<int>();

    /// <summary>
    /// Reflector type identifier (e.g. "UKW-B", "UKW-C").
    /// </summary>
    public string ReflectorName { get; init; } = "UKW-B";

    /// <summary>
    /// Stecker pairs (e.g. ["AB", "CD", "EF"]).
    /// </summary>
    public IReadOnlyList<string> PlugboardPairs { get; init; } = Array.Empty<string>();
}
