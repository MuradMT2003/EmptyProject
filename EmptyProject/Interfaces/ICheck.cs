namespace EmptyProject.Interfaces;

public interface ICheck
{
    double CheckGrades(params int[] grades)
    {
        return grades.Average();
    }
    
}
