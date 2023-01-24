// 代理イメージクラス

namespace Design_Patterns_C_.StructuralPatterns.ProxyPattern;

public class ProxyImage : Image
{
    public ProxyImage(string imagePath)
    {
        this.ImagePath = imagePath;
    }

    public void Display()
    {
        // 表示が必要時だけ、イメージをロード
        if (this.RealImage == null) this.RealImage = new RealImage(this.ImagePath);
        this.RealImage.Display();
    }

    private RealImage? RealImage { get; set; }
    private string ImagePath { get; set; }
}