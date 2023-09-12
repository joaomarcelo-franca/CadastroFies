using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Aluno
    {
        public string Nome {  get; set; }
        public string Curso { get; set; }
        public double RendaFamiliar { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Matricula {  get; set; }

        public int Idade { get; set; }

        public int CalcularIdade(DateTime data)
        {
            Idade = DateTime.Now.Year - data.Year;

            if (DateTime.Now.Month < data.Month)
            {
                Idade--;
            }
            else if (DateTime.Now.Month == data.Month && DateTime.Now.Day < data.Day)
            {
                Idade--;
            }
            return Idade;
        }
    }
}
