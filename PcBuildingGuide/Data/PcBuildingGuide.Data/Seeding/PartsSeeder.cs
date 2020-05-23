namespace PcBuildingGuide.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.Data.SqlClient;
    using PcBuildingGuide.Data.Models.Parts;

    public class PartsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectCpusSql, connection);
                var cpus = new List<Cpu>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var cpu = new Cpu
                        {
                            Brand = reader["Brand"].ToString(),
                            Series = reader["Series"].ToString(),
                            CPUSocketType = reader["CPUSocketType"].ToString(),
                            ImgUrl = reader["ImgUrl"].ToString(),
                            ManufacturingTech = reader["ManufacturingTech"].ToString(),
                            Model = reader["Model"].ToString(),
                            Name = reader["Name"].ToString(),
                            NumberOfCores = reader["NumberOfCores"].ToString(),
                            NumberOfThreads = reader["NumberOfThreads"].ToString(),
                            ProcesorType = reader["ProcesorType"].ToString(),
                            TDP = reader["TDP"].ToString(),
                            CategoryId = 1,
                        };
                        cpus.Add(cpu);
                    }

                    dbContext.Cpus.AddRange(cpus);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}
