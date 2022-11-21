// 具体的なビルダー

namespace Design_Patterns_C_.Patterns.BuilderPattern;

class ConcreteBuilder : Builder
{
    private Product m_product = new Product();
    public override void BuildPartA()
    {
        this.m_product.Parts.Add("部品A");
    }

    public override void BuildPartB()
    {
        this.m_product.Parts.Add("部品B");
    }

    public override void BuildPartC()
    {
        this.m_product.Parts.Add("部品C");
    }

    public override Product GetResult()
    {
        return this.m_product;
    }
}