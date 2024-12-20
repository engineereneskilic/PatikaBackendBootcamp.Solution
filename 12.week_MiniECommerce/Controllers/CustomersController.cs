﻿using _12.week_MiniECommerce.Data;
using _12.week_MiniECommerce.Dto;
using _12.week_MiniECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _12.week_MiniECommerce.Controllers
{
    public class CustomersController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public CustomersController(ECommerceContext context)
        {
            _context = context;
        }

        [HttpGet("id")]
        public async Task<ActionResult<Customer>> GetById(int id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (customer is null) return NotFound();

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Create(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            // kaydettikten sonra yeni kaydın bilgilerine tekrar ulaşalım diye
            return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
        }


        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> GetCustomers([FromQuery] CustomerFilterDTO filter)
        {
            var query = _context.Customers.AsQueryable();

            if(filter.StartDate.HasValue)
            {
                query = query.Where(c => c.SignUpDate >= filter.StartDate.Value);
            }

            if(filter.EndDate.HasValue)
            {
                query = query.Where(c => c.SignUpDate <= filter.EndDate.Value);
            }

            if(string.IsNullOrWhiteSpace(filter.NameSearch))
            {
                query = query.Where(c => c.FirstName.Contains(filter.NameSearch) || c.LastName.Contains(filter.NameSearch));
            }
            if(!string.IsNullOrWhiteSpace(filter.EmailSearch))
            {
                query = query.Where(c => c.Email.Contains(filter.EmailSearch));
            }

            query = query.OrderBy(c => c.LastName)
                         .ThenBy(c => c.FirstName);

            var totalCount = await query.CountAsync();

            var totalPages = (int)Math.Ceiling(totalCount / (double)filter.PageSize);

            var customers = await query
                                    .Skip((filter.Page - 1) * filter.PageSize)
                                    .Take(filter.PageSize)
                                    .Select(c => new CustomerDto
                                    {
                                        Id = c.Id,
                                        Email = c.Email,
                                        FullName = $"{c.FirstName} {c.LastName}",
                                        SignUpDate = c.SignUpDate,
                                        Orders = c.Orders.ToList()
                                    }).ToListAsync();


            var response = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = filter.Page,
                PageSize = filter.PageSize,
                Customers = customers
            };

            return Ok(response);

            /*
             * api/customers
             * api/customers?startDate=2023-04-04?nameSearch=murat
             * 
             * 
             * 
             * 
             * 
             * */
        }

    }
}
