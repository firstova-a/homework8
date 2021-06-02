using hwork8.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hwork8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCustomerController : ControllerBase
    {
        public static AtistContext context = new AtistContext();

        [HttpGet]
        public List<Customer> Get()
        {
            IQueryable<Customer> customers = (from customer in context.Customers
                                              select customer).Take(10);
            List<Customer> result = new List<Customer>();
            if(customers!=null)
			{
                foreach (Customer customer in customers)
                {
                    result.Add(new Customer()
                    {
                        FIO = customer.FIO,
                        ContactEmail = customer.ContactEmail,
                        ContactPhone = customer.ContactPhone,
                        Login = customer.Login
                    });
                }
            }
            return result;
        }
    }
}