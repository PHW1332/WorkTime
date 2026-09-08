Console.WriteLine("WorkTime 시작");

// TimeOnly startTime = new TimeOnly(17, 0);
//TimeOnly endTime = new TimeOnly(22, 0);
Console.Write("시작 시간을 입력하세요: ");
string startInput = Console.ReadLine() ?? "";
Console.Write("종료 시간을 입력하세요: ");
string endInput = Console.ReadLine() ?? "";

TimeOnly startTime = TimeOnly.Parse(startInput);
TimeOnly endTime = TimeOnly.Parse(endInput);

TimeSpan workTime = endTime - startTime;

//Console.WriteLine($"시작 시간: {startTime}");
//Console.WriteLine($"종료 시간: {endTime}");
Console.WriteLine($"근무 시간: {workTime.Hours}시간 {workTime.Minutes}분");