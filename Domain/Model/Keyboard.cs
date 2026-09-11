namespace EnigmaMachine.Domain.Model;

/// <summary>
/// Models the physical Enigma keyboard where keys are depressed by the operator.
/// </summary>
public class Keyboard
{
    /// <summary>
    /// Accepts a keystroke from the operator, validating and preparing it for the electrical circuit.
    /// </summary>
    /// <param name="key">The key pressed by the operator.</param>
    /// <returns>The standardized character signal entering the machine.</returns>
    public virtual char PressKey(char key)
    {
        throw new NotImplementedException();
    }
}
