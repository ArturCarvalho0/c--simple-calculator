﻿using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {

      Menu();

    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("------------------");
      Console.WriteLine("Selecione uma opção: ");
      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Multiplicacao();
          break;
        case 4:
          Divisao();
          break;
        case 5:
          Environment.Exit(0);
          break;
        default:
          Console.WriteLine("Opção inválida!");
          Console.ReadKey();
          Menu();
          break;
      }
    }

    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine();

      float resultado = v1 + v2;
      Console.WriteLine($"O resultado da soma é: {resultado}");
      // Console.WriteLine("O resultado da soma é: " + resultado);
      // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
      // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine();
      float resultado = v1 - v2;
      Console.WriteLine($"O resultado da subtração:{resultado}");
      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine();
      if (v2 != 0)
      {
        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
      }
      else
      {
        Console.WriteLine("Não é possível dividir por zero!");
      }
      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      Console.WriteLine();
      float resultado = v1 * v2;
      Console.WriteLine($"O resultado da multiplicação é: {resultado}");
      Console.ReadKey();
      Menu();
    }
  }
}