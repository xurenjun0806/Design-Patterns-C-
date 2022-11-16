// See https://aka.ms/new-console-template for more information
using Design_Patterns_C_.Patterns.SimpleFactoryPattern;
using Design_Patterns_C_.Patterns.FactoryMethodPattern;

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
