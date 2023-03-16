namespace Интерфейсы
{
    internal class Program
    {
        interface IDataProvider
        {
            string GetData();

        }

        interface IDataProcessor
        {
            void ProcessData(IDataProvider dataProvider);
        }

        class ConsoleDataProcessor : IDataProcessor
        {
            public void ProcessData(IDataProvider dataProvider)
            {
                Console.WriteLine(dataProvider.GetData());
            }
        }

        class DbDataProvider : IDataProvider
        {
            public string GetData()
            {
                return "Данные из БД";
            }
        }

        class FileDataProvider : IDataProvider
        {
            public string GetData()
            {
                return "data from file";
            }
        }

        class APIDataProvider : IDataProvider
        {
            public string GetData()
            {
                return "Data from API";
            }
        }

        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());

        }
    }
}