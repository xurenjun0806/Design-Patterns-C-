// ディレクター

namespace Design_Patterns_C_.CreationalPatterns.BuilderPattern;

class Director
{
    private Builder m_builder;

    public Director(Builder builder)
    {
        this.m_builder = builder;
    }

    public Product Constuct()
    {
        // 具体的な製造過程はディレクターが知っている(順番も)
        // 呼び出す側は知らなくてもいい
        this.m_builder.BuildPartB();
        this.m_builder.BuildPartB();
        this.m_builder.BuildPartA();
        this.m_builder.BuildPartC();
        
        var product = this.m_builder.GetResult();
        return product;
    }
}