using FluentValidation;
using FluentValidationApp.MVC.Models;

namespace FluentValidationApp.MVC.FluentValidators;

public class CustomerValidator : AbstractValidator<Customer>
{
    public string NotEmptyMessage = "{PropertyName} alanı boş geçilemez...";
    public CustomerValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
        RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Email formatında bir değer girmelisiniz...");
        RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 60).WithMessage("Yaş değeri 18 ile 60 arasında bir değer almalıdır...");
    }
}
