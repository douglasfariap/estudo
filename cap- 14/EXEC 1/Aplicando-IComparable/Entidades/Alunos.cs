using System;
using System.Globalization;

namespace Aplicando_IComparable.Entidades {
    class Alunos : IComparable {
        public string nome { get; set; }
        public double salario { get; set; }

        public Alunos(string csvalunos)
        {
            string[] csvlinha = csvalunos.Split(',');
             nome = csvlinha[0];
            salario = double.Parse(csvlinha[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {   
            return nome + ", " + salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {   
            if (obj != null) return 1;
            else
            {
                Alunos aluno = obj as Alunos;
                return salario.CompareTo(aluno.salario);
            }
        }
    }
}
