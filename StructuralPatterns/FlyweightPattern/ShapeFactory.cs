// 円描画オブジェクトファクトリー
// 同じ色の円を描画するオブジェクトは一度保存して、再度同じ色の円描画オブジェクト取得する場合は保存されているオブジェクトを利用

namespace Design_Patterns_C_.StructuralPatterns.FlyweightPattern;
public class ShapeFactory
{
    private static readonly Dictionary<string, Shape> _circleMap = new Dictionary<string, Shape>();

    public static Shape GetCircle(string color)
    {
        if (_circleMap.ContainsKey(color))
        {
            System.Console.WriteLine($"既存の{color}の円描画オブジェクトを利用します！");
            return _circleMap[color];
        }

        _circleMap[color] = new Circle(color);
        System.Console.WriteLine($"新しい{color}の円描画オブジェクトを作成しました！");
        return _circleMap[color];
    }
}