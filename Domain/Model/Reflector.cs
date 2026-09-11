namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Models the physical Reflector (Umkehrwalze - UKW) that pairs contacts and redirects
/// the electrical current back through the rotor scramble in the reverse direction.
/// </summary>
public class Reflector
{
    public virtual string Name { get; }

    public Reflector(string name, string wiring)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Reflects an electrical signal from an input pin to its paired contact pin.
    /// </summary>
    /// <param name="pinIndex">Input pin index (0-25).</param>
    /// <returns>Connected output pin index (0-25).</returns>
    public virtual int Reflect(int pinIndex)
    {
        throw new NotImplementedException();
    }
}
