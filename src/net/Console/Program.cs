using MyApp.Console.Repos;
using System.Net.Http.Headers;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

static async Task ProcessRepositoriesAsync(HttpClient client)
{
    string data = await client.GetStringAsync(
        "https://localhost:7120/api/Teacher/count");

    TeacherRepo teachers = new TeacherRepo(int.Parse(data));

    Console.WriteLine(teachers.ToString());
}

await ProcessRepositoriesAsync(client);