namespace Flex_TEST.Infra
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public bool IsFailed => !IsSuccess;

        public string ErrorMessage { get; set; }

        public static Result Success()=> new Result { IsSuccess = true };

        public static Result Fail(string errormessage) => new Result { IsSuccess = false, ErrorMessage = errormessage };
    }
}
