using EnigmaMachine.Application.DTOs;

namespace EnigmaMachine.Application.Ports.Input;

/// <summary>
/// Inbound port for reconfiguring the machine state (rotors, ring settings, positions, plugboard).
/// </summary>
public interface IConfigureMachineUseCase
{
    /// <summary>
    /// Configures the active Enigma Machine instance according to the provided specification.
    /// </summary>
    /// <param name="configuration">Machine settings.</param>
    void Configure(EnigmaConfigurationDto configuration);
}
