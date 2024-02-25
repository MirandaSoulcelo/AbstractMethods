using Shape.Entities;
using System.Globalization;
using System.Collections.Generic;
using Shape.Enum;


List<Shapes> list = new List<Shapes>();

Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Shape #{i} data: ");

    Console.Write("Rectangle or Circle(r/c)? ");
    char ch = char.Parse(Console.ReadLine());

    if(ch == 'r' || ch == 'R')
    {
        Console.Write("Color (Black/Blue/Red): ");
        Color color = Enum.Parse<Color>(Console.ReadLine());//Fixação: COmo iniciar uma varíavel auxiliar do tipo enum onde o que o usuario digitar, será convertido em enum
        
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        list.Add(new Rectangle(color, width, height));//é aqui onde ocorre o polimofirsmo, o for vai  atribuindo na lista(em tempo de execução) um objeto do tipo Rectangle na lista do Tipo shape
    }

    else if(ch == 'c' || ch == 'C')
    {
        Console.WriteLine("Color (Black/Blue/Red): ");
        Color color = Enum.Parse<Color>(Console.ReadLine());
        
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        list.Add(new Circle(color, radius));
    }

    else
    {
        Console.WriteLine("Shape Not Found");

    }
}

    Console.WriteLine();

    Console.WriteLine("Shape Areas: ");

    foreach(Shapes figure in list)
    {

        Console.WriteLine(figure.Area().ToString("F2", CultureInfo.InvariantCulture));//Utilizei o foreach para chamar o método de área e me mostrar os valores da área dos objetos da lista
    }

    Console.ReadKey();