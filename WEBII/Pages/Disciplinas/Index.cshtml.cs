﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEBII;
using WEBII.Data;

namespace WEBII.Pages.Disciplinas
{
    public class IndexModel : PageModel
    {
        private readonly WEBII.Data.Contexto _context;

        public IndexModel(WEBII.Data.Contexto context)
        {
            _context = context;
        }

        public IList<Disciplina> Disciplina { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Disciplina != null)
            {
                Disciplina = await _context.Disciplina.ToListAsync();
            }
        }
    }
}
