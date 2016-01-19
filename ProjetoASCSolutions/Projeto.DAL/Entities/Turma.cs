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
    /// Classe de Entidade (Turma)
    /// </summary>
    [Table("Turma")]
    public class Turma
    {
        #region Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdTurma")]
        public int IdTurma { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NomeTurma")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(5)]
        [Column("Turno")]
        public string Turno { get; set; }
       
        [Required]
        [MaxLength(4)]
        public string Ano { get; set; }

        #endregion

        #region Relacionamento
        public virtual ICollection<Aluno> Aluno { get; set; }
        public virtual ICollection<Disciplina> Disciplina { get; set; }
        #endregion

        #region Contrutores (Overload)
        public Turma()
        {

        }

        public Turma(string Nome, string Turno, string Ano)
        {
            this.Nome = Nome;
            this.Turno = Turno;
            this.Ano = Ano;
        }
        #endregion
    }
}
