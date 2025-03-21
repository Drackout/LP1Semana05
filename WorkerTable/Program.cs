using System;
using Bogus;
using Spectre.Console;


namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Initialize Bogus for names, functions
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker("pt_PT");

            int numEmpregados = int.Parse(args[0]);

            // Create table
            Table table = new Table();

            // Table columns
            table.AddColumn("ID");
            table.AddColumn("Name");
            table.AddColumn("Job");



            for (int i = 0; i < numEmpregados; i++)
            {
                // Makes the IndexVariable start on 1.
                faker.IndexVariable++;
                
                // Create rows and Add its values
                table.AddRow(faker.IndexVariable.ToString(), faker.Name.FullName(), faker.Name.JobTitle());
            }

            AnsiConsole.Write(table);
        }
    }
}
