﻿using Customers.Domain.Entities;
using Flunt.Notifications;
using System.Collections.Generic;

namespace Customers.Domain.Commands.Result
{
    public class SortCustomerByNameCommandResult
    {
        public SortCustomerByNameCommandResult(bool success, string message, List<CustomerEntity> data, int statusCode, IEnumerable<Notification> notifications)
        {
            Success = success;
            Message = message;
            Data = data;
            StatusCode = statusCode;
            Notifications = notifications;

        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<CustomerEntity> Data { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<Notification> Notifications { get; set; }
    }
}
