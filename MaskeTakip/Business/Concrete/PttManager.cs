using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService applicantService;
        public PttManager(IApplicantService applicantService)
        {
            this.applicantService = applicantService;

        }

        public void GiveMask(Person person)
        {
            if (applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " icin maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " icin maske verilemedi");
            }
        }
    }
}
