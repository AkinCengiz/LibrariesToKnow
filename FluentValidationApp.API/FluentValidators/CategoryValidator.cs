using FluentValidation;
using FluentValidationApp.API.Models;

namespace FluentValidationApp.API.FluentValidators;

public class CategoryValidator : AbstractValidator<Category>
{
	public string NotEmptyMessage { get; } = "{PropertyName} alanı boş geçilemez...";
	public CategoryValidator()
	{
		RuleFor(x => x.CategoryName).NotEmpty().WithMessage(NotEmptyMessage);
		RuleFor(x => x.Description).NotEmpty().WithMessage(NotEmptyMessage);
	}
}
