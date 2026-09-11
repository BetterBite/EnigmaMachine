namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Models an individual physical Enigma Rotor (Walze), including internal wiring permutation,
/// ring setting (Ringstellung), rotational position (Grundstellung), and turnover notches.
/// </summary>
public class Rotor
{
    public virtual string Name { get; }
    public virtual char Position { get; }
    public virtual int RingSetting { get; }
    public virtual IReadOnlySet<char> TurnoverNotches { get; }

    public Rotor(string name, string wiring, string? turnoverNotches = null, int ringSetting = 1, char initialPosition = 'A')
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Sets the rotor's visible window position (Grundstellung).
    /// </summary>
    public virtual void SetPosition(char position)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Sets the rotor's ring setting (Ringstellung).
    /// </summary>
    public virtual void SetRingSetting(int ringSetting)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Advances the rotor by one rotational step (mechanical ratchet rotation).
    /// </summary>
    public virtual void Step()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Checks whether the rotor is currently aligned at a turnover notch, engaging the stepping pawl of the adjacent rotor.
    /// </summary>
    public virtual bool IsAtNotch()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Routes the electrical signal through the rotor from right to left (pin to contact).
    /// </summary>
    /// <param name="pinIndex">Entry pin index (0-25).</param>
    /// <returns>Exit contact index (0-25).</returns>
    public virtual int Forward(int pinIndex)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Routes the electrical signal through the rotor from left to right (contact to pin).
    /// </summary>
    /// <param name="contactIndex">Entry contact index (0-25).</param>
    /// <returns>Exit pin index (0-25).</returns>
    public virtual int Backward(int contactIndex)
    {
        throw new NotImplementedException();
    }
}
