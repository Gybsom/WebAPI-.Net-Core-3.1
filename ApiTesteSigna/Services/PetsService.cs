using ApiTesteSigna.IServices;
using ApiTesteSigna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesteSigna.Services
{
    public class PetsService :IPetsService
    {
        PetsContext petsContext;

        public PetsService(PetsContext _db)
        {
            petsContext = _db;
        }


        // Owners //
        public IEnumerable<Owner> GetOwners()
        {
            var owner = petsContext.Owners.ToList();
            return owner;
        }

        public Owner GetOwnerById(int id)
        {
            if (id > 0)
            {
                var owner = petsContext.Owners.FirstOrDefault(x => x.Id == id);
                return owner;
            }
            return null;
        }


        // Cats //
        public IEnumerable<Cat> GetCats() {
            var cat = petsContext.Cats.ToList();
            return cat;
        }

        public Cat GetCatById(int id)
        {
            if (id > 0)
            {
                var cat = petsContext.Cats.FirstOrDefault(x => x.Id == id);
                return cat;
            }
            return null;
        }

        public Cat AddCat(Cat cat)
        {
            if(cat != null)
            {
                try
                {
                    petsContext.Cats.Add(cat);
                    petsContext.SaveChanges();
                    return cat;
                }
                catch (Exception e)
                {
                    throw new Exception("Não foi possível gravar as informações.", e);
                }
            }
            return null;
        }

        public Cat UpdateCat(Cat cat)
        {
            if (cat != null)
            {
                try
                {
                    petsContext.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    petsContext.SaveChanges();
                    return cat;
                }
                catch (Exception e)
                {
                    throw new Exception("Não foi possível atualizar as informações.", e);
                }
            }
            return null;
        }

        public Cat DeleteCat(int id)
        {
            if (id > 0)
            {
                try
                {
                    var cat = petsContext.Cats.FirstOrDefault(x => x.Id == id);
                    petsContext.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    petsContext.SaveChanges();
                    return cat;
                }
                catch(Exception e)
                {
                    throw new Exception("Não foi possível deletar o registro.", e);
                }
            }
            return null;
        }


        // Dogs //
        public IEnumerable<Dog> GetDogs()
        {
            var dog = petsContext.Dogs.ToList();
            return dog;
        }

        public Dog GetDogById(int id)
        {
            if (id > 0)
            {
                var dog = petsContext.Dogs.FirstOrDefault(x => x.Id == id);
                return dog;
            }
            return null;
        }

        public Dog AddDog(Dog dog)
        {
            if (dog != null)
            {
                try
                {
                    petsContext.Dogs.Add(dog);
                    petsContext.SaveChanges();
                    return dog;
                }
                catch (Exception e)
                {
                    throw new Exception("Não foi possível gravar as informações.", e);
                }
            }
            return null;
        }

        public Dog UpdateDog(Dog dog)
        {
            if (dog != null)
            {
                try
                {
                    petsContext.Entry(dog).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    petsContext.SaveChanges();
                    return dog;
                }
                catch (Exception e)
                {
                    throw new Exception("Não foi possível atualizar as informações.", e);
                }
            }
            return null;
        }

        public Dog DeleteDog(int id)
        {
            if (id > 0)
            {
                try
                {
                    var dog = petsContext.Dogs.FirstOrDefault(x => x.Id == id);
                    petsContext.Entry(dog).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    petsContext.SaveChanges();
                    return dog;
                }
                catch (Exception e)
                {
                    throw new Exception("Não foi possível deletar o registro.", e);
                }
            }
            return null;
        }
    }
}
