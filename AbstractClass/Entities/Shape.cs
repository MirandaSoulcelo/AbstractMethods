
using Shape.Enum;
namespace Shape.Entities
{
    abstract class  Shapes
    {
        public Color Color{get;set;}


      

        public Shapes(Color color)
        {
            Color = color;
        }

        public abstract double Area();//É necessário tornar a classe abstrata para colocar um método abstrato
        //No caso de um método abstrato, eu não preciso colocar um virtual para  fazer uma sobrescrita, MAs NA SUBCLASSE EU PRECISO COLOCAR UM OVERRIDE
    }
}