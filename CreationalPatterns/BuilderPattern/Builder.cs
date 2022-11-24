// 抽象ビルダー

namespace Design_Patterns_C_.CreationalPatterns.BuilderPattern;

abstract class Builder
{
    public abstract void BuildPartA();

    public abstract void BuildPartB();

    public abstract void BuildPartC();

    public abstract Product GetResult();
}