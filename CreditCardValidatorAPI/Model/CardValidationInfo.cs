namespace CreditCardValidatorAPI.Model
{
    public class CardValidationInfo
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public int Length { get; set; }
        public string StartWith { get; set; }
    }
}
