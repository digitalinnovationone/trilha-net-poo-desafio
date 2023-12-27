using DesafioPOO.Models;
using Xunit;

namespace SmartphoneTeste
{
    public class SmartphoneTeste
    {
        [Fact]
        public void DeveLigarSmartphone()
        {
            // Arrange
            var smartphone = new TestSmartphone("123456789", "Modelo X", "IMEI12345", 64);

            // Act e Assert
            Assert.Throws<NotImplementedException>(() => smartphone.Ligar());
        }

        [Fact]
        public void DeveReceberLigacao()
        {
            // Arrange
            var smartphone = new TestSmartphone("123456789", "Modelo X", "IMEI12345", 64);

            // Act e Assert
            Assert.Throws<NotImplementedException>(() => smartphone.ReceberLigacao());
        }
    }

    public class TestSmartphone : Smartphone
    {
        public TestSmartphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implementação só para evitar erros de compilação.
            throw new NotImplementedException();
        }
    }
}
