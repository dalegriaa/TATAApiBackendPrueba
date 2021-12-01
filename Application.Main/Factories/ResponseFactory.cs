using System;
using System.Collections.Generic;
using System.Text;
using Transversal.Common;

namespace Application.Main.Factories
{
    public static class ResponseFactory
    {
        public static Response<string> GetReponse(string numberTimesRepeat, bool isSuccess, string message)
        {
            return new Response<string>
            {
                Data = numberTimesRepeat,
                IsSuccess = isSuccess,
                Message = message
            };
        }
        

        
    }
}
