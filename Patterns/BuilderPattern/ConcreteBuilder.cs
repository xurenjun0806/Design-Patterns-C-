// 具体的なビルダー

namespace Design_Patterns_C_.Patterns.BuilderPattern;

class ConcreteBuilder : Builder
{
    private Product m_product = new Product();
    public override void BuildPart()
    {
        // 具体的な製造過程はビルダーが知っている(順番も)
        // 呼び出す側は知らなくてもいい
        this.m_product.BuildPartB();
        this.m_product.BuildPartC();
        this.m_product.BuildPartA();
    }

    public override Product GetResult()
    {
        return this.m_product;
    }
}