// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//int area = 0;
//int perimetro = 0;
//_Rectangulo rectangulo = new _Rectangulo();
//rectangulo.Base = 10;
//rectangulo.Altura = 20;
//area = rectangulo.CalcularArea();
//perimetro = rectangulo.CalcularPerimetro();

//Console.WriteLine("El area es :");
//Console.WriteLine(area);
//Console.WriteLine("\n");
//Console.WriteLine("El perimetro es ");
//Console.WriteLine(perimetro);


Persona persona = new Persona {
    Nombres = "Leonardo",
    Apellidos = "Guzmán"
};
persona.AsignarNombreCompletos();
Console.WriteLine("Mi nombre es ");
Console.WriteLine(persona.NombresCompletos);

Profesor profesor = new Profesor { 
        Nombres = "",
        Apellidos = "",
        Sueldo = 15000
    
};

Estudiante estudiante = new Estudiante {
    Nombres = "Leonardo",
    Apellidos = "Guzman",
    Codigo = "90328909342",
};

RectanguloEjercicio rectangulo = new RectanguloEjercicio
{
    
};

Console.WriteLine(rectangulo.CalcularBase());
Console.WriteLine(rectangulo.CalcularAltura());
Console.WriteLine(rectangulo.CalcularPerimetro());
Console.WriteLine(rectangulo.CalcularArea());
