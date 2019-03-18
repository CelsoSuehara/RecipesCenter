using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesCenter.Model
{
    public class Receita
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TempoPreparoEmMinutos { get; set; }
        public int RendimentoEmPorcoes { get; set; }
        public string Ingredientes { get; set; }
        public string ModoDePreparo { get; set; }

    }
}
