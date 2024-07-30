using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace Genericos_2
{
    internal class Program
    {
        static void Main()
        {
            AlmacenObjeto<string> archivos = new AlmacenObjeto<string>(3);

            AlmacenObjeto<DateTime> archivoFecha = new AlmacenObjeto<DateTime> (3);

            archivos.Agregar("Hamel");
            archivos.Agregar("Ana");
            archivos.Agregar("Lucas");

            for (int x = 0; x < 3; x++)
            {
                string datos = archivos.getElementos(x);

                Console.WriteLine(datos);

            }

            Console.WriteLine();
            PersianCalendar persian = new PersianCalendar();

            archivoFecha.Agregar(new DateTime(2004, 09, 22));
            archivoFecha.Agregar(new DateTime(1389, 5, 27, 16, 32, 18, 500, persian));
            archivoFecha.Agregar(new DateTime(2024, 7, 29, 18, 17, 18, 500,
                              DateTimeKind.Local));

            for (int i = 0; i < 3; i++)
            {
                DateTime fechas = archivoFecha.getElementos(i);
                Console.WriteLine(fechas);
            }

            
            Console.ReadKey();
        }
    }
    class AlmacenObjeto <A>
    {
        private A[] datosElementos;
        private int i = 0;

        public AlmacenObjeto(int z)
        {
            datosElementos = new A[z];
        }

        
        public void Agregar(A objeto)
        {
            datosElementos[i] = objeto;
            i++;            
        }

        public A getElementos(int posicion)
        {
            return datosElementos[posicion];            
        }

    }
}
