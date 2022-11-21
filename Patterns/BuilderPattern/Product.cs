// 製造対象商品

namespace Design_Patterns_C_.Patterns.BuilderPattern;

class Product
{
    public Product()
    {
        this.Parts = new List<string>();
    }

    public void BuildPartA()
    {
        this.Parts.Add("部品A");
    }

    public void BuildPartB()
    {
        this.Parts.Add("部品B");
    }

    public void BuildPartC()
    {
        this.Parts.Add("部品C");
    }

    public string GetProductInfo()
    {
        var parts = string.Join(",", this.Parts);
        var result = $"私は「{parts}」で作られている！";
        return result;
    }
    private List<string> Parts { get; set;}
}