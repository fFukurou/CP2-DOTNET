using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OsTresMotoqueirosDoApocalipseVerde.Application.DTOs;
using OsTresMotoqueirosDoApocalipseVerde.Domain.Entities;
using OsTresMotoqueirosDoApocalipseVerde.Infraestructure;

namespace OsTresMotoqueirosDoApocalipseVerde.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public MotoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarMoto([FromBody] CreateMotoDto motoDto)
        {
            Moto moto = _mapper.Map<Moto>(motoDto);
            _context.Motos.Add(moto);
            _context.SaveChanges();

            var readMotoDto = _mapper.Map<ReadMotoDto>(moto);
            return CreatedAtAction(nameof(RecuperarMotoPorId), new { Id = moto.Id }, readMotoDto);

        }

        [HttpGet]
        public IEnumerable<ReadMotoDto> RecuperarMotos()
        {
            return _mapper.Map<List<ReadMotoDto>>(_context.Motos.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarMotoPorId(int id)
        {
            Moto moto = _context.Motos.FirstOrDefault(moto => moto.Id == id);
            if (moto != null)
            {
                ReadMotoDto motoDto = _mapper.Map<ReadMotoDto>(moto);
                return Ok(motoDto);
            }
            return NotFound();
        }


        [HttpPut("{id}")]
        public IActionResult AtualizarMoto(int id, [FromBody] UpdateMotoDto motoDto)
        {
            Moto moto = _context.Motos.FirstOrDefault(motos => motos.Id == id);
            if (moto == null)
            {
                return NotFound();
            }
            _mapper.Map(motoDto, moto);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMoto(int id)
        {
            Moto endereco = _context.Motos.FirstOrDefault(motos => motos.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
