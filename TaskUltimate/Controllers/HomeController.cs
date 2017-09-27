using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskUltimate.Dtos;
using TaskUltimate.Models;

namespace TaskUltimate.Controllers
{
    public class HomeController : ApiController
    {
       TraineeContext context;

        
        
        public HomeController()
        {
            context = new TraineeContext();
        }

        public IEnumerable<TraineeDto> GetAllLearners()
        {
           
            
           return context.TraineeVMs.ToList().Select(Mapper.Map<TraineeVM, TraineeDto>);

        }
      



        public IHttpActionResult GetLearner(int id)
        {
            var customer = context.TraineeVMs.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return BadRequest();
            }
            return Ok(Mapper.Map<TraineeVM, TraineeDto>(customer));
        }

        [HttpPost]
        public IHttpActionResult CreateLearner(TraineeDto learnerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<TraineeDto, TraineeVM>(learnerDto);
            context.TraineeVMs.Add(customer);
            context.SaveChanges();
            learnerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), learnerDto);


        }

        [HttpPut]
        public void UpdateLearner(int id, TraineeDto learnerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var learnerinDb = context.TraineeVMs.SingleOrDefault(c => c.Id == id);
            if (learnerinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(learnerDto, learnerinDb);
            context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteLearner(int id)
        {
            var customerinDb = context.TraineeVMs.SingleOrDefault(c => c.Id == id);
            if (customerinDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            context.TraineeVMs.Remove(customerinDb);
            context.SaveChanges();

        }


    }
}

