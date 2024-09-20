using NRGSystemsPtAppWebSite.Models;

namespace NRGSystemsPtAppWebSite.Services;
public interface IFunctionRestService
{
    // EXERCISES
    //Task<bool> CreateAnExercise(Exercise exercise);
    //Task<List<Exercise>> EditAnExercises(Exercise exercise);
    //Task<List<Exercise>> GetAllExercises();
    //Task<Exercise> GetAnExercise(int exerciseId);
    //Task<string> DeleteAnExercise(int exerciseId);
    //Task<List<Exercise>> GetExerciseForMuscleAsync(string muscleGroup);
    //Task<List<Exercise>> GetExerciseFromNameAsync(string muscleName);
    //PROGRAMS
    Task<string> CreateAProgram(ClientsProgram exercise);
    Task<List<ClientsProgram>> AddNewProgramList(List<ClientsProgram> exerciselist);
    Task<List<ClientsProgram>> GetProgramListAsync(int clientsId);
    Task<List<ClientsProgram>> GetProgramListByTitle(string title);
    Task<List<ClientsProgram>> GetAClientsProgramsById(int clientsId);
    Task<ClientsProgram> GetAProgramsById(int programId);
    Task<List<ClientsProgram>> GetAllPrograms();
    Task<bool> UpdateClientsProgram(ClientsProgram completedProgram);
    Task<List<ClientsProgram>> DeleteProgram(int clientsId);
    // MUSCLES
    Task<List<Muscle>> GetMuscleListAsync();
    // REPORTS
    Task<List<ProgramReports>> GetClientsReports(int clientsId);
    Task<bool> UploadProgramReport(ProgramReports report);
    Task<List<ProgramReports>> GetAllReports();
    Task<List<ProgramReports>> GetReportListAsync(int id);
    Task<ProgramReports> GetAReport(int id);
    Task<ProgramReports> EditAReport(ProgramReports report);
    // HEART RATE
    Task<bool> UploadHeartRateDataTAzure(HeartRateStorage hr);
    Task<List<HeartRateStorage>> GetHeartRateListAsync(int id);
    // MESSAGES
    Task<List<MessageModel>> GetAllMessages();
    Task<List<MessageModel>> GetMessagesListAsync(int id);
    Task<MessageModel> EditAMessage(MessageModel message);
}

