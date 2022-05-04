using System.ComponentModel.DataAnnotations;

namespace AssistantApp.Models
{
    public class DateLessThanOrEqualToToday : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "لايمكن حجز موعد بتاريخ سابق";
        }

        protected override ValidationResult IsValid(object objValue,
                                                       ValidationContext validationContext)
        {
            var dateValue = objValue as DateTime? ?? new DateTime();

            //alter this as needed. I am doing the date comparison if the value is not null
            if (DateTime.Compare(DateTime.Now, dateValue.Date) > 0)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));

            }
           
            return ValidationResult.Success;
        }
    }
}
