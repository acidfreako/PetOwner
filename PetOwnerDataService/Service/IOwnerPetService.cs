using PetOwnerDataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PetOwnerDataService.Service
{
    public interface IOwnerPetService
    {
        Task<List<OwnerPet>> GetAllOwnerPetList();
    }
}