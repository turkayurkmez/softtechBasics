using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
   public class StudentService : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public void AddRange(params Student[] studentItems)
        {
            students.AddRange(studentItems);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                yield return student;
            }
        }

        public void Sort()
        {
            // students.Sort(); içerisinde yazan muhtemelen böyle bir kod:
            //IComparable comparable = (IComparable)students[0];
            //comparable.CompareTo(other);
            students.Sort();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
