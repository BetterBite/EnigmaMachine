namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Models the physical Plugboard (Steckerbrett) swapping letter pairs via double-ended patch cables.
/// </summary>
public class Plugboard
{
    /// <summary>
    /// Connects two letters together using a physical plug lead.
    /// </summary>
    /// <param name="first">First letter of the pair.</param>
    /// <param name="second">Second letter of the pair.</param>
    public virtual void ConnectPlug(char first, char second)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Disconnects any plug connected to the specified letter.
    /// </summary>
    /// <param name="letter">The letter to unplug.</param>
    public virtual void DisconnectPlug(char letter)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Routes the electrical signal through the plugboard forward (keyboard towards entry wheel).
    /// </summary>
    /// <param name="signal">Input character.</param>
    /// <returns>Output character after plug swap or unchanged if unplugged.</returns>
    public virtual char Forward(char signal)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Routes the electrical signal through the plugboard backward (entry wheel towards lampboard).
    /// </summary>
    /// <param name="signal">Input character.</param>
    /// <returns>Output character after plug swap or unchanged if unplugged.</returns>
    public virtual char Backward(char signal)
    {
        throw new NotImplementedException();
    }
}
