using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Freela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project ("Meu proojeto ASPNET Core 1", "Minha descrição de Projeto 1", 1, 1, 10000),
                new Project ("Meu proojeto ASPNET Core 2", "Minha descrição de Projeto 2", 1, 1, 20000),
                new Project ("Meu proojeto ASPNET Core 3", "Minha descrição de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User ("Luis Felipe", "luisdev@luisdev.com", new DateTime(1998,12,7)),
                new User ("Henrique carvalho", "henrique@luisdev.com", new DateTime(1989,11,12)),
                new User ("Felipe luis", "feipe@luisdev.com", new DateTime(1950,2,4))
            };

            Skills = new List<Skill>
            {
                new Skill(".Net Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
