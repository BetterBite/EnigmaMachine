using EnigmaMachine.Application.DTOs;
using EnigmaMachine.Application.Ports.Input;
using EnigmaMachine.Domain.Model;

namespace EnigmaMachine.Application.Services;

/// <summary>
/// Application service that orchestrates the encryption and decryption of messages,
/// adhering to the hexagonal architecture input ports.
/// </summary>
public class CipherMessageService : ICipherMessageUseCase, IConfigureMachineUseCase
{
    protected readonly EnigmaFactory Factory;
    protected Domain.Model.EnigmaMachine? ActiveMachine;

    public CipherMessageService(EnigmaFactory factory)
    {
        Factory = factory ?? throw new ArgumentNullException(nameof(factory));
    }

    /// <inheritdoc />
    public virtual void Configure(EnigmaConfigurationDto configuration)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public virtual string Execute(string input)
    {
        throw new NotImplementedException();
    }
}
