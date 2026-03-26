using LabWork20.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabWork20.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private static List<Cat> _cats =
        [
            new() { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
            new() { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
            new() { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
            new() { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
            new() { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
            new() { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветный", Age = 6 },
            new() { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
            new() { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
            new() { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
            new() { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
        ];

        // GET: api/<CatsController>
        [HttpGet]
        public ActionResult<IEnumerable<Cat>> GetAll([FromQuery] int? page, [FromQuery] int? pageSize)
        {
            if (page == null || pageSize == null)
                return _cats;
            if (page < 1 || pageSize < 1)
                return NotFound();
            var pagedCats = _cats.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value).ToList();
            return Ok(pagedCats);
        }

        // GET api/<CatsController>/5
        [HttpGet("{id:int}")]
        public ActionResult<Cat> GetById([FromRoute]int id)
        {
            if (id > _cats.Count || id <= 0)
                return NotFound();
            return Ok(_cats.FirstOrDefault(cat => cat.Id == id));
        }

        // POST api/<CatsController>
        [HttpPost]
        public IActionResult Post([FromBody] Cat cat)
        {
            if (_cats.Any(c => c.Id == cat.Id))
                return Conflict($"{cat.Id} already exists");

            _cats.Add(cat);

            return CreatedAtAction(nameof(GetById), new { id = cat.Id }, cat);

        }

        // PUT api/<CatsController>/5
        [HttpPut("{id:int}")]
        public void Put([FromRoute] int id, [FromBody] Cat cat)
        {
        }

        // DELETE api/<CatsController>/5
        [HttpDelete("{id:int}")]
        public void Delete([FromRoute] int id)
        {
        }
    }
}
