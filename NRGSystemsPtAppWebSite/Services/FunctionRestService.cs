using NRGSystemsPtAppWebSite.Models;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json;

namespace NRGSystemsPtAppWebSite.Services
{
    public class FunctionRestService : IFunctionRestService
    {

        readonly HttpClient _functionClient;
        readonly HttpClient _localClient;
        readonly JsonSerializerOptions _serializerOptions = new();

        public FunctionRestService()
        {
            _functionClient = new HttpClient
            {
                BaseAddress = new Uri("https://exercisefunction.azurewebsites.net/")
            };
            _localClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7074/")
            };
        }

        //#region Exercises
        ///// <summary>
        ///// Using Azure Functions
        ///// </summary>
        ///// <returns> All Enabled Exercises </returns>
        //public async Task<List<Exercise>> GetAllExercises()
        //{
        //    var exercises = new List<Exercise>();
        //    try
        //    {
        //        exercises = await _functionClient.GetFromJsonAsync<List<Exercise>>("api/GetExerciseList");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return exercises;
        //}
        //public async Task<List<Exercise>> GetExerciseForMuscleAsync(string muscleGroup)
        //{
        //    var exercises = new List<Exercise>();
        //    try
        //    {
        //        exercises = await _functionClient.GetFromJsonAsync<List<Exercise>>(
        //        $"api/GetExerciseForMuscleAsync?muscleGroup={muscleGroup}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(@"\tERROR {0}", ex.Message);
        //    }
        //    return exercises;
        //}
        //public async Task<List<Exercise>> GetExerciseFromNameAsync(string muscleName)
        //{
        //    var exercises = new List<Exercise>();
        //    try
        //    {
        //        exercises = await _functionClient.GetFromJsonAsync<List<Exercise>>(
        //        $"api/GetExerciseFromNameAsync?muscleName={muscleName}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(@"\tERROR {0}", ex.Message);
        //    }
        //    return exercises;
        //}
        //public async Task<bool> CreateAnExercise(Exercise exercise)
        //{
        //    var newExercise = new Exercise();
        //    try
        //    {
        //        var a = await _functionClient.GetFromJsonAsync<bool>(
        //            $"api/CreateAnExercise?ExerciseName={exercise.ExerciseName}&" +
        //            $"ImageGif={exercise.ImageGif}&" +
        //            $"InstructionPreperation={exercise.InstructionPreperation}&" +
        //            $"InstructionExecution={exercise.InstructionExecution}&" +
        //            $"Comments={exercise.Comments}&" +
        //            $"ClassificationMechanics={exercise.ClassificationMechanics}&" +
        //            $"ClassificationROM={exercise.ClassificationROM}&" +
        //            $"ClassificationForce={exercise.ClassificationForce}&" +
        //            $"MuscleGroup={exercise.MuscleGroup}&" +
        //            $"MuscleSynergists={exercise.MuscleSynergists}&" +
        //            $"MuscleStabilizers={exercise.MuscleStabilizers}&" +
        //            $"Enabled={exercise.Enabled}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(@"\tERROR {0}", ex.Message);
        //        return false;
        //    }

        //    return true;
        //}

        //public async Task<Exercise> GetAnExercise(int exerciseId)
        //{
        //    try
        //    {
        //        return await _functionClient.GetFromJsonAsync<Exercise>(
        //            $"api/GetExerciseById?exerciseId={exerciseId}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return new Exercise();

        //    }
        //}

        //public async Task<string> DeleteAnExercise(int exerciseId)
        //{
        //    try
        //    {
        //        await _localClient.GetFromJsonAsync<string>(
        //            $"api/DeleteExercise?exerciseId={exerciseId}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(@"\tERROR {0}", ex.Message);
        //        return ex.Message;
        //    }
        //    return "OK";
        //}

        //public Task<List<Exercise>> EditAnExercises(Exercise exercise)
        //{
        //    throw new NotImplementedException();
        //}

