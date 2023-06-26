using BackgroundService;
using Hangfire;

GlobalConfiguration.Configuration
    .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
    .UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseSqlServerStorage("Server = (localdb)\\MSSQLLocalDB;Database=EmailService; Integrated Security=True;");


BackgroundJob.Enqueue(() => Console.WriteLine("Hello from Email service"));

using (new BackgroundJobServer())
{
    EventFactory.CreateConnection("Start publishing event");
    Console.ReadKey();
}

//RecurringJob.AddOrUpdate(() => Console.WriteLine("Recurring job completed successfully!"), Cron.Minutely);



