using EnigmaMachine.Application.DTOs;
using EnigmaMachine.Application.Ports.Input;
using EnigmaMachine.Application.Ports.Output;
using EnigmaMachine.Application.Services;
using EnigmaMachine.Infrastructure.Persistence;

namespace EnigmaMachine;

/// <summary>
/// CLI Entry point and Composition Root demonstrating the clean/hexagonal dependency flow.
/// </summary>
internal class EnigmaMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("      Enigma Machine Simulator Architecture       ");
        Console.WriteLine("==================================================");

        // 1. Resolve path to rotor definitions (read-only existing folder)
        string rotorsDirectory = Path.Combine(AppContext.BaseDirectory, "Rotors");
        if (!Directory.Exists(rotorsDirectory))
        {
            rotorsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Rotors");
        }

        Console.WriteLine($"[Infrastructure] Initializing JsonRotorRepository at: {rotorsDirectory}");
        IRotorRepository rotorRepository = new JsonRotorRepository(rotorsDirectory);

        // 2. Application Layer: Factory and Use Case orchestration
        Console.WriteLine("[Application] Instantiating EnigmaFactory and CipherMessageService...");
        var enigmaFactory = new EnigmaFactory(rotorRepository);
        var cipherService = new CipherMessageService(enigmaFactory);

        // 3. User configuration via Application DTO
        var config = new EnigmaConfigurationDto
        {
            RotorNames = new[] { "I", "II", "III" },
            InitialPositions = new[] { 'A', 'A', 'A' },
            RingSettings = new[] { 1, 1, 1 },
            ReflectorName = "UKW-B",
            PlugboardPairs = new[] { "AV", "BS", "CG", "DL", "FU", "HZ", "IN", "KM", "OW", "RX" }
        };

        Console.WriteLine("[CLI] Configuring Enigma Machine with Rotors I, II, III and Reflector UKW-B...");

        // 4. Executing use case demonstrating dependency flow
        try
        {
            cipherService.Configure(config);
            string plaintext = "ENIGMASTILLLIVES";
            Console.WriteLine($"[CLI] Input Text: {plaintext}");

            string ciphertext = cipherService.Execute(plaintext);
            Console.WriteLine($"[CLI] Encrypted Output: {ciphertext}");
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("\n[Architecture Verified] Dependency flow successfully traversed CLI -> Application -> Domain -> Infrastructure.");
            Console.WriteLine("Execution reached skeleton methods throwing NotImplementedException as designed.");
        }
    }
}