        //#endregion

        #region Programs
        public async Task<List<ClientsProgram>> GetProgramListAsync(int clientsId)
        {
            var programs = new List<ClientsProgram>();
            try
            {
                programs = await _functionClient.GetFromJsonAsync<List<ClientsProgram>>(
                $"api/GetProgramList?clientsId={clientsId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return programs;
        }

        public async Task<bool> UpdateClientsProgram(ClientsProgram completedProgram)
        {
            try
            {
                var newMessages = await _functionClient.GetFromJsonAsync<bool>(
               // var newMessages = await _localClient.GetFromJsonAsync<bool>(
                    $"api/UpdateProgram?" +
                    $"program_id={completedProgram.ProgramId}&" +
                    $"client_id={completedProgram.ClientId}&" +
                    $"clientsName={completedProgram.ClientName}&" +
                    $"program_title={completedProgram.ProgramTitle}&" +
                    $"date_issued={completedProgram.DateIssued}&" +
                    $"number_of_visits={completedProgram.NumberOfVisits}&" +
                    $"program_used={completedProgram.TimesProgramUsed}&" +
                    $"exercise_name={completedProgram.NameOfExercise}&" +
                    $"image_location={completedProgram.ImageGifLocation}&" +
                    $"weights={completedProgram.Weights}&" +
                    $"reps={completedProgram.Repetitions}&" +
                    $"pt_comments={completedProgram.PtComments}");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return false; // Task.FromResult(false);
        }

        public async Task<List<ClientsProgram>> GetAllPrograms()
        {
            var programs = new List<ClientsProgram>();
            try
            {
                programs = await _functionClient.GetFromJsonAsync<List<ClientsProgram>>(
                $"api/GetAllPrograms");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return programs;
        }

        public async Task<ClientsProgram> GetProgramFromProgramId(int programId)
        {
            try
            {
                return await _functionClient.GetFromJsonAsync<ClientsProgram>(
                    $"api/GetProgramFromProgramId?programId={programId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ClientsProgram();
            }
        }
        public Task<ClientsProgram> GetAProgramsById(int programId)
        {
            throw new NotImplementedException();
        }
        public async Task<string> CreateAProgram(ClientsProgram exercise)
        {
            try
            {
                //                return await _functionClient.GetFromJsonAsync<string>(

                return await _functionClient.GetFromJsonAsync<string>(
                $"api/CreateProgram?ProgramId={exercise.ProgramId}&" +
                            $"ClientId={exercise.ClientId}&" +
                            $"ClientName={exercise.ClientName}&" +
                            $"ProgramTitle={exercise.ProgramTitle}&" +
                            $"DateIssued={exercise.DateIssued}&" +
                            $"NumberOfVisits={exercise.NumberOfVisits}&" +
                            $"TimesProgramUsed={exercise.TimesProgramUsed}&" +
                            $"NameOfExercise={exercise.NameOfExercise}&" +
                            $"ImageGifLocation={exercise.ImageGifLocation}&" +
                            $"Weights={exercise.Weights}&" +
                            $"Repetitions={exercise.Repetitions}&" +
                            $"PtComments={exercise.PtComments}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return ex.Message;
            }
        }

        public async Task<List<ClientsProgram>> GetProgramListByTitle(string title)
        {
            var programs = new List<ClientsProgram>();
            try
            {
                programs = await _functionClient.GetFromJsonAsync<List<ClientsProgram>>(
                $"api/GetAllProgramsByTitle?programTitle={title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return programs;
        }

        public async Task<List<ClientsProgram>> GetAClientsProgramsById(int clientsId)
        {
            var programs = new List<ClientsProgram>();
            try
            {
                programs = await _functionClient.GetFromJsonAsync<List<ClientsProgram>>(
              //  programs = await _localClient.GetFromJsonAsync<List<ClientsProgram>>(
                $"api/GetAllProgramsById?clientsId={clientsId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return programs;
        }

        public async Task<List<ClientsProgram>> AddNewProgramList(List<ClientsProgram> programlist)
        {
            List<ClientsProgram> newProgram = [];
            foreach (ClientsProgram program in programlist)
            {
                var result = await CreateAProgram(program);
                if (result == "Ok")

                    newProgram.Add(program);

                else
                {
                    int i = 0;
                }
            }
            return newProgram;
        }

        public Task<List<ClientsProgram>> DeleteProgram(int clientsId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Muscles
        public async Task<List<Muscle>> GetMuscleListAsync()
        {
            var muscles = new List<Muscle>();
            try
            {

                var x = await _functionClient.GetFromJsonAsync<List<Muscle>>("api/Muscle");
                foreach (var y in x)
                {
                    Muscle newMuscle = new()
                    {
                        Name = y.Name,
                        Image = y.Image,
                        Insertion = y.Insertion,
                        IsChecked = false,
                        Location = y.Location,
                        MuscleId = y.MuscleId,
                        Origin = y.Origin,
                        StringName = y.StringName
                    };
                    muscles.Add(newMuscle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return muscles;
        }
        #endregion

        #region Reports
        public async Task<bool> UploadProgramReport(ProgramReports report)
        {
            string command = $"api/CreateReport?" +
                    $"ReportId={report.ReportId}&" +
                    $"Reported={report.Reported}&" +
                    $"TimeOfSession={report.TimeOfSession}&" +
                    $"ClientId={report.ClientId}&" +
                    $"ClientName={report.ClientName}&" +
                    $"ProgramId={report.ProgramId}&" +
                    $"ProgramTitle={report.ProgramTitle}&" +
                    $"DateIssued={report.DateIssued}&" +
                    $"NameOfExercise={report.NameOfExercise}&" +
                    $"weights_set={report.WeightsSet}&" +
                    $"reps_set={report.RepsSet}&" +
                    $"Weights={report.Weights}&" +
                    $"RepsCompleted={report.RepsCompleted}&" +
                    $"TrainingTime={report.TrainingTime}&" +
                    $"RestingTime={report.RestingTime}&" +
                    $"ClientsComments={report.ClientsComments}";

            try
            {                
                //var a = await _localClient.GetFromJsonAsync<ProgramReports>(command);
                var a = await _functionClient.GetAsync(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return false;
        }
        
        public async Task<bool> MarkReportAsReadAsync(int reportId)
        {
            string command = $"api/MarkReportRead?" +
                    $"updatedProgramId={reportId}";

            try
            {                
                //var a = await _localClient.GetAsync(command);
                var a = await _functionClient.GetAsync(command);
                if (a.IsSuccessStatusCode)
                    return true;
                //var a = await _functionClient.GetAsync(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return false;
        }

        public async Task<List<ProgramReports>> GetClientsReports(int clientsId)
        {   // ONLY THE PT GETS THE REPORTS, THEN THE PT GENERATES AN ASSESSMENT FOR THE CLIENT TO VIEW.
            try
            {  
                //return await _functionClient.GetFromJsonAsync<List<ProgramReports>>($"api/GetClientsReports?clientsId={clientsId}");
                return await _functionClient.GetFromJsonAsync<List<ProgramReports>>($"api/GetReportListAsync");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return new List<ProgramReports>();
        }

        public async Task<List<ProgramReports>> GetReportListAsync(int id)
        {
            var reports = new List<ProgramReports>();
            List<string> foundReports = [];
            try
            {
                var report = await _functionClient.GetFromJsonAsync<List<ProgramReports>>("api/GetReportListAsync");
                foreach (var y in report)
                {
                    if (y.ReportId == id)
                    {
                        ProgramReports newReport = new()
                        {
                            Reported = y.Reported,
                            TimeOfSession = y.TimeOfSession,
                            ClientId = y.ClientId,
                            ClientName = y.ClientName,
                            ProgramId = y.ProgramId,
                            DateIssued = y.DateIssued,
                            NameOfExercise = y.NameOfExercise,
                            WeightsSet = y.WeightsSet,
                            RepsSet = y.RepsSet,
                            Weights = y.Weights,
                            RepsCompleted = y.RepsCompleted,
                            TrainingTime = y.TrainingTime,
                            RestingTime = y.RestingTime,
                            ClientsComments = y.ClientsComments,
                            ReportId = y.ReportId
                        };
                        reports.Add(newReport);
                        //if (!foundReports.Contains(y.ProgramTitle))
                        //{
                        //    foundReports.Add(y.ProgramTitle);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return reports;
        }

        public Task<ProgramReports> GetAReport(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProgramReports>> GetAllReports()
        {
            return await _functionClient.GetFromJsonAsync<List<ProgramReports>>("api/GetReportListAsync");
           // return await _localClient.GetFromJsonAsync<List<ProgramReports>>("api/GetReportListAsync");
        }

        public Task<ProgramReports> EditAReport(ProgramReports report)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Heart Rate

        public async Task<bool> UploadHeartRateDataTAzure(HeartRateStorage hr)
        {
            try
            {
                HttpResponseMessage response = await _functionClient.PostAsJsonAsync("api/HeartRateStorage", hr);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(@"\tHeartRate successfully saved.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return false;
        }

        public async Task<List<HeartRateStorage>> GetHeartRateListAsync(int id)
        {
            var hr = new List<HeartRateStorage>();
            try
            {
                var azHeartRate = await _functionClient.GetFromJsonAsync<List<HeartRateStorage>>("api/HeartRate");
                foreach (var y in azHeartRate)
                {
                    if (y.ClientsId == id)
                    {
                        HeartRateStorage newHR = new()
                        {
                            HrIndex = y.HrIndex,
                            ClientsId = y.ClientsId,
                            HeartRateTimeStamp = y.HeartRateTimeStamp,
                            StorageData = y.StorageData,
                            Times = y.Times
                        };
                        hr.Add(newHR);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return hr;
        }
        #endregion

        #region MESSAGES
        public async Task<List<MessageModel>> GetMessagesListAsync(int id)
        {
            var messages = new List<MessageModel>();
            List<string> foundMessages = [];
            try
            {
                var azMessages = await _functionClient.GetFromJsonAsync<List<MessageModel>>("api/Message");
                foreach (var y in azMessages)
                {
                    if (y.ClientsId == id)
                    {
                        MessageModel newMessages = new()
                        {
                            MessageId = y.MessageId,
                            TimeMessageSent = y.TimeMessageSent,
                            Text = y.Text,
                            MessageRead = y.MessageRead,
                            ClientsId = y.ClientsId
                        };
                        messages.Add(newMessages);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return messages;
        }

        public async Task<MessageModel> EditAMessage(MessageModel message)
        {
            try
            {
                await _functionClient.GetFromJsonAsync<List<MessageModel>>(
                    $"api/EditMessage?MessageId = {message.MessageId}&" +
                    $"TimeMessageSent = {message.TimeMessageSent}&" +
                    $"Text = {message.Text}& +" +
                    $"MessageRead = {message.MessageRead}&" +
                    $"ClientsId = {message.ClientsId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return message;
        }

        public async Task<List<MessageModel>> GetAllMessages()
        {
            var messages = new List<MessageModel>();
            List<string> foundMessages = [];
            try
            {
                var azMessages = await _functionClient.GetFromJsonAsync<List<MessageModel>>("api/GetAllMessages");

                foreach (var y in azMessages)
                {
                    MessageModel newMessages = new()
                    {
                        MessageId = y.MessageId,
                        TimeMessageSent = y.TimeMessageSent,
                        Text = y.Text,
                        MessageRead = y.MessageRead,
                        ClientsId = y.ClientsId
                    };
                    messages.Add(newMessages);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return messages;
        }
        #endregion
    }
}

