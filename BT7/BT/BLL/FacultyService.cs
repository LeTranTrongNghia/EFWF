using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class FacultyService
    {
        public static List<Faculty> GetAll()
        {
            StudentModels context = new StudentModels();
            return context.Faculties.ToList();
        }
    }
}
