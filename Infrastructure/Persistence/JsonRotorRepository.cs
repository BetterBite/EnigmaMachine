using EnigmaMachine.Application.DTOs;
using EnigmaMachine.Application.Ports.Output;

namespace EnigmaMachine.Infrastructure.Persistence;

/// <summary>
/// Infrastructure adapter implementing the IRotorRepository outbound port.
/// Reads rotor definitions from local JSON files using standard System.Text.Json.
/// </summary>
public class JsonRotorRepository : IRotorRepository
{
    protected readonly string RotorsDirectoryPath;

    public JsonRotorRepository(string rotorsDirectoryPath)
    {
        RotorsDirectoryPath = rotorsDirectoryPath ?? throw new ArgumentNullException(nameof(rotorsDirectoryPath));
    }

    /// <inheritdoc />
    public virtual RotorDefinitionDto GetRotorByName(string name)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public virtual IReadOnlyCollection<string> GetAvailableRotorNames()
    {
        throw new NotImplementedException();
    }
}
