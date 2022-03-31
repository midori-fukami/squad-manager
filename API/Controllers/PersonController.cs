using API.Services;
using API.Validator;

using Common;

using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("create")]
        public IActionResult Create(PersonModel person)
        {
            PersonValidator validator = new PersonValidator();

            ValidationResult results = validator.Validate(person);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }

                return Ok(new { response = "ERROR" });
            }

            var personId = _personService.AddPerson(new PersonModel()
            {
                Name = person.Name,
                Email = person.Email,
                Type = person.Type
            });

            return Ok(new { response = "OK" });
        }

        [HttpPatch("update")]
        public IActionResult Update(PersonModel person)
        {
            _personService.UpdatePerson(person);

            return Ok(new { response = "OK" });
        }

        [HttpGet()]
        public IActionResult Get(int id)
        {
            var person = _personService.GetPerson(id);

            return Ok(person);
        }

        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            _personService.DeletePerson(id);

            return Ok(new { response = "OK" });
        }
    }
}
