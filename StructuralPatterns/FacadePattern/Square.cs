// 形描画サブシステム_四角描画クラス
namespace Design_Patterns_C_.StructuralPatterns.FacadePattern;

public class Square : Shape
{
    public void Draw()
    {
        System.Console.WriteLine("四角を描きましたよ！");
    }
}