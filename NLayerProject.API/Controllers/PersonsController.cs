using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerProject.API.DTOs;
using NLayerProject.API.Filters;
using NLayerProject.Core.Models;
using NLayerProject.Core.Services;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _personService;

        private readonly IMapper _mapper;


        public PersonsController(IService<Person> service, IMapper mapper)
        {
            _personService = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<PersonsDto>>(persons));
        }


        // [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _personService.GetByIdAsycn(id);
            return Ok(_mapper.Map<PersonsDto>(person));

        }

        
        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save(PersonsDto personsDto)
        {
            var newPerson = await _personService.AddAsync(_mapper.Map<Person>(personsDto));
            return Created(string.Empty, _mapper.Map<PersonsDto>(newPerson));
        }

        [HttpPut]
        public IActionResult Update(PersonsDto personsDto)
        {
            var person = _personService.Update(_mapper.Map<Person>(personsDto));
            return NoContent();
        }


        // [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var person = _personService.GetByIdAsycn(id).Result;
            _personService.Remove(person);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult RemoveRange(PersonsDto personsDto)
        {
            _personService.RemoveRange(_mapper.Map<Person>(personsDto));
            return NoContent();
        }
    }
}