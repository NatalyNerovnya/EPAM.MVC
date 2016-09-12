using ModelValidation.Models;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Infrastructure
{
    public class VoucherValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var model = value as Voucher;
            if (model == null)
            {
                return false;
            }

            if(model.Prefix != null && model.Postfix != null && model.Prefix.Length + model.Postfix.Length > 6)
            {
                ErrorMessage = "Prefix, Postfix length is too long";
                return false;
            }
            return true;
        }
    }
}