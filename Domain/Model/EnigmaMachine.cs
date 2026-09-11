namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Top-level Domain Aggregate representing a complete physical Enigma Machine.
/// Coordinates the mechanical stepping and electrical circuit across all physical subcomponents.
/// </summary>
public class EnigmaMachine
{
    public virtual Keyboard Keyboard { get; }
    public virtual Plugboard Plugboard { get; }
    public virtual EntryWheel EntryWheel { get; }
    public virtual RotorAssembly RotorAssembly { get; }
    public virtual Reflector Reflector { get; }
    public virtual Lampboard Lampboard { get; }

    public EnigmaMachine(
        Keyboard keyboard,
        Plugboard plugboard,
        EntryWheel entryWheel,
        RotorAssembly rotorAssembly,
        Reflector reflector,
        Lampboard lampboard)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Simulates depressing a single key on the keyboard:
    /// 1. Depresses keyboard key.
    /// 2. Advances rotor assembly mechanically via pawls.
    /// 3. Passes electrical current: Keyboard -> Plugboard -> EntryWheel -> Rotors (Forward) -> Reflector -> Rotors (Backward) -> EntryWheel -> Plugboard -> Lampboard.
    /// 4. Illuminates bulb on lampboard.
    /// </summary>
    /// <param name="key">The key pressed by the operator.</param>
    /// <returns>The character illuminated on the lampboard.</returns>
    public virtual char ProcessKey(char key)
    {
        throw new NotImplementedException();
    }
}
