﻿using Newtonsoft.Json;
using System;
using System.Text;
using zuri_week_1.DTO_s;
using zuri_week_1.Model;

namespace zuri_week_1.Service
{
    public class ArithemeticOperations : IArithemeticOperations
    {
        public ResponseDto BasicOperation(InputDto input)
        {
            var res = new ResponseDto();
            res.SlackUserName = "kehinde-dimeji";
            if (input.operation_type.ToLower().Contains("add") || input.operation_type.ToLower().Contains("addition"))
            {
                res.Result = input.x + input.y;
                res.Operation_type = OperationType.Addition;


            }
            else if (input.operation_type.ToLower().Contains("subtract") || input.operation_type.ToLower().Contains("subtraction"))
            {

                res.Result = input.x - input.y;
                res.Operation_type = OperationType.Subtraction;


            }
            else if (input.operation_type.ToLower().Contains("multiply") || input.operation_type.ToLower().Contains("multiplication"))
            {

                res.Result = input.x * input.y;
                res.Operation_type = OperationType.Multiplication;
            }
            else
            {
                res.Result = 00;
            }
            return res;
        }
      
        //public ResponseDto BasicOperation(InputDto input)
        //{
        //    var res = new ResponseDto();
        //    var cal = input.operation_type == OperationType.Addition ? input.x + input.y
        //                 : input.operation_type == OperationType.Subtraction ? input.x - input.y
        //                 : input.operation_type == OperationType.Multiplication ? input.x * input.y
        //                 : 00;
        //    res.SlackUserName = "kehinde-dimeji";
        //    res.Result = cal;
        //    res.Operation_type = input.operation_type;
        //    return res;
        //}
    }
}
