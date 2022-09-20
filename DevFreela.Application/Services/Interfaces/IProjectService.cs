using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService//Interface representando todas as funcionalidades do ProjetcController dentro de IProjectService
    {
        List<ProjetcViewModel> GetAll(string query);
        ProjectDetailsViewModel GetById(int id);
        int Create(NewProjectInputModel inputModel);
        void Update(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void CreatComment(CreateCommentInputModels inputModel);
        void Start(int id);
        void Finish(int id);

    }
}
