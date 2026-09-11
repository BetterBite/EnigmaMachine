using EnigmaMachine.Domain.Model;
using Xunit;

namespace EnigmaMachine.Tests.Domain;

/// <summary>
/// Skeleton test suite for the Plugboard (Steckerbrett) physical component.
/// </summary>
public class PlugboardTests
{
    [Fact]
    public void Forward_WithUnpluggedLetter_ReturnsSameLetter()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void Forward_WithPluggedPair_ReturnsSwappedLetter()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void Backward_WithPluggedPair_ReturnsSwappedLetter()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void ConnectPlug_WithSameLetter_ThrowsArgumentException()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void ConnectPlug_WithAlreadyPluggedLetter_ThrowsInvalidOperationException()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void DisconnectPlug_RemovesConnection()
    {
        throw new NotImplementedException();
    }
}
