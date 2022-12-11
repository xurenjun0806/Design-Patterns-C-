// 共通インタフェース実現：ファイル

namespace Design_Patterns_C_.StructuralPatterns.CompositePattern;

public class FileComponent : FileInterface
{
    private string Name { get; init; }

    public FileComponent(string name)
    {
        this.Name = name;
    }
    public void PrintInfo(int depth)
    {
        var depthIndent = string.Concat(Enumerable.Repeat("　", depth));
        System.Console.WriteLine($"{depthIndent}ファイル：{this.Name}");
    }
    public List<FileInterface>? GetChildren() => null;
    public FileInterface AddComponent(FileInterface component) => this;
    public void RemoveComponent(FileInterface component){}
    public bool IsFolder() => false;
}