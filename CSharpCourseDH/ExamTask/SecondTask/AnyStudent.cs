namespace CSharpCourseDH.ExamTask.SecondTask;

public abstract class AnyStudent
{

    private int _holidayDays;

    public int HolidayDays
    {
        get => _holidayDays;
        set => _holidayDays = value;
    }
    public abstract int GetHolidays();
}