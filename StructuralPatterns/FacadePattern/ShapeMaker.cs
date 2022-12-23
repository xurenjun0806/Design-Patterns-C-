// 形描画サブシステムの外観クラス（ファサード）
namespace Design_Patterns_C_.StructuralPatterns.FacadePattern;

public class ShapeMaker
{
    private Shape Circle;
    private Shape Square;
    public ShapeMaker()
    {
        this.Circle = new Circle();
        this.Square = new Square();
    }
    public void DrawCircle()
    {
      this.Circle.Draw();
    }
    public void DrawSquare()
    {
      this.Square.Draw();
    }
}