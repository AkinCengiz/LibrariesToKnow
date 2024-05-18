using FluentValidation;
using FluentValidationApp.MVC.Models;

namespace FluentValidationApp.MVC.FluentValidators;

public class AddressValidator : AbstractValidator<Address>
{
    public string NotEmptyMessage { get; } = "{PropertyName} alanı boş geçilmemelidir.";
    public AddressValidator()
    {
        RuleFor(x => x.City).NotEmpty().WithMessage(NotEmptyMessage).MinimumLength(3).WithMessage("Şehir bilgisi en az 3 karakter olmalıdır...");
        RuleFor(x => x.Town).NotEmpty().WithMessage(NotEmptyMessage);
        RuleFor(x => x.District).NotEmpty().WithMessage(NotEmptyMessage);
        RuleFor(x => x.Street).NotEmpty().WithMessage(NotEmptyMessage);
        RuleFor(x => x.BuildNumber).NotEmpty().WithMessage(NotEmptyMessage);
        RuleFor(x => x.ZipCode).NotEmpty().WithMessage(NotEmptyMessage).Length(5).WithMessage("Posta Kodu alanı 5 karakter olmalıdır...");
    }
}
