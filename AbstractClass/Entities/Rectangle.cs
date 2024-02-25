using Shape.Enum;

namespace Shape.Entities
{
    class Rectangle : Shapes//Inicialmente deu um erro porque eu não tenho um argumento do tipo color na minha subclasse Rectangçe
    //Isso acontece porque só fiz um construtor que contém parâmetros, o que obriga a subclasses a instanciarem os argumentos necessários.
    //Além disso, por conta da super classe ter um método abstrato, AS SUBCLASSES SÃO OBRIGADAS A IMPLEMENTAREM ESSE MÉTODO, POR ISSO DO ERRO TAMBÉM.
    //FORA ISSO MANO, Caso eu não queira obrigar a classe a ter um arugmento do tipo Color: É NECESSÁRIO UM CONSTRUTOR VAZIO NA SUPERCLASSE, PQ EU NÃO TENHO UM ARGUMENTO ESPECIÍCO DO TIPO COLOR NESSA SUBCLASSE
    {
        public double Width {get;set;}
        public double Height{get; set;}
        
        public Rectangle(Color color, double width, double height) : base(color)//Nota IMPORTANTE!!!
        //Fiz um construtor onde tem o argumento do Tipo color, que pega como base o Color da superclase, o que me permite que a subclasse Rectangle seja de fato uma subclasse integra de Shape
        //por conta da obrigatoriedade do tipo Color da super calsse abstrata
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        
    }
}