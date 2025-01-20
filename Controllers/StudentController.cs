using Microsoft.AspNetCore.Mvc;

namespace TesprakKPL.Controllers
{
    //API Untuk Students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>
        {
            new Student("Iqbal Nurhaq", "PS5", 1, 8000000, "2025-01-20", "JL Pegangsaan Timur 2", "Pending"),
            new Student("Iqbal Nurhaq", "NS1", 2, 5000000, "2025-01-20", "JL Pegangsaan Timur 22", "Shipped"),
            new Student("Iqbal Nurhaq", "NS2", 3, 9000000, "2025-01-20", "JL Pegangsaan Timur 23", "Processed"),
            new Student("Iqbal Nurhaq", "PS4", 4, 3000000, "2025-01-20", "JL Pegangsaan Timur 24", "Delivered"),
            new Student("Iqbal Nurhaq", "PS3", 5, 2000000, "2025-01-20", "JL Pegangsaan Timur 25", "Pending")
        };
        //API GET
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
        //API GET berdasarkan ID
        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            return _students[id];
        }
        //API Post untuk insert
        [HttpPost]
        public void PostStudent([FromBody] Student student)
        {
            _students.Add(student);
        }
        //API PUT untuk edit
        [HttpPut("{id}")]
        public void UpdateStudent(int id, [FromBody] Student student)
        {
            _students[id] = student;
        }
        //API Delete untuk delete data
        [HttpDelete]
        public void DeleteStudent(int id)
        {
            _students.RemoveAt(id);
        }


    }
}
