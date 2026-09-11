namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Models the physical rotor cradle/assembly holding the ordered rotors.
/// Manages mechanical pawls, ratchets, turnover notches, and the double-stepping anomaly.
/// Supports both 3-rotor (Enigma I / M3) and 4-rotor (M4 naval) configurations.
/// </summary>
public class RotorAssembly
{
    public virtual IReadOnlyList<Rotor> Rotors { get; }

    public RotorAssembly(IEnumerable<Rotor> rotors)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Executes the mechanical stepping cycle before an electrical impulse passes through.
    /// The rightmost (fast) rotor always steps; middle rotor steps on right turnover or its own notch (double-stepping anomaly);
    /// left rotor steps on middle rotor turnover.
    /// </summary>
    public virtual void Step()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Routes the signal forward from the entry wheel through each rotor (right to left).
    /// </summary>
    /// <param name="pinIndex">Initial pin index from the entry wheel.</param>
    /// <returns>Exit pin index entering the reflector.</returns>
    public virtual int Forward(int pinIndex)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Routes the signal backward from the reflector through each rotor (left to right).
    /// </summary>
    /// <param name="contactIndex">Pin index emerging from the reflector.</param>
    /// <returns>Exit pin index returning to the entry wheel.</returns>
    public virtual int Backward(int contactIndex)
    {
        throw new NotImplementedException();
    }
}
