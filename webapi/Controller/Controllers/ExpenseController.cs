﻿using Controller.Utils;
using Microsoft.AspNetCore.Mvc;
using Service.Models;

namespace Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : BaseController
    {
        private readonly ExpenseService _expenseService;

        public ExpenseController(ExpenseService expenseService)
        {
            _expenseService = expenseService;
        }
    }
}