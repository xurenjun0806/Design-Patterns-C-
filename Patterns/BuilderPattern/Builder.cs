// 抽象ビルダー

namespace Design_Patterns_C_.Patterns.BuilderPattern;

abstract class Builder
{
    public abstract void BuildPart();

    public abstract Product GetResult();
}