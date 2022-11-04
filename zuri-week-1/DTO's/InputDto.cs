using FluentValidation;
using zuri_week_1;

namespace zuri_week_1
{
    public class InputDto
    {
        public int x { get; set; }
        public int y { get; set; }
        public OperationType operation_type { get; set; }
    }
}
public class InputDtoValidator : AbstractValidator<InputDto>
{
    public InputDtoValidator()
    {
        RuleFor(s => s.x).NotNull();
        RuleFor(s => s.y).NotNull();
        RuleFor(s => s.operation_type).NotEmpty();

    }
}