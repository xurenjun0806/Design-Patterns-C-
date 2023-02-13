// See https://aka.ms/new-console-template for more information
using Design_Patterns_C_.CreationalPatterns.SimpleFactoryPattern;
using Design_Patterns_C_.CreationalPatterns.FactoryMethodPattern;
using Design_Patterns_C_.CreationalPatterns.AbstractFactoryPattern;
using Design_Patterns_C_.CreationalPatterns.BuilderPattern;
using Design_Patterns_C_.CreationalPatterns.SingletonPattern;
using Design_Patterns_C_.CreationalPatterns.PrototypePattern;
using Design_Patterns_C_.StructuralPatterns.AdapterPattern;
using Design_Patterns_C_.StructuralPatterns.BridgePattern;
using Design_Patterns_C_.StructuralPatterns.CompositePattern;
using Design_Patterns_C_.StructuralPatterns.DecoratorPattern;
using Design_Patterns_C_.StructuralPatterns.FacadePattern;
using Design_Patterns_C_.StructuralPatterns.FlyweightPattern;
using Design_Patterns_C_.StructuralPatterns.ProxyPattern;
using Design_Patterns_C_.BehavioralPatterns.ChainOfResponsibilityPattern;


Console.WriteLine("Hello, World!");

// TODO デザインパターンの呼び出しをデザインパターン化
// 簡単工場
var productA = SimpleFactory.GetProduct("A");
Console.WriteLine(productA?.GetProductInfo() ?? "商品存在しない！");

var productB = SimpleFactory.GetProduct("B");
Console.WriteLine(productB?.GetProductInfo() ?? "商品存在しない！");

var productX = SimpleFactory.GetProduct("X");
Console.WriteLine(productX?.GetProductInfo() ?? "商品存在しない！");

// 工場
var productAFactory = new ConcreteFactoryA();
Console.WriteLine(productAFactory.CreateProduct()?.GetProductInfo() ?? "商品存在しない！");

var productBFactory = new ConcreteFactoryB();
Console.WriteLine(productBFactory.CreateProduct()?.GetProductInfo() ?? "商品存在しない！");

// 抽象工場
var appleFactory = new AppleFactory();
Console.WriteLine(appleFactory.CreatePhone().GetProductInfo());
Console.WriteLine(appleFactory.CreateWatch().GetProductInfo());

var googleFactory = new GoogleFactory();
Console.WriteLine(googleFactory.CreatePhone().GetProductInfo());
Console.WriteLine(googleFactory.CreateWatch().GetProductInfo());

// ビルダー・パターン
var builder = new ConcreteBuilder();
var director = new Director(builder);
var product = director.Constuct();
System.Console.WriteLine(product.GetProductInfo());

// シングルトン
var singleton1 = Singleton.GetInstance();
var singleton2 = Singleton.GetInstance();
System.Console.WriteLine(Object.ReferenceEquals(singleton1, singleton2));
System.Console.WriteLine(singleton1.Name);

// プロトタイプ
var prototypeA = new ConcretePrototypeA(1, "プロトタイプA");
var cloneA = prototypeA.Clone();
System.Console.WriteLine(Object.ReferenceEquals(prototypeA, cloneA));
System.Console.WriteLine($"A 本体:{prototypeA.ToString()}");
System.Console.WriteLine($"A Clone体:{cloneA.ToString()}");

var prototypeB = new ConcretePrototypeB("本体！", "私は本体！！");
var cloneB = prototypeB.Clone();
System.Console.WriteLine(Object.ReferenceEquals(prototypeB, cloneB));
System.Console.WriteLine($"B 本体:{prototypeB.ToString()}");
System.Console.WriteLine($"B Clone体:{cloneB.ToString()}");

// Adapter
var classAdapter = new ClassAdapter();
System.Console.WriteLine(classAdapter.RequiredMethod());

var objectAdapter = new ObjectAdapter();
System.Console.WriteLine(objectAdapter.RequiredMethod());

// Bridge パターン
var ImplementorA = new ConcreateImplementorA(); 
var refinedAbstractionA = new RefinedAbstraction(ImplementorA);
refinedAbstractionA.Operation();

var ImplementorB = new ConcreateImplementorB();
var refinedAbstractionB = new RefinedAbstraction(ImplementorB);
refinedAbstractionB.Operation();

// Compositeパターン
var root = new FolderComponent("root")
.AddComponent(
    new FolderComponent("home")
    .AddComponent(new FileComponent("home_file1.txt"))
    .AddComponent(new FileComponent("home_file2.txt"))
    .AddComponent(
        new FolderComponent("home2")
        .AddComponent(new FileComponent("home2_file1.exe"))
    )
)
.AddComponent(
    new FolderComponent("etc")
    .AddComponent(new FileComponent("etc_file1.txt"))
    .AddComponent(
        new FolderComponent("etc2")
        .AddComponent(
            new FolderComponent("etc3")
            .AddComponent(new FileComponent("etc3_file1.txt"))
        )
    )
)
.AddComponent(
    new FolderComponent("tmp")
);

root.PrintInfo(0);

// Decoratorパターン
var primePrice = new PrimePrice(100);
System.Console.WriteLine($"原価は{primePrice.GetPrice()}");
var doublePrice = new DoublePrice(primePrice);
System.Console.WriteLine($"二倍価格は{doublePrice.GetPrice()}");

// Facadeパターン
var shapeFacade = new ShapeMaker();
shapeFacade.DrawCircle();
shapeFacade.DrawSquare();

// Flyweightパターン
var yellowCircle = ShapeFactory.GetCircle("黄色い");
yellowCircle.Draw();
var redCircle = ShapeFactory.GetCircle("赤色");
redCircle.Draw();
var yellowCircle2 = ShapeFactory.GetCircle("黄色い");
yellowCircle2.Draw();

// Proxyパターン
var image = new ProxyImage(@"C:\Image\画像.jpg");

// 初回は画像をディスクからロードする
image.Display();
// 二回目は画像のロードが必要ない
image.Display();

// Chain-of-responsibility パターン
var debug = new DebugLogger();
var info = new InfoLogger();
var error = new ErrorLogger();
debug.SetNextLogger(info);
info.SetNextLogger(error);

debug.LogMessage(AbstractLogger.LOG_LEVEL_DEBUG, "DEBUGレベルのメッセージ");
debug.LogMessage(AbstractLogger.LOG_LEVEL_INFO, "INFOレベルのメッセージ");
debug.LogMessage(AbstractLogger.LOG_LEVEL_ERROR, "ERRORレベルのメッセージ");
