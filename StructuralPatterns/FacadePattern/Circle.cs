// 形描画サブシステム_円形描画クラス
namespace Design_Patterns_C_.StructuralPatterns.FacadePattern;

public class Circle : Shape
{
    public void Draw()
    {
        System.Console.WriteLine("円を描きましたよ！");
    }
}