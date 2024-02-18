using CreditCardValidatorAPI.Model;
using DataLayer.Manager;

namespace CreditCardValidatorAPI.Services
{
    public class ValidationService : IValidationService
    {
        private readonly List<CardValidationInfo> _validationInfos;
        //private readonly ValidationInfoManager _validationInfoManager;
        public ValidationService(/*ValidationInfoManager validationInfoManager*/)
        {
            //_validationInfoManager = validationInfoManager;

            //var val = _validationInfoManager.GetAllValidation();
            _validationInfos = new List<CardValidationInfo>()
            {
                new CardValidationInfo(){
                Id = 1,
                CardType = "Visa",
                Length = 16,
                StartWith = "4",
                }
            };
        }

        public ApiResponse ValidateCard(string cardNo)
        {
            var response = new ApiResponse();

            try
            {
                int nDigits = cardNo.Length;

                var lengthList = _validationInfos.Select(x => x.Length).Distinct().ToList();

                if(lengthList.Contains(nDigits))
                {
                    int nSum = 0;
                    bool isSecond = false;
                    for (int i = nDigits - 1; i >= 0; i--)
                    {

                        int d = cardNo[i] - '0';

                        if (isSecond == true)
                            d = d * 2;

                        nSum += d / 10;
                        nSum += d % 10;

                        isSecond = !isSecond;
                    }

                    if(nSum % 10 == 0)
                    {
                        response.message = "validated successfully";
                    }
                    else
                        response.message = "";
                }
                else
                    response.message = "inValid Card";
            }
            catch (Exception ex)
            {
                response.message = ex.Message;
            }

            return response;

        }
    }
}
