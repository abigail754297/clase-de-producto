using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_de_producto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            productoperecible producto1 = new productoperecible();
            producto1.nombre = "Leche";
            producto1.codigo = "L123";
            producto1.precio = 1.5;
            producto1.fechadecaducidad = "2023-12-31";
            producto1.temperaturarecomendada = 4.7;
            lacteo lacteo1 = new lacteo();
            lacteo1.tipoDeLeche = "Entera";
            lacteo1.contenidoGraso = 3.5;
            carnico carnico1 = new carnico();
            carnico1.tipoDeCarne = "Pollo";
            carnico1.peso = 1.2;
            producto1.mostrarInformacionGeneral();
            producto1.mostrarCondicionesAlmacenamiento();
            lacteo1.mostrarinformacionnutricional();
            carnico1.mostrarinformacionnutricional();
        }
        class carnico : productoperecible
        {
            public string tipoDeCarne;
            public double peso;
            public void mostrarinformacionnutricional()
            {
                Console.WriteLine("Tipo de carne: " + tipoDeCarne);
                Console.WriteLine("Peso: " + peso + " kg");
            }
        }
        class lacteo : productoperecible 
        {
            public double contenidoGraso;
            public string tipoDeLeche;
            public void mostrarinformacionnutricional()
            {
                Console.WriteLine("Tipo de leche: " + tipoDeLeche);
                Console.WriteLine("Contenido graso: " + contenidoGraso + "%");
                
            }
        }

        class productoperecible : producto 
        {
            public string fechadecaducidad;
            public double temperaturarecomendada;
            public void mostrarCondicionesAlmacenamiento()
            {
                Console.WriteLine("Fecha de caducidad: " + fechadecaducidad);
                Console.WriteLine("Temperatura recomendada: " + temperaturarecomendada + "");
            }
        }
        class producto 
        {
            public string nombre;
            public string codigo;
            public double precio;

            public void mostrarInformacionGeneral()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Código: " + codigo);
                Console.WriteLine("Precio: " + precio);
            }
        }
    }
}
