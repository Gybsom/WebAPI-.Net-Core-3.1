using ApiTesteSigna.IServices;
using ApiTesteSigna.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesteSigna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetsService petsService;

        public PetsController(IPetsService pets)
        {
            petsService = pets;
        }

        // Rotas - Owners //
        [HttpGet]
        [Route("[action]")]
        [Route("/api/Pets/GetAllOwners")]
        public IEnumerable<Owner> GetOwners()
        {
            return petsService.GetOwners();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/Pets/GetOwnerById/{id}")]
        public Owner GetOwnerById(int id)
        {
            return petsService.GetOwnerById(id);
        }


        // Rotas - Cats //
        [HttpGet]
        [Route("[action]")]
        [Route("/api/Pets/GetAllCats")]
        public IEnumerable<Cat> GetCats()
        {
            return petsService.GetCats();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/Pets/GetCatById/{id}")]
        public Cat GetCatById(int id)
        {
            return petsService.GetCatById(id);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("/api/Pets/AddCat")]
        public Cat AddCats(Cat cat)
        {
            return petsService.AddCat(cat);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("/api/Pets/UpdateCat")]
        public Cat UpdateCats(Cat cat)
        {
            return petsService.UpdateCat(cat);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("/api/Pets/DeleteCat")]
        public Cat DeleteCats(int id)
        {
            return petsService.DeleteCat(id);
        }


        // Rotas - Dogs //
        [HttpGet]
        [Route("[action]")]
        [Route("/api/Pets/GetAllDogs")]
        public IEnumerable<Dog> GetDogs()
        {
            return petsService.GetDogs();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/Pets/GetDogById/{id}")]
        public Dog GetDogById(int id)
        {
            return petsService.GetDogById(id);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("/api/Pets/AddDog")]
        public Dog AddDogs(Dog dog)
        {
            return petsService.AddDog(dog);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("/api/Pets/UpdateDog")]
        public Dog UpdateDogs(Dog dog)
        {
            return petsService.UpdateDog(dog);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("/api/Pets/DeleteDog")]
        public Dog DeleteDogs(int id)
        {
            return petsService.DeleteDog(id);
        }
    }
}
