﻿namespace Monopoly.LiqPay.Requests
{
    using AutoMapper;
    using Monopoly.LiqPay.Models;

    [AutoMap(typeof(LiqPayCheckoutModel), ReverseMap = true)]
    public class LiqPayCheckoutRequest
    {
        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public string Order_Id { get; set; }
    }
}