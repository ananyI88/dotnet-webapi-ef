using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.DTOs.Customer;
using dotnet_webapi_ef.Models;

namespace dotnet_webapi_ef.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerDTO ToCustomerDTO(this Customer customer)
        {
            return new CustomerDTO
            {
                Idx = customer.Idx,
                Fullname = customer.Fullname,
                Phone = customer.Phone,
                Email = customer.Email,
                Image = customer.Image
            };
        }
    }
}