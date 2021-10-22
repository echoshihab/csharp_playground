﻿using System;
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
                StudentName = "Test"
            };

            StudentDb studentDb = new StudentDb();

            mapper.ModelToDomainMap<StudentDto, StudentDb>(studentDto);

            var json = JsonSerializer.Serialize(studentDb);


            Console.WriteLine(json);
        }
    }
}