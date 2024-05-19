using FluentValidation;
using FluentValidationApp.API.Models;

namespace FluentValidationApp.API.FluentValidators;

public class CustomerValidator : AbstractValidator<Customer>
{
	public string NotEmptyMessage { get; } = "{PropertyName} alanı boş bırakılmamalıdır...";
	public CustomerValidator()
	{
		RuleFor(c => c.Name).NotEmpty().WithMessage(NotEmptyMessage);
		RuleFor(c => c.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Email formatını hatalı girdiniz...");
		RuleFor(c => c.Age).InclusiveBetween(18, 60).WithMessage("Yaş alanına 18 ile 60 arasında bir değer girmelisiniz...");
		RuleFor(c => c.BirthDate).NotNull().WithMessage(NotEmptyMessage).Must(x =>
		{
			return DateTime.Now.AddYears(-18) >= x;
		}).WithMessage("Yaşınız 18 yaşından büyük olmalıdır...");
		RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} alanı Erkek için 1, Kadın için 2 olmalıdır...");
	}
}
