namespace Projeto.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Projeto.DAL.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto.DAL.DataSource.Conexao>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Projeto.DAL.DataSource.Conexao context)
        {
            #region Turma

            context.Turma.AddOrUpdate(

                new Turma("C101","Manhã","2014"),
                new Turma("C102","Tarde","2015"),
                new Turma("C103","Noite","2016")

                );

            #endregion

            #region Disciplina

            context.Disciplina.AddOrUpdate(
                
                new Disciplina("Matemática"),
                new Disciplina("Física"),
                new Disciplina("Geografia"),
                new Disciplina("História"),
                new Disciplina("CSharp")

                );


            #endregion

            #region Aluno

            context.Aluno.AddOrUpdate(
                
              new Aluno("Mauro",1),
              new Aluno("João",1),
              new Aluno("Joselito",1),
              new Aluno("Jetulio",1),
              new Aluno("Jorge",1),

              new Aluno("Maria",2),
              new Aluno("Marcela",2),
              new Aluno("Marta",2),
              new Aluno("Marlene",2),
              new Aluno("Miucha",2),

              new Aluno("Gabriel",3),
              new Aluno("Manuel",3),
              new Aluno("Katia",3),
              new Aluno("Silvia",3),
              new Aluno("Silvana",3)

            );
            #endregion

            #region Professor

           context.Professor.AddOrUpdate(

               new Professor("Carlos",1),
               new Professor("Rodolfo",2)
               );
           #endregion
        }
    }
}
