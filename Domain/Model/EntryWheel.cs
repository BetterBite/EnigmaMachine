namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Models the Entry Wheel / Stator (Eintrittswalze - ETW), translating letter signals to physical contact pin positions.
/// </summary>
public class EntryWheel
{
    /// <summary>
    /// Converts an incoming character from the plugboard into an electrical pin index (0-25) into the rotor assembly.
    /// </summary>
    /// <param name="signal">Incoming character.</param>
    /// <returns>Pin index (0-25).</returns>
    public virtual int Forward(char signal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts an electrical pin index (0-25) returning from the rotor assembly into a character back towards the plugboard.
    /// </summary>
    /// <param name="pinIndex">Pin index (0-25).</param>
    /// <returns>Resulting character.</returns>
    public virtual char Backward(int pinIndex)
    {
        throw new NotImplementedException();
    }
}
