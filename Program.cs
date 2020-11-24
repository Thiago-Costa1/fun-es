using System;

namespace Exercicios_de_fixação_1
{
    class Program
    {
        static void Main(string[] args)
        {

           {

       static float CalcularMedia(float[] numeros){

        float soma = 0;

        for (var i = 0; i < numeros.Length; i++)
        {
          // soma = soma + numeros [i];
          soma+= numeros[i];
        }

        float resultado = soma / numeros.Length;

        return resultado;

    }
        static void main(string[] args)
        {
           /* void = função vazia
           float = Variável que serve para números decimais
          /* Exercício: Faça um programa que receba o nome e quatro notas de 10 alunos e armezena
          essas notas em votores. Calcule e mostre: 
          A) A média do aluno - Função 
          B) A quantidade de Aprovados (Média >=7)
          C) A quantidade de reprovados (Média <=7)
          D) A média geral dos 10 alunos */

         // Criar as variáveis necessárias
          string [] nomes = new string[2];
          float[] medias = new float[7];
          float[] notas = new float [4];

          // Estruturas de repetição
          // Laços contados
          // array.Length = tamanho do array
          for (int i = 0; i < nomes.Length; i++)
          {
            Console.WriteLine("Digite o nome do aluno : ");
            nomes[i] = Console.ReadLine(); // laço com o nome dos alunos definido

              for (int n = 0; n < notas.Length; n++)
              {
                Console.WriteLine("Digite a "+(n+1)+"° nota:"); // ($"Digite a {(n+1)}° nota: ") > Outra forma usando interpolação, com $
                notas[n] = float.Parse( Console.ReadLine() ); // laço das notas
              }
          // Calcula a média fora do laço de notas
          // medias[i] = (notas[0] + notas[1] + notas[2] + notas[3] + notas[4]) / 7;

            medias[i] = CalcularMedia(notas);


        } // fim de laço for

          Console.ForegroundColor = ConsoleColor.Green; // Sintaxe que serve pra cor

          // Laços condicionais
          // variável criada "name" em laço foreach
          // foreach organiza em lista
          foreach (string name in nomes){
            Console.WriteLine(name);
          }

          Console.ForegroundColor = ConsoleColor.Red;

          // Mostramos as infos
          for (var i = 0; i < nomes.Length; i++)
          {
            // Interpolação
            Console.WriteLine($"Nome: {nomes[i]} Média: {medias[i]}");
          }

          Console.ResetColor();

          Console.WriteLine("Média geral da turma:"  + CalcularMedia(medias));
          
        } // Fim de Main
           }  
    }
    }        

