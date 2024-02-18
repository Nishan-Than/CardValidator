using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Manager
{
    public interface IValidationInfoManager 
    {
        IEnumerable<ValidationInfo> GetAllValidation();
    }
}
