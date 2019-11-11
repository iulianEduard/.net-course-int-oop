using OOP.Samples.AbstractizationSamples.Domain;

namespace OOP.Samples.AbstractizationSamples
{
    /*
     * Cannot inherince a sealed class
     */
    public class SealedUseCase //: SealedCustomer
    {
        public void Run()
        {
            var sealedCustomer = new SealedCustomer();
            sealedCustomer.Display();
        }
    }
}
