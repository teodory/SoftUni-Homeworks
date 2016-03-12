using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    class Project
    {
   
        private string name;
        private DateTime startDate;
        private string details;
        private bool openProject;

        public Project(string name, DateTime startDate, string details)
        {
            this.Name = name;
            this.Details = details;
            this.startDate = startDate;
            this.openProject = true; ;
        }

        public string Name
        {
            get;
            set;
        }
        public string Details
        {
            get;
            set;
        }

        public void CloseProject()
        {
            this.openProject = false;
        }

        public override string ToString()
        {
            return string.Format("Project Name: {0}, Start Date: {1}, Status: {2}, Details: {3}",
                this.Name, this.startDate, (this.openProject ? "Open" : "Close") , this.Details);
        }
    }
}
