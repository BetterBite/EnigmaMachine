using EnigmaMachine.Infrastructure.Persistence;
using Xunit;

namespace EnigmaMachine.Tests.Infrastructure;

/// <summary>
/// Skeleton test suite for the JsonRotorRepository infrastructure adapter.
/// </summary>
public class JsonRotorRepositoryTests
{
    [Fact]
    public void GetRotorByName_WithExistingRotorFile_LoadsMappingAndNotchData()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void GetRotorByName_WithNonExistentRotor_ThrowsFileNotFoundException()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void GetAvailableRotorNames_ReturnsAvailableRotorIdentifiers()
    {
        throw new NotImplementedException();
    }
}
