// 指定色の円を描画するクラス

namespace Design_Patterns_C_.StructuralPatterns.FlyweightPattern;
public class Circle : Shape
{
    public string Color { get; init; }

    public Circle(string color)
    {
        this.Color = color;
    }

    public void Draw()
    {
        System.Console.WriteLine($"{this.Color}の円を描画します！");
    }
}