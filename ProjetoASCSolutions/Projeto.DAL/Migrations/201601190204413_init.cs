namespace Projeto.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        IdAluno = c.Int(nullable: false, identity: true),
                        NomeAluno = c.String(nullable: false, maxLength: 50),
                        IdTurmaFK = c.Int(nullable: false),
                        Turma_IdTurma = c.Int(),
                    })
                .PrimaryKey(t => t.IdAluno)
                .ForeignKey("dbo.Turma", t => t.Turma_IdTurma)
                .Index(t => t.Turma_IdTurma);
            
            CreateTable(
                "dbo.Turma",
                c => new
                    {
                        IdTurma = c.Int(nullable: false, identity: true),
                        NomeTurma = c.String(nullable: false, maxLength: 50),
                        Turno = c.String(nullable: false, maxLength: 5),
                        Ano = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.IdTurma);
            
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        IdDisciplina = c.Int(nullable: false, identity: true),
                        NomeDisciplina = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdDisciplina);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        IdProfessor = c.Int(nullable: false, identity: true),
                        NomeProfessor = c.String(nullable: false, maxLength: 50),
                        IdDisciplina = c.Int(nullable: false),
                        IdDisciplinaFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProfessor)
                .ForeignKey("dbo.Disciplina", t => t.IdDisciplina, cascadeDelete: true)
                .Index(t => t.IdDisciplina);
            
            CreateTable(
                "dbo.DisciplinaTurmas",
                c => new
                    {
                        Disciplina_IdDisciplina = c.Int(nullable: false),
                        Turma_IdTurma = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Disciplina_IdDisciplina, t.Turma_IdTurma })
                .ForeignKey("dbo.Disciplina", t => t.Disciplina_IdDisciplina, cascadeDelete: true)
                .ForeignKey("dbo.Turma", t => t.Turma_IdTurma, cascadeDelete: true)
                .Index(t => t.Disciplina_IdDisciplina)
                .Index(t => t.Turma_IdTurma);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DisciplinaTurmas", "Turma_IdTurma", "dbo.Turma");
            DropForeignKey("dbo.DisciplinaTurmas", "Disciplina_IdDisciplina", "dbo.Disciplina");
            DropForeignKey("dbo.Professor", "IdDisciplina", "dbo.Disciplina");
            DropForeignKey("dbo.Aluno", "Turma_IdTurma", "dbo.Turma");
            DropIndex("dbo.DisciplinaTurmas", new[] { "Turma_IdTurma" });
            DropIndex("dbo.DisciplinaTurmas", new[] { "Disciplina_IdDisciplina" });
            DropIndex("dbo.Professor", new[] { "IdDisciplina" });
            DropIndex("dbo.Aluno", new[] { "Turma_IdTurma" });
            DropTable("dbo.DisciplinaTurmas");
            DropTable("dbo.Professor");
            DropTable("dbo.Disciplina");
            DropTable("dbo.Turma");
            DropTable("dbo.Aluno");
        }
    }
}
