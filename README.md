 # Design Patterns Practice (C#)

C# 콘솔 애플리케이션으로 디자인패턴 5가지를 구현한 학습용 프로젝트입니다.

Singleton Pattern
Factory Method Pattern
Builder Pattern
Strategy Pattern
Observer Pattern


# Singleton Pattern
🔍 목적
애플리케이션 전체에서 하나의 인스턴스만 생성해 공유하도록 보장
→ 로그 관리와 같은 공용 객체에 적합

코드 예시
public sealed class LogManager
{
    private static readonly LogManager _instance = new LogManager();
    public static LogManager Instance => _instance;

    private LogManager() { }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}

사용 예
var logger = LogManager.Instance;
logger.Log("Singleton Test");

# Factory Method Pattern
🔍 목적
객체 생성 로직을 한 곳에서 통합 관리하여
클라이언트가 구체 클래스에 의존하지 않도록 함.

# Builder Pattern
🔍 목적
복잡한 객체(여기서는 SQL Query)를 단계별로 조립하고
가독성 높은 Fluent API를 제공.

UML
SqlQueryBuilder -> Build() -> SqlQuery

사용 예
var query = new SqlQueryBuilder()
    .Select("*")
    .From("Users")
    .Where("Age > 20")
    .OrderBy("CreatedAt DESC")
    .Build();

# Strategy Pattern
🔍 목적
정렬 알고리즘(오름차순, 내림차순 등)을 전략 객체로 분리하여
유연하게 교체 가능하도록 구성.

사용 예
sorter.SetStrategy(new AscendingSorter());
var result = sorter.Sort(values);

# Observer Pattern
🔍 목적
주제(Subject)의 상태 변경을 구독자(Observer)에게 자동으로 알리는 이벤트 모델 구현.

사용 예
weather.Register(phone);
weather.Register(tv);

weather.SetTemperature(25.3f);
weather.SetTemperature(30.1f);

# 배운 점
객체 생성, 변경, 확장에 대한 책임을 분리하는 법을 익힘
패턴 적용을 통해 재사용성, 유지보수성, 확장성이 좋아지는 구조를 체감
단순 예제가 아니라 실제 시나리오에 패턴을 적용하면서
현업 코드에서 디자인패턴이 필요한 이유를 명확히 이해하게 됨

SOLID 원칙 중 특히 **OCP(개방-폐쇄 원칙)**와 **SRP(단일 책임 원칙)**의 중요성을 경험
