using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;




namespace mynewapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly List<Fruit> fruits = new List<Fruit>();
        public FruitController()
        {
            fruits.Add(new Fruit()
            {
                Id = 1,
                fruit_ = "Mango",
                });
            fruits.Add(new Fruit()
            {
                Id = 2,
                fruit_ = "Apple",
                
            });
             fruits.Add(new Fruit()
            {
                Id = 3,
                fruit_ = "Kiwifruit",
                
            });
             fruits.Add(new Fruit()
            {
                Id = 4,
                fruit_ = " Plums",
                
            });
             fruits.Add(new Fruit()
            {
                Id = 5,
                fruit_ = " Apricot",
                
            });
              fruits.Add(new Fruit()
            {
                Id = 6,
                fruit_ = "Kumquat",
                
            });
              fruits.Add(new Fruit()
            {
                Id = 7,
                fruit_ = "Pomegranates",
                
            });
              fruits.Add(new Fruit()
            {
                Id = 8,
                fruit_ = "Avocado",
                
            });
              fruits.Add(new Fruit()
            {
                Id = 9,
                fruit_ = "Lemon",
                
            });
              fruits.Add(new Fruit()
            {
                Id = 10,
                fruit_ = "Pomelo",
                
            });
              fruits.Add(new Fruit()
            {
                Id = 11,
                fruit_ = "Bananas",
                
            });
              fruits.Add(new Fruit()
            {
                Id = 12,
                fruit_ = "Lime",
                
            });
            

        }
        [HttpGet]
        
        public ActionResult<IEnumerable<Fruit>> Get()
{
  if (fruits == null)
       return NotFound("No records");
        //public IEnumerable<Fruit> Get()
        
        //{
            return fruits;
        }
        [HttpGet("{id}", Name = "Get")]
        public Fruit Get(int id)
        {
            return fruits.Find(x => x.Id == id);
        }
  
    [HttpPost]
    public void PostOne([FromBody]int id)
    {

    }

      }
} 

