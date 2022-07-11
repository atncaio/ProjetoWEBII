using Microsoft.AspNetCore.Mvc.Rendering;
using WEBII.Data;

namespace WEBII.Pages.Disciplinas
{
    public class DisciplinaMVVM
    {
        public Disciplina Disciplina { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<SelectListItem> MyProperty { get; set; }
    }

}