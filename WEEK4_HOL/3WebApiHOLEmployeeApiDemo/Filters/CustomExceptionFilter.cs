using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace EmployeeApiDemo.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string errorDetails = $"Exception: {context.Exception.Message}\n{context.Exception.StackTrace}";
            File.WriteAllText("error_log.txt", errorDetails);

            context.Result = new ObjectResult("An internal error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
