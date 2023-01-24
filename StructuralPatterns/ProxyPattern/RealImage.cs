// 実際のイメージクラス
namespace Design_Patterns_C_.StructuralPatterns.ProxyPattern;

public class RealImage : Image
{
    public RealImage(string imagePath)
    {
        this.ImagePath = imagePath;
        this.ImageData = LoadImageFile(imagePath);
    }

    public void Display()
    {
        System.Console.WriteLine(this.ImageData); 
    }

    private string LoadImageFile(string imagePath)
    {
        System.Console.WriteLine($"{imagePath}から画像ファイルをロードしました！！！");
        return $"***{imagePath}の画像***";
    }

    private string ImagePath { get; set; }
    private string ImageData { get; set;}
}