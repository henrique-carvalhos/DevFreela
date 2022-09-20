using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {

        }
        public int Id { get; private set; }//Todas as classes irão utilizar Id. para evitar redundancias.
    }
}
