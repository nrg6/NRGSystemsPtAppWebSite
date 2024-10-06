using NRGSystemsPtAppWebSite.Models;

namespace NRGSystemsPtAppWebSite.Services
{
    public class ExerciseRestFunction : IExerciseRestFunctions
    {

        readonly HttpClient _functionClient;
        //readonly HttpClient _localClient;
        //readonly JsonSerializerOptions _serializerOptions = new();

        public ExerciseRestFunction()
        {
            _functionClient = new HttpClient
            {
                BaseAddress = new Uri("https://exercisefunction.azurewebsites.net/")
            };
            //_localClient = new HttpClient
            //{
            //    BaseAddress = new Uri("http://localhost:7074/")
            //};
        }

        /// <summary>
        /// Using Azure Functions
        /// </summary>
        /// <returns> All Enabled Exercises </returns>
        public async Task<List<Exercise>> GetAllExercises()
        {
            var exercises = new List<Exercise>();
            try
            {
                exercises = await _functionClient.GetFromJsonAsync<List<Exercise>>("api/GetExerciseList");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return exercises;
        }
        public async Task<List<Exercise>> GetExerciseForMuscleAsync(string muscleGroup)
        {
            var exercises = new List<Exercise>();
            try
            {
                exercises = await _functionClient.GetFromJsonAsync<List<Exercise>>($"api/GetExerciseForMuscleAsync/{muscleGroup}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return exercises;
        }
        public async Task<List<Exercise>> GetExerciseFromNameAsync(string muscleName)
        {
            var exercises = new List<Exercise>();
            try
            {
                exercises = await _functionClient.GetFromJsonAsync<List<Exercise>>($"api/GetExerciseFromNameAsync/{muscleName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return exercises;
        }

        public async Task<bool> CreateAnExercise(Exercise exercise)
        {
            var newExercise = new Exercise();
            try
            {
                var a = await _functionClient.GetFromJsonAsync<bool>(
                    $"api/CreateAnExercise?ExerciseName={exercise.ExerciseName}&" +
                    $"ImageGif={exercise.ImageGif}&" +
                    $"InstructionPreperation={exercise.InstructionPreperation}&" +
                    $"InstructionExecution={exercise.InstructionExecution}&" +
                    $"Comments={exercise.Comments}&" +
                    $"ClassificationMechanics={exercise.ClassificationMechanics}&" +
                    $"ClassificationROM={exercise.ClassificationROM}&" +
                    $"ClassificationForce={exercise.ClassificationForce}&" +
                    $"MuscleGroup={exercise.MuscleGroup}&" +
                    $"MuscleSynergists={exercise.MuscleSynergists}&" +
                    $"MuscleStabilizers={exercise.MuscleStabilizers}&" +
                    $"Enabled=1"); //  {exercise.Enabled}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return false;
            }

            return true;
        }

        public async Task<Exercise> GetAnExercise(int exerciseId)
        {
            try
            {
                return await _functionClient.GetFromJsonAsync<Exercise>(
                    $"api/GetExerciseById?exerciseId={exerciseId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Exercise();

            }
        }

        public async Task<string> DeleteAnExercise(int exerciseId)
        {
            try
            {
                await _functionClient.GetFromJsonAsync<string>(
                    $"api/DeleteExercise?exerciseId={exerciseId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return ex.Message;
            }
            return "OK";
        }

        public async Task<string> EditAnExercises(Exercise exercise)
        {
            string query = $"api/EditExercise?exercise_id={exercise.ExerciseId}&" +
                           $"exercise_name={exercise.ExerciseName}&" +
                           $"image_gif={exercise.ImageGif}&" +
                           $"preperation={exercise.InstructionPreperation}&" +
                           $"execution={exercise.InstructionExecution}&" +
                           $"comments={exercise.Comments}&" +
                           $"mechanics={exercise.ClassificationMechanics}&" +
                           $"rom={exercise.ClassificationROM}&" +
                           $"force={exercise.ClassificationForce}&" +
                           $"target={exercise.MuscleTarget}&" +
                           $"group={exercise.MuscleGroup}&" +
                           $"synergist={exercise.MuscleSynergists}&" +
                           $"stabilizer={exercise.MuscleStabilizers}&" +
                           $"enabled={exercise.Enabled}";
            try
            {
                await _functionClient.GetFromJsonAsync<bool>(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return ex.Message;
            }

            return "OK";
        }
    }
}


