﻿using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
