using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : Controller
    {

        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;
        public PlatformController(IPlatformRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
        
            var platforms = _mapper.Map<IEnumerable<PlatformReadDto>>(_repository.GetAllPlatforms());
            return Ok(platforms);


        }

        [HttpGet("{platformId}",Name ="GetPlatformById")]
        public ActionResult<PlatformReadDto> GetPlatformById(int platformId)
        {
           var platform = _repository.GetPlatformById(platformId);
            if (platform != null)
            {
                return Ok(_mapper.Map<PlatformReadDto>(platform));
            }

            return NotFound();
        }



    }
}
