﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClueGoTesting.Data;
using ClueGoTesting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClueGoTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClueController : ControllerBase
    {
        private readonly GameContext _dbContext;
        public ClueController(GameContext context)
        {
            _dbContext = context;
        }
        // GET: api/Clue
        [HttpGet]
        public ActionResult<List<Clue>> GetAll()
        {
            return _dbContext.Clues.ToList();
        }

      

        // PUT: api/Clue/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

       
    }
}
