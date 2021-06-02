using hwork8.EF;
using hwork8.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hwork8.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegisterController : ControllerBase
	{
		public static AtistContext context = new AtistContext();
        [HttpGet]
        public string Post(string login, string FIO, string email, string phone, string password)
        {
            IQueryable<Customer> customers = from customer in context.Customers
                                             where (customer.Login == login) && 
                                             (customer.FIO == FIO) &&
                                             (customer.ContactEmail == email) &&
                                             (customer.ContactPhone == phone)
                                             select customer;
            if (customers.Count() > 0)
            {
                return "User is exists!";
            }
            else
            {
                try
                {
                    Customer newCustomer = new Customer()
                    {
                        Login = login,
                        FIO = FIO,
                        ContactEmail = email,
                        ContactPhone = phone,
                        PasswordHash = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(password))
                };
                    context.Customers.Add(newCustomer);
                    context.SaveChangesAsync();
                    return "User is registered!";
                }
                catch
                {
                    return "User registration is failed!";
                }
            }
        }
    }
}
