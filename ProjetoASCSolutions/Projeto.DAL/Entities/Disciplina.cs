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
    /// Classe de Entidade (Disciplina)
    /// </summary>
    [Table("Disciplina")]
    public class Disciplina
    {
        #region Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdDisciplina")]
        public int IdDisciplina { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NomeDisciplina")]
        public string Nome { get; set; }

        #endregion

        #region Relacionamentos

        public virtual ICollection<Professor> Professor { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
        #endregion

        #region Construtores (Overload)

        public Disciplina()
        {

        }

        public Disciplina(string Nome)
        {
            this.Nome = Nome;
        }
        #endregion
    }
}
