// シングルトン

namespace Design_Patterns_C_.CreationalPatterns.SingletonPattern
{
    class Singleton
    {
        private static Singleton? _instance;

        private Singleton(string name)
        {
            this.Name = name;
        }

        public static Singleton GetInstance()
        {
            if (_instance == null) _instance = new Singleton("私は唯一無二！");

            return _instance;
        }

        public string Name { get; init; }
    }
}