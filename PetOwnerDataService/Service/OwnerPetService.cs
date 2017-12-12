using PetOwnerDataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace PetOwnerDataService.Service
{
    public class OwnerPetService: BaseService<OwnerPet>, IOwnerPetService
    {
        public async Task<List<OwnerPet>> GetAllOwnerPetList()
        {
            this.Url ="people.json";
            return await this.ReadAsAsync();
            //HttpResponseMessage response = await this.ReadAsAsync();
            //if (response.IsSuccessStatusCode)
            //{
            //    return await response.Content.ReadAsAsync<List<OwnerPet>>();
            //}
            //return null;
        }
    }
}