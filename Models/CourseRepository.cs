using Newtonsoft.Json;

public class Allocation : Record
{
    public Allocation()
    {
        Year = NextSession.Year;
    }
    public int TeacherId { get; set; }
    public int CourseId { get; set; }
    public int Year { get; set; }
    [JsonIgnore]
    public Course Course => DB.Courses.Get(CourseId);
    [JsonIgnore]
    public Teacher Teacher => DB.Teachers.Get(TeacherId);
    [JsonIgnore]
    public bool IsNextSession => Year == NextSession.Year && NextSession.ValidSessions.Contains(Course.Session);
}
public class Registration : Record
{
    public Registration()
    {
        Year = NextSession.Year;
    }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int Year { get; set; }
    [JsonIgnore]
    public Course Course => DB.Courses.Get(CourseId);
    [JsonIgnore]
    public Student Student => DB.Students.Get(StudentId);
    [JsonIgnore]
    public bool IsNextSession => Year == NextSession.Year && NextSession.ValidSessions.Contains(Course.Session);
}