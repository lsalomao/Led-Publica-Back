using Npgsql;

namespace Led.Publica.Domain.Services;

public class DatabaseService
{
    private readonly string _connectionString;

    public DatabaseService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task SalvarTema(string tema)
    {
        await Task.CompletedTask;

        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        using var cmd = new NpgsqlCommand("INSERT INTO posts (tema) VALUES (@tema)", connection);
        cmd.Parameters.AddWithValue("@tema", tema);
        cmd.ExecuteNonQuery();
    }
}
