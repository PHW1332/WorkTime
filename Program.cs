using WorkTime;

Console.WriteLine("WorkTime 시작");

Console.Write("시작 시간을 입력하세요: ");
string startInput = Console.ReadLine() ?? "";
Console.Write("종료 시간을 입력하세요: ");
string endInput = Console.ReadLine() ?? "";

TimeOnly startTime = TimeOnly.Parse(startInput);
TimeOnly endTime = TimeOnly.Parse(endInput);

WorkSession session = new WorkSession(startTime, endTime);

TimeSpan workTime = session.CalculateDuration();

Console.WriteLine($"근무 시간: {workTime.Hours}시간 {workTime.Minutes}분");