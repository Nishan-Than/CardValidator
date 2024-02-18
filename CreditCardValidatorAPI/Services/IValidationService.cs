using CreditCardValidatorAPI.Model;

namespace CreditCardValidatorAPI.Services
{
    public interface IValidationService
    {
        ApiResponse ValidateCard (string cardNo);
    }
}
