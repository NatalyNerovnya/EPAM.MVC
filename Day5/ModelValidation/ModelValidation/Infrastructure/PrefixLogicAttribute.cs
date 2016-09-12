using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ModelValidation.Infrastructure
{
    public class PrefixLogicAttribute : StringLengthAttribute
    {
        public PrefixLogicAttribute(int maximumLength) : base(maximumLength)
        {
        }

        public override bool IsValid(object value)
        {
            var input = value as string;
            return input != null && base.IsValid(value) && Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
    }
}