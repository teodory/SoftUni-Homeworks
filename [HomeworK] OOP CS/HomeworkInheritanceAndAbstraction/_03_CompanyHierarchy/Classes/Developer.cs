using _03_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {
        private HashSet<Project> projects;

        public Developer (string id, string firstName, string lastName, decimal salary, Departament departament)
            :base(id, firstName, lastName, salary, departament)
        {
            this.projects = new HashSet<Project>();
        }

        public ISet<Project> Projects
        {
            get
            {
                return this.projects;
            }
        }

        public void AddProject(Project project)
        {
            this.projects.Add(project);
        }

        public override string ToString()
        {
            return string.Format("Position: {0}\r\n{1}\r\nProjects: {2}", this.GetType().Name, base.ToString(),
                string.Join(", ", this.Projects));
        }
    }
}
