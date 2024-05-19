using FluentValidation;
using FluentValidationApp.API.Models;

namespace FluentValidationApp.API.FluentValidators;

public class ProductValidator : AbstractValidator<Product>
{
	public string NotEmptyMessage { get; } = "{PropertyName} alanı boş geçilemez.";
	public ProductValidator()
	{
		RuleFor(x => x.ProductName).NotEmpty().WithMessage(NotEmptyMessage);
		RuleFor(x => x.Description).NotEmpty().WithMessage(NotEmptyMessage);
		RuleFor(x => x.Price).NotEmpty().WithMessage(NotEmptyMessage).PrecisionScale(9,2,false).WithMessage("Ondalıklı kısım 2 basamaklı olmalıdır...");
		RuleFor(x => x.Stock).NotEmpty().WithMessage(NotEmptyMessage).GreaterThanOrEqualTo(0).WithMessage("Negatif bir değer girilemez...");
	}
}
