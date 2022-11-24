// 具体的なプロトタイプB

namespace Design_Patterns_C_.CreationalPatterns.PrototypePattern;

class ConcretePrototypeB : IPrototype
{
    public ConcretePrototypeB(string title, string text)
    {
        this.Title = title;
        this.Text = text;
    }

    public object Clone()
    {
        var clone = new ConcretePrototypeB("Clone体！", "私はClone体ｗｗｗ");
        return clone;
    }

    public override string ToString()
    {
        return $"Title:{this.Title}, Text:{this.Text}";
    }

    public string Title { get; set;}
    public string Text { get; set;}
}