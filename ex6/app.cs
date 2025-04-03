using System;

public class Aluno {
    public string Nome;
    public int Matricula;
    public string Curso;
    public double Media;

    public void ExibirDados() {
    Console.WriteLine($"Aluno: {Nome},\nMatricula: {Matricula},\nCurso: {Curso},\nMedia: {Media}");
    }

    public void VerificaAprovacao() {
        if (Media >= 7) {
            Console.WriteLine($"O aluno {Nome} está Aprovado!");
        }  else {
            Console.WriteLine($"O aluno {Nome} está Reprovado!");
        }
    }

}


class program
{

    public static void Main(strign[] args){

        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Giovani";
        aluno1.Matricula = 121421;
        aluno1.Curso = "Engenharia de Software";
        aluno1.Media = 6.9;

        aluno1.ExibirDados();

        Console.WriteLine("");
        aluno1.VerificaAprovacao();

    }
}

