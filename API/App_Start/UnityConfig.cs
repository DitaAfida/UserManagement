using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using Common.Repository;
using Common.Repository.Application;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // this is for repository 
            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<IAplicationRepository, AplicationRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IPositionRepository, PositionRepository>();
            container.RegisterType<IProvinceRepository, ProvinceRepository>();
            container.RegisterType<IRegencyRepository, RegencyRepository>();
            container.RegisterType<IDistrictRepository, DistrictRepository>();
            container.RegisterType<IVillageRepository, VillageRepository>();
            container.RegisterType<IReligionRepository, ReligionRepository>();

            // this is for service 
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IAplicationService, AplicationService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IDepartmentService, DepartmentService>();
            container.RegisterType<IPositionService, PositionService>();
            container.RegisterType<IProvinceService, ProvinceService>();
            container.RegisterType<IRegencyService, RegencyService>();
            container.RegisterType<IDistrictService, DistrictService>();
            container.RegisterType<IVillageService, VillageService>();
            container.RegisterType<IReligionService, ReligionService>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}