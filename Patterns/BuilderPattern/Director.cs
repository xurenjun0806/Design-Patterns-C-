// ディレクター

namespace Design_Patterns_C_.Patterns.BuilderPattern;

class Director
{
    private Builder m_builder;

    public Director(Builder builder)
    {
        this.m_builder = builder;
    }

    public Product Constuct()
    {
        this.m_builder.BuildPart();
        var product = this.m_builder.GetResult();
        return product;
    }
}