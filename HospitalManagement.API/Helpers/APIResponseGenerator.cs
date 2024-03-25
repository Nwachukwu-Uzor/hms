﻿using HospitalManagement.API.Models;

namespace HospitalManagement.API.Helpers;

public static class APIResponseGenerator
{
    public static ApiResponseType<T> GenerateSuceessResponse<T>(T response, string message="")
    {
        return new ApiResponseType<T>
        {
            Data = response,
            Status = true,
            Message = message
        };
    }
    
    public static ApiResponseType<T> GenerateFailureResponse<T>(T response, string message="")
    {
        return new ApiResponseType<T>
        {
            Data = response,
            Status = true,
            Message = message
        };
    }

    public static ApiResponseType<object> GenerateEmptyResponse (bool status, object data, string message = "")
    {
        return new ApiResponseType<object>
        {
            Data = data,
            Status = status,
            Message = message
        };
    }
}
