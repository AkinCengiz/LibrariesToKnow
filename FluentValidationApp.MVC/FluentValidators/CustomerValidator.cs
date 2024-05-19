using FluentValidation;
using FluentValidationApp.MVC.Models;

namespace FluentValidationApp.MVC.FluentValidators;

public class CustomerValidator : AbstractValidator<Customer>
{
    public string NotEmptyMessage { get; } = "{PropertyName} alanı boş geçilemez...";
    public CustomerValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
        RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Email formatında bir değer girmelisiniz...");
        RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 60).WithMessage("Yaş değeri 18 ile 60 arasında bir değer almalıdır...");
        RuleFor(x => x.BirthDate).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
        {
            return DateTime.Now.AddYears(-18) >= x;
        }).WithMessage("Yaşınız 18 yaşından büyük olmalıdır...");
        RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());
        RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} alanı erkek için 1 kadın için 2 olmalıdır...");
    }
}
