using PhoneBook.Application.Companies;
using PhoneBook.Application.Persons;
using System.Threading.Tasks;

namespace PhoneBook.Application.PersonAndCompany
{
    // service implementaiton for returning comapnies and persons in aggrigate object
    public class CompanyPersonAggrigateService : Service, ICompanyPersonAggrigateService
    {
        // services
        private readonly ICompanyService _companyService;
        private readonly IPersonService _personService;
        public CompanyPersonAggrigateService(ICompanyService companyService, IPersonService personService)
        {
            _companyService = companyService;
            _personService = personService;
        }

        public async Task<PersonAndCompanyDto> GetByName(string name) =>
            new PersonAndCompanyDto
            {
                Companies = await _companyService.Get(name: name),
                Persons = await _personService.Get(name: name)
            };

    }
}
