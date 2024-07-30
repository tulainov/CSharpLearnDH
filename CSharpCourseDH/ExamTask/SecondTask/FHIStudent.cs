namespace CSharpCourseDH.ExamTask.SecondTask;

public class FHIStudent
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