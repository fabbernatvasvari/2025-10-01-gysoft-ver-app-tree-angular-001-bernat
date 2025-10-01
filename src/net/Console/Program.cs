using MyApp.Console.Repos;
using System.Net.Http.Headers;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

static async Task<string> GetTeacherData(HttpClient client)
{
    string data = await client.GetStringAsync(
        "https://localhost:7120/api/Teacher/count");

    return data;
}

string teacherData = await GetTeacherData(client);

TeacherRepo teachers = new(int.Parse(teacherData));

Console.WriteLine(teachers.ToString());