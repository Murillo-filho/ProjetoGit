using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DAL.Entities
{
    /// <summary>
    /// Classe de Entidade (Aluno)
    /// </summary>
    [Table("Aluno")]
    public class Aluno
    {
        #region Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdAluno")]
        public int IdAluno { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NomeAluno")]
        public string Nome { get; set; }

        [Required]
        [Column("IdTurmaFK")]
        public int IdTurmaFK { get; set; }
     
        #endregion

        #region Relacionamentos
        
        public virtual Turma Turma { get; set; }
      
        #endregion

        #region Construtores (OverLoad)

        public Aluno()
        {
                
        }

        public Aluno(string Nome, int IdTurma)
        {
            this.Nome = Nome;
            this.IdTurmaFK = IdTurma;
        }

        #endregion
    }
}
