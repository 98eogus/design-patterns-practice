using DesignPatternPractice.Builder;
using DesignPatternPractice.Factory;
using DesignPatternPractice.Observer;
using DesignPatternPractice.Strategy;
using System;

class Program
{
    static void Main(string[] args)
    {
        // 1) 싱글톤(LogManager) 사용
        var logger1 = LogManager.Instance;
        logger1.Log("싱글톤 테스트 - 첫 번째 로그");

        var logger2 = LogManager.Instance;
        logger2.Log("싱글톤 테스트 - 두 번째 로그");

        Console.WriteLine($"logger1, logger2 동일 인스턴스? {Object.ReferenceEquals(logger1, logger2)}");

        Console.WriteLine();
        Console.WriteLine("==== Factory Method Pattern ====");

        // 2) 팩토리 메서드 사용
        var emailSender = MessageSenderFactory.Create("Email");
        emailSender.Send("팩토리로 생성한 EmailSender 테스트");

        var smsSender = MessageSenderFactory.Create("SMS");
        smsSender.Send("팩토리로 생성한 SmsSender 테스트");

        Console.WriteLine();
        Console.WriteLine("==== Builder Pattern ====");

        // ============================
        // 3) Builder 사용 (SQL Query Builder)
        // ============================
        var query = new SqlQueryBuilder()
            .Select("*")
            .From("Users")
            .Where("Age > 20")
            .OrderBy("CreatedAt DESC")
            .Build();

        Console.WriteLine("빌더로 생성한 SQL 쿼리:");
        Console.WriteLine(query);

        // ============================
        // 4) Startegy 사용 
        // ============================

        Console.WriteLine();
        Console.WriteLine("==== Strategy Pattern ====");

        var sorter = new ListSorter();
        var values = new List<string> { "Banana", "Apple", "Cherry" };

        // 오름차순
        sorter.SetStrategy(new AscendingSorter());
        var asc = sorter.Sort(new List<string>(values));
        Console.WriteLine("Ascending: " + string.Join(", ", asc));

        // 내림차순
        sorter.SetStrategy(new DescendingSorter());
        var desc = sorter.Sort(new List<string>(values));
        Console.WriteLine("Descending: " + string.Join(", ", desc));


        // ============================
        // 5) Observer 사용 
        // ============================

        Console.WriteLine();
        Console.WriteLine("==== Observer Pattern ====");

        var weather = new WeatherSubject();

        var phone = new PhoneDisplay();
        var tv = new TvDisplay();

        // 구독
        weather.Register(phone);
        weather.Register(tv);

        // 상태 변경
        weather.SetTemperature(25.3f);
        weather.SetTemperature(30.1f);

        // 구독 취소
        weather.Unregister(tv);

        weather.SetTemperature(27.8f);

        Console.ReadLine();

    }
}
