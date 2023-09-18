using Jobbie.Db.Services;

namespace Jobbie.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IBankAccountService, BankAccountService>();
            services.AddScoped<IContractorService, ContractorService>();
            services.AddScoped<IDeadlineTypeService, DeadlineTypeService>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IJobSubtypeService, JobSubtypeService>();
            services.AddScoped<IJobTypeJobSubtypeService, JobTypeJobSubtypeService>();
            services.AddScoped<IJobTypeService, JobTypeService>();
            services.AddScoped<ILicenseService, LicenseService>();
            services.AddScoped<ISolicitationContractorService, SolicitationContractorService>();
            services.AddScoped<ISolicitationDeadlineService, SolicitationDeadlineService>();
            services.AddScoped<ISolicitationService, SolicitationService>();
            services.AddScoped<ISolicitorService, SolicitorService>();
            services.AddScoped<ISpecialtyService, SpecialtyService>();
            services.AddScoped<IStateService, StateService>();
        }
    }
}
