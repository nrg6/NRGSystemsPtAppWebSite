using NRGSystemsPtAppWebSite.Models;

namespace NRGSystemsPtAppWebSite.Services
{
    public interface IExerciseRestFunctions
    {
        Task<bool> CreateAnExercise(Exercise exercise);
        Task<string> EditAnExercises(Exercise exercise);
        Task<List<Exercise>> GetAllExercises();
        Task<Exercise> GetAnExercise(int exerciseId);
        Task<string> DeleteAnExercise(int exerciseId);
        Task<List<Exercise>> GetExerciseForMuscleAsync(string muscleGroup);
        Task<List<Exercise>> GetExerciseFromNameAsync(string muscleName);
    }
}
