using System;
using System.IO;
using Aplicando_IComparable.Entidades;
using System.Collections.Generic;

namespace Aplicando_IComparable {
    class Program {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.csv";

            try{
                using (StreamReader sr = File.OpenText(path)){
                    List<Alunos> list = new List<Alunos>();
                    while (!sr.EndOfStream){
                        list.Add(new Alunos(sr.ReadLine()));                        
                    }
                    list.Sort();
                    foreach(Alunos str in list){
                        Console.WriteLine(str);
                    }
                }
            }
            catch
            {

            }


        }
    }
}
