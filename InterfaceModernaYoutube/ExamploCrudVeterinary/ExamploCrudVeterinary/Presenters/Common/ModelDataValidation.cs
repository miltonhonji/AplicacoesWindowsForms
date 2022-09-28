using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ExamploCrudVeterinary.Presenters.Common
{
    public class ModelDataValidation
    {
        public void ValidateData(object model)
        {
            string errorMessage = String.Empty;
            List<ValidationResult> validationResultData = new List<ValidationResult>();
            ValidationContext validationContextData = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, validationContextData, validationResultData, true);

            if(isValid == false)
            {
                foreach (var item in validationResultData)               
                    errorMessage += $"- { item.ErrorMessage } \n ";
                throw new Exception(errorMessage);
            }
        }
    }
}
