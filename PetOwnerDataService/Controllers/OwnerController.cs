using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using PetOwnerDataService.Model;
using PetOwnerDataService.Service;
using PetOwnerDTO;
using System.Web.Http.Cors;

namespace PetOwnerDataService.Controllers
{
    [RoutePrefix("api/owner")]
    [EnableCors(origins: "http://localhost:65046", headers: "*", methods: "*")]
    public class OwnerController : ApiController
    {
        private IOwnerPetService _ownerPetService;

        public OwnerController()
        {

        }

        public OwnerController(IOwnerPetService ownerPetService)
        {
            _ownerPetService = ownerPetService;
        }

        [SwaggerOperation("GetAllOwnerPetList")]
        [HttpGet]
        [Route("get-all-owner-pet-list")]
        public async Task<OwnerPetList> GetAllOwnerPetList()
        {
            OwnerPetList result = new OwnerPetList();

            var ownerPetList= await _ownerPetService.GetAllOwnerPetList();

            var maleOwnerCatNameList = ownerPetList.Where(p => p.Gender == "Male" && p.Pets != null).SelectMany(x => x.Pets.Where(y => y.Type == "Cat")).ToList();
            var femaleOwnerCatNameList = ownerPetList.Where(p => p.Gender == "Female" && p.Pets != null).SelectMany(x => x.Pets.Where(y => y.Type == "Cat")).ToList();

            if (maleOwnerCatNameList.Count > 0)
            {
                result.MalePetList = new PetOwnerDTO.OwnerPet() { Gender = "Male" };
                result.MalePetList.PetNameList = maleOwnerCatNameList.Select(x => x.Name).OrderBy(x => x).ToList();
            }

            if (femaleOwnerCatNameList.Count > 0)
            {
                result.FemalePetList = new PetOwnerDTO.OwnerPet() { Gender = "Female" };
                result.FemalePetList.PetNameList = femaleOwnerCatNameList.Select(x => x.Name).OrderBy(x=>x).ToList();
            }
            return  result;
        }
    }
}
