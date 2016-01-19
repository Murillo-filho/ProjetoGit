using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using Projeto.DAL.Entities;

namespace Projeto.DAL.DataSource
{
    /// <summary>
    /// Classe de conexão
    /// </summary>
    public class Conexao : DbContext
    {
        #region Construtor (overload)
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString)
        {

        }       
        #endregion

     
        
        
        #region Mapeamento
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        #endregion
     
        
    }
}
