﻿namespace MyMongoDbProject.Dtos
{
    public class UpdateCustomerDto
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public decimal CustomerBalance { get; set; }
    }
}
