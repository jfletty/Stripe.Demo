﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace StripeExample.Demo.Services.Clients
{
    public interface IRequestClient
    {
        Task<T> DoGet<T>(
            string baseUrl,
            string endpoint,
            KeyValuePair<string, string>? parameters = null,
            List<KeyValuePair<string, string>> headers = null) where T : class;
        
        Task<T> DoPost<T>(
            string baseUrl,
            string endpoint,
            List<KeyValuePair<string, string>> headers = null,
            string body = null) where T : class;
        
        Task<T> DoDelete<T>(
            string baseUrl,
            string endpoint,
            KeyValuePair<string, string> parameters,
            List<KeyValuePair<string, string>> headers = null) where T : class;
    }
}