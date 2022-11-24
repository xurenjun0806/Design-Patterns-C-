// 製造対象商品

namespace Design_Patterns_C_.CreationalPatterns.BuilderPattern;

class Product
{
    public Product()
    {
        this.Parts = new List<string>();
    }

    public string GetProductInfo()
    {
        var parts = string.Join(",", this.Parts);
        var result = $"私は「{parts}」で作られている！";
        return result;
    }
    public List<string> Parts { get; set;}
}