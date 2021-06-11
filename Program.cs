using System;
using DIO.Exemplos;

namespace DIO
{
  class Program
  {
    static void Main(string[] args)
    {
      var s = new Pilha();
      s.Empilhado(1);
      s.Empilhado(10);
      s.Empilhado(100);
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
    }
  }
}

