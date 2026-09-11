namespace EnigmaMachine.Application.Ports.Input;

/// <summary>
/// Inbound port for enciphering/deciphering complete messages through the Enigma machine.
/// </summary>
public interface ICipherMessageUseCase
{
    /// <summary>
    /// Executes message ciphering across the configured Enigma Machine.
    /// </summary>
    /// <param name="input">Plaintext or ciphertext string.</param>
    /// <returns>Resulting ciphered string.</returns>
    string Execute(string input);
}
