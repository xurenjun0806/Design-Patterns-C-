// See https://aka.ms/new-console-template for more information
using Design_Patterns_C_.CreationalPatterns.SimpleFactoryPattern;
using Design_Patterns_C_.CreationalPatterns.FactoryMethodPattern;
using Design_Patterns_C_.CreationalPatterns.AbstractFactoryPattern;
using Design_Patterns_C_.CreationalPatterns.BuilderPattern;
using Design_Patterns_C_.CreationalPatterns.SingletonPattern;

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