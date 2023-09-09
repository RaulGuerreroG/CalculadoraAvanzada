using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPractica.ArchivosProgramaPractica
{
    public class FuncionesCalculadora

    {
        public int Sumar(int num1, int num2)
        {
            int suma = num1 + num2;
            return suma;
        }

        public int Restar(int num1, int num2)
        {
            int resta = num1 * num2;
            return resta;
        }

        public int multiplicar(int num1, int num2)
        {
            int producto = num1 * num2;
            return producto;
        }

        public int Division(int num1, int num2)
        {
            int division = num1 * num2;
            return division;
        }

        public int Potencia(int numeroBase, int exponente)
        {
            int resultado = 1;

            for (int i = 1; i <= exponente; i++)
            {
                resultado *= numeroBase;
            }

            return resultado;
        }

    }
}
