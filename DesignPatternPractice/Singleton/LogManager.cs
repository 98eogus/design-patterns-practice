using System;

public class LogManager
{
    // ① 싱글톤 인스턴스를 담아둘 정적 필드
    private static LogManager _instance;

    // ② lock용 정적 오브젝트 (여기에 대해 잠금)
    private static readonly object _lock = new object();

    // ③ 생성자를 private으로 막아서 외부 new 금지
    private LogManager()
    {
        Console.WriteLine("LogManager 생성자 호출됨");
    }

    // ④ 인스턴스에 접근하는 전역 진입 지점 (쓰레드 세이프)
    public static LogManager Instance
    {
        get
        {
            lock (_lock) // 여러 스레드가 동시에 들어오지 못하게 막음
            {
                if (_instance == null)
                {
                    _instance = new LogManager();
                }
                return _instance;
            }
        }
    }

    // ⑤ 실제 기능 (로그 출력)
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}
