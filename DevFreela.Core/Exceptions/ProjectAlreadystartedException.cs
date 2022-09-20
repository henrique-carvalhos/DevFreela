using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadystartedException : Exception
    {
        public ProjectAlreadystartedException() : base("Project is already in Started status")
        {

        }
    }
}
