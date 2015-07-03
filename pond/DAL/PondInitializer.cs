using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Pond.Web.Domain;

namespace Pond.Web.DAL
{
    public class PondInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PondDbContext>
    {
        protected override void Seed(PondDbContext context)
        {

            base.Seed(context);

            // Seed the data required for the system to work correctly
            SeedSystemData(context);

            // Seed the test/demo data
            SeedTestData(context);

            context.SaveChanges();
        }

        private void SeedTestData(PondDbContext context)
        { 

            /*
            * Initialize Service Categories
            */
            var serviceCategories = new List<ServiceCategory>
            {
                new ServiceCategory{Name="Plumbers", Description="Plumbing Services"},
                new ServiceCategory{Name="Builders", Description="Building Services"},
                new ServiceCategory{Name="Architects", Description="Architect Services"},
                new ServiceCategory{Name="Electricians", Description="Electricians & Electrical Services"},
                new ServiceCategory{Name="Carpenters & Joiners", Description="Carpentry & Joinery Services"},
                new ServiceCategory{Name="Gas Engineers", Description="Gas Engineers"},
                new ServiceCategory{Name="Hairdressers", Description="Hairdressers, Hairdressing salons etc."},
                new ServiceCategory{Name="Nail Care", Description="Nail Care"},
                new ServiceCategory{Name="Accountants", Description="Accountants"},
                new ServiceCategory{Name="Financial Advisors", Description="Financial Advisors"},
                new ServiceCategory{Name="Mortgage Advisors", Description="Mortgage Advisors"},
                new ServiceCategory{Name="Tax Advisors", Description="Tax Advisors"}
            };

            serviceCategories.ForEach(s => context.ServiceCategories.Add(s));

        }

        private void SeedSystemData(PondDbContext context)
        {
            // Service Provider Account States
            var serviceProviderAccountStates = new List<ServiceProviderAccountState>
            {
                new ServiceProviderAccountState{ID=(int)ServiceProviderAccountStateValues.AwaitingRegConfirmation,Description="Awaiting Registration Confirmation", IsSystem = true, IsActive = true },
                new ServiceProviderAccountState{ID=(int)ServiceProviderAccountStateValues.Registered,Description="Registered", IsSystem = true, IsActive = true },
                new ServiceProviderAccountState{ID=(int)ServiceProviderAccountStateValues.Suspended,Description="Suspended", IsSystem = true, IsActive = true },
                new ServiceProviderAccountState{ID=(int)ServiceProviderAccountStateValues.Cancelled,Description="Cancelled", IsSystem = true, IsActive = true }

            };
            serviceProviderAccountStates.ForEach(s => context.ServiceProviderAccountStates.Add(s));
        }
    }
}