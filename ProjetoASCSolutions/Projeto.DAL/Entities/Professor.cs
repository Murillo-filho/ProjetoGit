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
    /// Classe de Entidade (Professor)
    /// </summary>
    [Table("Professor")]
    public class Professor
    {
        #region Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdProfessor")]
        public int IdProfessor { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NomeProfessor")]
        public string Nome { get; set; }

        [Required]
        [Column("IdDisciplina")]
        public int IdDisciplina { get; set; }

        [Required]
        [Column("IdDisciplinaFK")]
        public int IdDisciplinaFK { get; set; }
        #endregion

        #region Relacionamento

        [ForeignKey("IdDisciplina")]
        public virtual Disciplina Disciplina { get; set; }
        #endregion

        #region Contrutores (Overload)

        public Professor()
        {

        }

        public Professor(string Nome, int IdDisciplina)
        {
            this.Nome = Nome;
            this.IdDisciplina = IdDisciplina;
        }

        #endregion
    }
}
