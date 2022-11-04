using System.Linq.Expressions;
using zuri_week_1.DTO_s;

namespace zuri_week_1.Service
{
    public class ArithemeticOperations : IArithemeticOperations
    {
        //public ResponseDto BasicOperation(InputDto input)
        //{
        //    var res = new ResponseDto();
        //    if (input.operation_type.ToLower().Contains("add") || input.operation_type.ToLower().Contains("addition"))
        //    {
        //        res.SlackUserName = "kehinde-dimeji";
        //        res.Result = input.x + input.y;
        //        res.Operation_type = OperationType.Addition;


        //    }
        //    else if (input.operation_type.ToLower().Contains("subtract") || input.operation_type.ToLower().Contains("subtraction"))
        //    {

        //        res.SlackUserName = "kehinde-dimeji";
        //        res.Result = input.x - input.y;
        //        res.Operation_type = OperationType.Subtraction;


        //    }
        //    else if (input.operation_type.ToLower().Contains("multiply") || input.operation_type.ToLower().Contains("multiplication"))
        //    {

        //        res.SlackUserName = "kehinde-dimeji";
        //        res.Result = input.x * input.y;
        //        res.Operation_type = OperationType.Multiplication;
        //    }
        //    return res;
        //}
        //public ResponseDto BasicOperation(InputDto input)
        //{
        //    var res = new ResponseDto();
        //    if (input.operation_type==OperationType.Addition)
        //    {
        //        res.SlackUserName = "kehinde-dimeji";
        //        res.Result = input.x + input.y;
        //        res.Operation_type = input.operation_type;


        //    }
        //    else if (input.operation_type == OperationType.Subtraction)
        //    {

        //        res.SlackUserName = "kehinde-dimeji";
        //        res.Result = input.x - input.y;
        //        res.Operation_type = input.operation_type;


        //    }
        //    else if (input.operation_type == OperationType.Multiplication)
        //    {

        //        res.SlackUserName = "kehinde-dimeji";
        //        res.Result = input.x * input.y;
        //        res.Operation_type = input.operation_type;
        //    }
        //    else
        //    {
        //        var cal = input.operation_type.ToString().ToLower().Contains("add") || input.operation_type.ToString().ToLower().Contains("addition") ? input.x + input.y
        //                : input.operation_type.ToString().ToLower().Contains("subtract") || input.operation_type.ToString().ToLower().Contains("subtraction") ? input.x - input.y
        //                : input.operation_type.ToString().ToLower().Contains("multiply") || input.operation_type.ToString().ToLower().Contains("multiplication") ? input.x * input.y
        //                : 00;
        //        res.SlackUserName = "kehinde-dimeji";
        //        res.Result = cal;
        //        res.Operation_type = OperationType.Addition;
        //    };
        ////    return res;
        //}
        public ResponseDto BasicOperation(InputDto input)
        {
            var res = new ResponseDto();
            var cal = input.operation_type==OperationType.Addition? input.x + input.y
                         : input.operation_type==OperationType.Subtraction? input.x - input.y
                         : input.operation_type==OperationType.Multiplication ? input.x * input.y
                         : 00;
            res.SlackUserName = "kehinde-dimeji";
            res.Result = cal;
            res.Operation_type = input.operation_type;
            return res;
        }
    }
}
