using EnigmaMachine.Application.DTOs;

namespace EnigmaMachine.Application.Ports.Output;

/// <summary>
/// Outbound port for retrieving rotor physical definitions (wiring and notch data).
/// </summary>
public interface IRotorRepository
{
    /// <summary>
    /// Retrieves the rotor definition for a given rotor identifier (e.g. "I", "II", "Beta").
    /// </summary>
    /// <param name="name">Rotor identifier name.</param>
    /// <returns>Rotor definition data.</returns>
    RotorDefinitionDto GetRotorByName(string name);

    /// <summary>
    /// Retrieves all available rotor identifiers.
    /// </summary>
    /// <returns>Collection of rotor names.</returns>
    IReadOnlyCollection<string> GetAvailableRotorNames();
}
