using System.Runtime.CompilerServices;

public class ExerciseManager
{
    private List<Exercise> _exercises = new List<Exercise>();
    public ExerciseManager(List<Exercise> exercises)
    {
        _exercises = exercises;
    }
    public void ListExerciseDetails()
    {
        foreach (Exercise rep in _exercises)
        {
            Console.WriteLine(rep.GetSummary());
        }      
    }
}