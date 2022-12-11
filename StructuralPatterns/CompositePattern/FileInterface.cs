// 共通インタフェース(ファイルを例)

namespace Design_Patterns_C_.StructuralPatterns.CompositePattern;

public interface FileInterface
{
    public void PrintInfo(int depth);
    public List<FileInterface>? GetChildren();
    public FileInterface AddComponent(FileInterface component);
    public void RemoveComponent(FileInterface component);
    public bool IsFolder();
}