using Shape.Enum;
using System;
namespace Shape.Entities

{
    class Circle : Shapes
    {
        public double Radius{get; set;}


        public Circle(Color color, double radius) : base(color)//Construtor com argumento do tipo color() pegando o atributo da superclasse abstrata Shape
        {
            Radius = radius;
        }


        public override double Area()//Sobrescrita do Método abstrato(É obrigatório implementar um método abstrato da superclasse em suas subclasses)
        {
            return Math.PI * Radius * Radius;
        }
    }
}