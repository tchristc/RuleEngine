using RuleEngine.Person.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace RuleEngine.Person.Rules
{
    public class FirstNameDoesNotStartWithCap
    {
        public List<Student> Execute()
        {
            using (var context = new PersonEntities())
            {
                return context.Students.Where("FirstName == \"Tom\"").ToList();
                //return context.Students.Where("FirstName.Substring(0, 1).Equals(FirstName.ToLower().Substring(0, 1))").ToList();
                //return context.Students.Where(s=>s.FirstName.Substring(0, 1) == (s.FirstName.ToLower().Substring(0, 1))).ToList();
            }
            return null;
        }
    }
}
