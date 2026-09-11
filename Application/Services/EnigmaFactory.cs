using EnigmaMachine.Application.DTOs;
using EnigmaMachine.Application.Ports.Output;
using EnigmaMachine.Domain.Model;

namespace EnigmaMachine.Application.Services;

/// <summary>
/// Application factory responsible for instantiating and wiring together Domain physical components
/// based on configuration settings and rotor definitions provided by the outbound repository port.
/// </summary>
public class EnigmaFactory
{
    protected readonly IRotorRepository RotorRepository;

    public EnigmaFactory(IRotorRepository rotorRepository)
    {
        RotorRepository = rotorRepository ?? throw new ArgumentNullException(nameof(rotorRepository));
    }

    /// <summary>
    /// Constructs a fully assembled EnigmaMachine aggregate from a configuration DTO.
    /// </summary>
    public virtual Domain.Model.EnigmaMachine Create(EnigmaConfigurationDto configuration)
    {
        throw new NotImplementedException();
    }
}
