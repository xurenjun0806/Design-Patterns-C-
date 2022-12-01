// 実際に利用する古いクラス

namespace Design_Patterns_C_.StructuralPatterns.AdapterPattern;

public class Adaptee
{
    public string OldMethod()
    {
        return "めっちゃ古いメソッド";
    }
}