using EnigmaMachine.Application.DTOs;
using EnigmaMachine.Application.Services;
using Xunit;

namespace EnigmaMachine.Tests.Application;

/// <summary>
/// Skeleton test suite for the EnigmaFactory application service.
/// </summary>
public class EnigmaFactoryTests
{
    [Fact]
    public void Create_WithValid3RotorConfiguration_AssemblesEnigmaMachine()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void Create_WithValid4RotorM4Configuration_AssemblesEnigmaMachine()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void Create_WithUnknownRotorName_ThrowsInvalidOperationException()
    {
        throw new NotImplementedException();
    }
}
