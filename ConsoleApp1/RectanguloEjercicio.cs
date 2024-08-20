using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RectanguloEjercicio 
    {
   

        public Cordenadas Cordenadas1 { get; set; }
        public Cordenadas Cordenadas2 { get; set; }
        public Cordenadas Cordenadas3 { get; set; }
        public Cordenadas Cordenadas4 { get; set; }





        public double CalcularBase() 
        { 
            double Base = 0;

            Base = Math.Sqrt(Math.Pow(Cordenadas2.CordenadaX-Cordenadas1.CordenadaX, 2) + Math.Pow(Cordenadas2.CordenadaY-Cordenadas1.CordenadaY, 2));
            return Base;
        }
        public double CalcularAltura() 
        { 
            double Altura = 0;
            Altura = Math.Sqrt(Math.Pow(Cordenadas4.CordenadaX - Cordenadas1.CordenadaX, 2) + Math.Pow(Cordenadas4.CordenadaY - Cordenadas1.CordenadaY, 2));
            return Altura; 
        }
        public double CalcularArea() 
        {
            double Area = 0;
            double Base = 0;

            Base = Math.Sqrt(Math.Pow(Cordenadas2.CordenadaX - Cordenadas1.CordenadaX, 2) + Math.Pow(Cordenadas2.CordenadaY - Cordenadas1.CordenadaY, 2));
            double Altura = 0;
            Altura = Math.Sqrt(Math.Pow(Cordenadas4.CordenadaX - Cordenadas1.CordenadaX, 2) + Math.Pow(Cordenadas4.CordenadaY - Cordenadas1.CordenadaY, 2));

            Area = Base * Altura;

            return Area;

        }
        public double CalcularPerimetro() 

        {
            double perimetro = 0;
            double Base = 0;

            Base = Math.Sqrt(Math.Pow(Cordenadas2.CordenadaX - Cordenadas1.CordenadaX, 2) + Math.Pow(Cordenadas2.CordenadaY - Cordenadas1.CordenadaY, 2));
            double Altura = 0;
            Altura = Math.Sqrt(Math.Pow(Cordenadas4.CordenadaX - Cordenadas1.CordenadaX, 2) + Math.Pow(Cordenadas4.CordenadaY - Cordenadas1.CordenadaY, 2));


            perimetro = 2 *(Base + Altura);
            return perimetro;
        }
    }
}
