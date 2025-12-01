 # Design Patterns Practice (C#)

C# 콘솔 애플리케이션으로 디자인패턴 5가지를 구현한 학습용 프로젝트입니다.

Singleton Pattern

Factory Method Pattern 

Builder Pattern 

Strategy Pattern 

Observer Pattern 


# Singleton Pattern
🔍 목적
전역 인스턴스를 하나만 유지하여 로그 관리 등 공용 객체에 사용

코드 예시
public sealed class LogManager {
    private static readonly LogManager _instance = new LogManager();
    public static LogManager Instance => _instance;
}

# Factory Method Pattern
🔍 목적
객체 생성 로직을 한 곳으로 캡슐화

코드예시
var sender = MessageSenderFactory.Create("Email");
sender.Send("Hello");

# Builder Pattern
🔍 목적
SQL 생성 과정을 단계별로 조립


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

# Observer Pattern
🔍 목적
Subject의 상태 변화를 Observer에게 자동 알림

사용 예
weather.Register(phone);
weather.Register(tv);

weather.SetTemperature(25.3f);
weather.SetTemperature(30.1f);

# 배운 점
객체 생성, 변경, 확장에 대한 책임을 분리하는 법을 익힘

패턴 적용을 통해 재사용성, 유지보수성, 확장성이 좋아지는 구조를 체감


