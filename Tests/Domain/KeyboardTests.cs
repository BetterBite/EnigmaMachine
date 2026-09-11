using EnigmaMachine.Domain.Model;
using Xunit;

namespace EnigmaMachine.Tests.Domain;

/// <summary>
/// Skeleton test suite for the Keyboard physical component.
/// </summary>
public class KeyboardTests
{
    [Fact]
    public void PressKey_WithValidAlphabeticCharacter_EmitsStandardSignal()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void PressKey_WithLowercaseCharacter_NormalizesToUppercase()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void PressKey_WithNonAlphabeticCharacter_ThrowsArgumentException()
    {
        throw new NotImplementedException();
    }
}
