using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result:IResult
    { //Sonuna  this ile success i gönderirsek alttaki constracterda çalışır.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //Overloading: 2 constracter var ve iki imzayı dakullanabilir.
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
