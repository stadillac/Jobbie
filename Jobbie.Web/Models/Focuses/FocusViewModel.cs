﻿using Jobbie.Db.Models;

namespace Jobbie.Web.Models
{
    public class FocusViewModel
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DisciplineViewModel? Discipline { get; set; }
    }
}
