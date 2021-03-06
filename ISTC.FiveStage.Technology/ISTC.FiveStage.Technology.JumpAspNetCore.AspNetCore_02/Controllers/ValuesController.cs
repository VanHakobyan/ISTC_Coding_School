﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISTC.FiveStage.Technology.JumpAspNetCore.AspNetCore_02.Model;
using Microsoft.AspNetCore.Mvc;

namespace ISTC.FiveStage.Technology.JumpAspNetCore.AspNetCore_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values
        [HttpGet,Route("People")]
        public ActionResult People(string name, int age)
        {
            return NotFound(new People { Age = age, Name = name });
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return new Random().Next(0, id).ToString();
        }

        // PUT api/values/5
        [HttpPost]
        public ActionResult PostPeople([FromBody] People people)
        {
            return Ok(people);
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
