using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Manager
{
    public class ValidationInfoManager
    {
        private readonly CardValidatorContext _cardValidatorContext;

        public ValidationInfoManager(CardValidatorContext cardValidatorContext)
        {
            _cardValidatorContext = cardValidatorContext;
        }
        public IEnumerable<ValidationInfo> GetAllValidation()
        {
            return _cardValidatorContext.ValidationInfos.ToList();
        }
    }
}
