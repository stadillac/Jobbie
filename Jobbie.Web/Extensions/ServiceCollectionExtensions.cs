using Jobbie.Db.Services;

namespace Jobbie.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IBankAccountService, BankAccountService>();
            services.AddScoped<ICompanyTypeService, CompanyTypeService>();
            services.AddScoped<IContractorService, ContractorService>();
            services.AddScoped<IContractorSoftwareService, ContractorSoftwareService>();
            services.AddScoped<IDeadlineTypeService, DeadlineTypeService>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IDisciplineService, DisciplineService>();
            services.AddScoped<IExpertiseService, ExpertiseService>();
            services.AddScoped<IFocusService, FocusService>();
            services.AddScoped<ILicenseService, LicenseService>();
            services.AddScoped<IProfessionDisciplineService, ProfessionDisciplineService>();
            services.AddScoped<IProfessionService, ProfessionService>();
            services.AddScoped<IProjectDeliverableService, ProjectDeliverableService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<ISoftwareService, SoftwareService>();
            services.AddScoped<ISolicitationContractorService, SolicitationContractorService>();
            services.AddScoped<ISolicitationDeadlineService, SolicitationDeadlineService>();
            services.AddScoped<ISolicitationRoleProvidedSoftwareService, SolicitationRoleProvidedSoftwareService>();
            services.AddScoped<ISolicitationRoleRequiredSoftwareService, SolicitationRoleRequiredSoftwareService>();
            services.AddScoped<ISolicitationRoleService, SolicitationRoleService>();
            services.AddScoped<ISolicitationService, SolicitationService>();
            services.AddScoped<ISolicitorService, SolicitorService>();
            services.AddScoped<ISpecialtyService, SpecialtyService>();
            services.AddScoped<IStateService, StateService>();
        }
    }
}
