namespace First_OOP_Project
{
    public interface IEngine
    {
        void Start();
    }

    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public class Car
    {
        private readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            Car car = new Car(engine);

            car.Start();

        }
    }
}
