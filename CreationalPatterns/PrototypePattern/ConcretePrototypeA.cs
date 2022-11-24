// 具体的なプロトタイプA

namespace Design_Patterns_C_.CreationalPatterns.PrototypePattern;

class ConcretePrototypeA : IPrototype
{
    public ConcretePrototypeA(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public object Clone()
    {
        var clone = new ConcretePrototypeA(this.Id, this.Name);
        return clone;
    }

    public override string ToString()
    {
        return $"Id:{this.Id}, Name:{this.Name}";
    }

    public int Id { get; set;}
    public string Name { get; set;}
}