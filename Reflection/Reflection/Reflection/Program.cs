using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Reflection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
           

            
            var mapper = new ModelMapper();

            StudentDto studentDto = new StudentDto()
            {
                StudentId = 1,
                StudentName = "Test",
                Courses = new List<string>()
                {
                    "Math", "Science"
                },
                Clubs = new []
                {
                    "Chess",
                    "Jeopardy"
                }
            };

            StudentDb studentDb = mapper.ModelToDomainMap<StudentDto, StudentDb>(studentDto);

            var json = JsonSerializer.Serialize(studentDb);


            Console.WriteLine(json);
        }
    }
}
