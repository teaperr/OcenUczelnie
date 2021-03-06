﻿using System;
using OcenUczelnie.Core.Domain;

namespace OcenUczelnie.Infrastructure.DTO
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public UniversityDto University { get; set; }
    }
}