namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Models the physical Lampboard (Glühlampenfeld) displaying the enciphered letter via illuminated bulbs.
/// </summary>
public class Lampboard
{
    /// <summary>
    /// Illuminates the light bulb corresponding to the received electrical current.
    /// </summary>
    /// <param name="signal">Letter receiving electrical current.</param>
    /// <returns>The illuminated letter displayed to the operator.</returns>
    public virtual char Illuminate(char signal)
    {
        throw new NotImplementedException();
    }
}
