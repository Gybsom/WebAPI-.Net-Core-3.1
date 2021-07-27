using ApiTesteSigna.Models;
using System.Collections.Generic;

namespace ApiTesteSigna.IServices
{
    public interface IPetsService
    {
        // Owners //
        IEnumerable<Owner> GetOwners();

        Owner GetOwnerById(int id);


        // Cats //
        IEnumerable<Cat> GetCats();

        Cat GetCatById(int id);

        Cat AddCat(Cat cat);

        Cat UpdateCat(Cat cat);

        Cat DeleteCat(int id);


        // Dogs //
        IEnumerable<Dog> GetDogs();

        Dog GetDogById(int id);

        Dog AddDog(Dog dog);

        Dog UpdateDog(Dog dog);

        Dog DeleteDog(int id);

    }
}
