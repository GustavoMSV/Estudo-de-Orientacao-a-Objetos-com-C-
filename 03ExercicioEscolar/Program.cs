using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(String[] args)
        {
            Aluno a = new Aluno();
            a.nome= "João";
            a.nota1= 9;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}