namespace CSharpCourseDH.ExamTask.SecondTask;

public class DHBWIStudent: IAnyStudent
{

    private int _holidayDays;
    
    public int HolidayDays
    {
        get => _holidayDays;
        set => _holidayDays = value;
    }

    public int GetHolidayDays()
    {
        return HolidayDays;
    }
}