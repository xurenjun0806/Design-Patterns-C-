// 共通インタフェース実現：フォルダ
// フォルダにファイルが複数含むことができる

namespace Design_Patterns_C_.StructuralPatterns.CompositePattern;

public class FolderComponent : FileInterface
{
    private string Name { get; init; }
    private List<FileInterface> files { get; set; } = new List<FileInterface>();

    public FolderComponent(string name)
    {
        this.Name = name;
    }
    public void PrintInfo(int depth)
    {
        var depthIndent = string.Concat(Enumerable.Repeat("　", depth));
        System.Console.WriteLine($"{depthIndent}フォルダ：{this.Name}");

        foreach(var file in this.files)
        {
            file.PrintInfo(depth + 1);
        }
    }
    public List<FileInterface>? GetChildren() => this.files;
    public FileInterface AddComponent(FileInterface component)
    {
        this.files.Add(component);
        return this;
    }
    public void RemoveComponent(FileInterface component) => this.files.Remove(component);
    public bool IsFolder() => true;
}