﻿using Microsoft.AspNetCore.Mvc;
using CSharpFunctionalExtensions;

namespace OpenCity.Report.Helpers {
    public static class HttpResultExtensions {
        public static IActionResult AsHttpResult(this Result result) {
            if(result.IsFailure) {
                return new BadRequestObjectResult(result.Error);
            }
            return new OkResult();
        }

        public static IActionResult AsHttpResult<T>(this Result<T> result) {
            if(result.IsFailure) {
                return new BadRequestObjectResult(result.Error);
            }
            return new OkObjectResult(result.Value);
        }
    }
}
