using RecipesCenter.Model;
using System.Collections.Generic;

namespace RecipesCenter.Services
{
    public interface IReceitaService
    {
        Receita Create(Receita receita);
        Receita FindById(int id);
        List<Receita> FindAll();
        Receita Update(Receita receita);
        void Delete(int id);
    }
}
