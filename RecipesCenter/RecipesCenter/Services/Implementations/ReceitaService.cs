using System;
using System.Collections.Generic;
using RecipesCenter.Model;

namespace RecipesCenter.Services.Implementations
{
    public class ReceitaService : IReceitaService
    {
        // Contador que gera um ID fake
        private volatile int count;

        // Método que cria uma receita
        public Receita Create(Receita receita)
        {
            return receita;
        }
        
        // 
        public void Delete(int id)
        {
           
        }

        List<Receita> IReceitaService.FindAll()
        {
            List<Receita> receitas = new List<Receita>();

            for (int i = 1; i <= 10; i++)
            {
                receitas.Add(MockReceita(i));
            }

            return receitas;
        }
        
        public Receita FindById(int id)
        {
            return MockReceita(id);
        }

        public Receita Update(Receita receita)
        {
            return receita;
        }
        
        private Receita MockReceita(int id)
        {
            return new Receita()
            {
                Id = id,
                Nome = "Lasanha - " + id.ToString(),
                TempoPreparoEmMinutos = 60,
                RendimentoEmPorcoes = 10,
                Ingredientes = "Massa de lasanha; Molho de tomate, Carne moída, Queijo, Presunto.",
                ModoDePreparo = "Cozinhe a massa; Monte a lasanha, Asse no forno por 40 min."
            };
        }
    }
}
