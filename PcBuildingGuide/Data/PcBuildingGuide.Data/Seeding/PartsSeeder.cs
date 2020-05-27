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
            await SeedCpus(dbContext);
            await SeedAirCoolers(dbContext);
            await SeedCases(dbContext);
            await SeedHardDisks(dbContext);
            await SeedMemories(dbContext);
            await SeedMotherboards(dbContext);
            await SeedPsus(dbContext);
            await SeedSsds(dbContext);
            await SeedVideoCards(dbContext);
            await SeedWaterCoolers(dbContext);
        }

        private static async Task SeedWaterCoolers(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectWaterCoolersSql, connection);
                var waterCoolers = new List<WaterCooler>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var waterCooler = new WaterCooler
                        {
                            Brand = reader["Brand"].ToString(),
                            FanAirFlow = reader["FanAirFlow"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            BlockCompatibility = reader["BlockCompatibility"].ToString(),
                            FanRPM = reader["FanRPM"].ToString(),
                            Name = reader["Name"].ToString(),
                            FanSize = reader["FanSize"].ToString(),
                            PumpCapacity = reader["PumpCapacity"].ToString(),
                            RadiatorDim = reader["RadiatorDim"].ToString(),
                            TubeDim = reader["TubeDim"].ToString(),
                            Type = reader["Type"].ToString(),
                            CategoryId = 6,
                        };
                        waterCoolers.Add(waterCooler);
                    }

                    dbContext.WaterCoolers.AddRange(waterCoolers);
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

        private static async Task SeedVideoCards(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectVideoCardsSql, connection);
                var videoCards = new List<VideoCard>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var videoCard = new VideoCard
                        {
                            Brand = reader["Brand"].ToString(),
                            Cooler = reader["Cooler"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            DirectX = reader["DirectX"].ToString(),
                            FormFactor = reader["FormFactor"].ToString(),
                            Name = reader["Name"].ToString(),
                            Interface = reader["Interface"].ToString(),
                            GPU = reader["GPU"].ToString(),
                            MaxGPULength = reader["MaxGPULength"].ToString(),
                            Model = reader["Model"].ToString(),
                            OpenGL = reader["OpenGL"].ToString(),
                            SlotWidth = reader["SlotWidth"].ToString(),
                            StreamProcessors = reader["StreamProcessors"].ToString(),
                            SystemRequirements = reader["SystemRequirements"].ToString(),
                            CategoryId = 4,
                        };
                        videoCards.Add(videoCard);
                    }

                    dbContext.VideoCards.AddRange(videoCards);
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

        private static async Task SeedSsds(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectSolidStateDrivesSql, connection);
                var ssds = new List<SolidStateDrive>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var ssd = new SolidStateDrive
                        {
                            Brand = reader["Brand"].ToString(),
                            Capacity = reader["Capacity"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            DeviceType = reader["DeviceType"].ToString(),
                            FormFactor = reader["FormFactor"].ToString(),
                            Name = reader["Name"].ToString(),
                            Interface = reader["Interface"].ToString(),
                            MemoryComponents = reader["MemoryComponents"].ToString(),
                            UsedFor = reader["UsedFor"].ToString(),
                            CategoryId = 8,
                        };
                        ssds.Add(ssd);
                    }

                    dbContext.SolidStateDrives.AddRange(ssds);
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

        private static async Task SeedPsus(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectPSUsSql, connection);
                var psus = new List<PSU>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var psu = new PSU
                        {
                            Brand = reader["Brand"].ToString(),
                            EnergyEfficiency = reader["EnergyEfficiency"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            Fans = reader["Fans"].ToString(),
                            MaximumPower = reader["MaximumPower"].ToString(),
                            Name = reader["Name"].ToString(),
                            Modular = reader["Modular"].ToString(),
                            Type = reader["Type"].ToString(),
                            CategoryId = 7,
                        };
                        psus.Add(psu);
                    }

                    dbContext.PowerSupplies.AddRange(psus);
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

        private static async Task SeedMotherboards(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectMotherboardsSql, connection);
                var motherboards = new List<Motherboard>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var motherboard = new Motherboard
                        {
                            Brand = reader["Brand"].ToString(),
                            AudioChipset = reader["AudioChipset"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            LANChipset = reader["LANChipset"].ToString(),
                            Chipset = reader["Chipset"].ToString(),
                            Name = reader["Name"].ToString(),
                            Model = reader["Model"].ToString(),
                            CPUSocketType = reader["CPUSocketType"].ToString(),
                            CPUType = reader["CPUType"].ToString(),
                            FormFactor = reader["FormFactor"].ToString(),
                            MaxLANSpeed = reader["MaxLANSpeed"].ToString(),
                            MemoryStandard = reader["MemoryStandard"].ToString(),
                            NumberOfMemorySlots = reader["NumberOfMemorySlots"].ToString(),
                            CategoryId = 3,
                        };
                        motherboards.Add(motherboard);
                    }

                    dbContext.Motherboards.AddRange(motherboards);
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

        private static async Task SeedMemories(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectMemoriesSql, connection);
                var memories = new List<Memory>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var memory = new Memory
                        {
                            Brand = reader["Brand"].ToString(),
                            CASLatency = reader["CASLatency"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            Capacity = reader["Capacity"].ToString(),
                            HeatSpreader = reader["HeatSpreader"].ToString(),
                            Name = reader["Name"].ToString(),
                            Model = reader["Model"].ToString(),
                            Series = reader["Series"].ToString(),
                            Speed = reader["Speed"].ToString(),
                            Timing = reader["Timing"].ToString(),
                            Type = reader["Type"].ToString(),
                            CategoryId = 2,
                        };
                        memories.Add(memory);
                    }

                    dbContext.Memories.AddRange(memories);
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

        private static async Task SeedHardDisks(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectHardDiskDrivesSql, connection);
                var hardDisks = new List<HardDiskDrive>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var hardDisk = new HardDiskDrive
                        {
                            Brand = reader["Brand"].ToString(),
                            Cache = reader["Cache"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            Capacity = reader["Capacity"].ToString(),
                            FormFactor = reader["FormFactor"].ToString(),
                            Name = reader["Name"].ToString(),
                            Interface = reader["Interface"].ToString(),
                            RPM = reader["RPM"].ToString(),
                            Usage = reader["Usage"].ToString(),
                            CategoryId = 8,
                        };
                        hardDisks.Add(hardDisk);
                    }

                    dbContext.HardDiskDrives.AddRange(hardDisks);
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

        private static async Task SeedCases(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectCasesSql, connection);
                var cases = new List<Case>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var curentCase = new Case
                        {
                            Brand = reader["Brand"].ToString(),
                            MaxCPUCoolerHeightAllowance = reader["MaxCPUCoolerHeightAllowance"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            CaseMaterial = reader["CaseMaterial"].ToString(),
                            MaxGPULengthAllowance = reader["MaxGPULengthAllowance"].ToString(),
                            Name = reader["Name"].ToString(),
                            Color = reader["Color"].ToString(),
                            ExpansionSlots = reader["ExpansionSlots"].ToString(),
                            MotherboardCompatibility = reader["MotherboardCompatibility"].ToString(),
                            SidePanelWindow = reader["SidePanelWindow"].ToString(),
                            Type = reader["Type"].ToString(),
                            CategoryId = 5,
                        };
                        cases.Add(curentCase);
                    }

                    dbContext.Cases.AddRange(cases);
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

        private static async Task SeedAirCoolers(ApplicationDbContext dbContext)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(SqlCommands.SelectAirCoolersSql, connection);
                var airCoolers = new List<AirCooler>();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                try
                {
                    while (reader.Read())
                    {
                        var airCooler = new AirCooler
                        {
                            Brand = reader["Brand"].ToString(),
                            CPUSocketCompatibility = reader["CPUSocketCompatibility"].ToString(),
                            Image = (byte[])reader["Image"],
                            ImgUrl = reader["ImgUrl"].ToString(),
                            FanSize = reader["FanSize"].ToString(),
                            HeatsinkDimensions = reader["HeatsinkDimensions"].ToString(),
                            Name = reader["Name"].ToString(),
                            MaxCPUCoolerHeight = reader["MaxCPUCoolerHeight"].ToString(),
                            PowerConnector = reader["PowerConnector"].ToString(),
                            RPM = reader["RPM"].ToString(),
                            Weight = reader["Weight"].ToString(),
                            CategoryId = 6,
                        };
                        airCoolers.Add(airCooler);
                    }

                    dbContext.AirCoolers.AddRange(airCoolers);
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

        private static async Task SeedCpus(ApplicationDbContext dbContext)
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
                            Image = (byte[])reader["Image"],
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
