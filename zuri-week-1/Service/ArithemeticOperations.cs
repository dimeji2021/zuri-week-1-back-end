using zuri_week_1.DTO_s;

namespace zuri_week_1.Service
{
    public class ArithemeticOperations : IArithemeticOperations
    {
        public ResponseDto BasicOperation(InputDto input)
        {
            int cal = input.operation_type==OperationType.Addition? input.x + input.y :
                      input.operation_type == OperationType.Subtraction? input.x - input.y :
                      input.x * input.y;
            var res = new ResponseDto
            {
                SlackUserName = "kehinde-dimeji",
                Result = cal,
                operation_type = input.operation_type.ToString()
            };
            return res;
        }
    }
}
