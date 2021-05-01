using Customers.Domain.Commands.Output;
using Customers.Domain.Queries;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customers.Domain.Commands.Result
{
    public class GetCustomerByIdCommandResult
    {
        public GetCustomerByIdCommandResult(bool success, string message, GetCustomerByIdCommandOutPut data, int statusCode, IEnumerable<Notification> notifications)
        {
            Success = success;
            Message = message;
            Data = data;
            StatusCode = statusCode;
            Notifications = notifications;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public GetCustomerByIdCommandOutPut Data { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<Notification> Notifications { get; set; }
    }
}
