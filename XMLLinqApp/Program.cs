using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentXML =
                       @"<Students>
                          <Student>
                            <Name>Tony Brown</Name>
                            <Age>21</Age>
                            <Subject>Maths</Subject>
                            <University>Yale</University>
                          </Student>
                          <Student>
                            <Name>Thomas Smith</Name>
                            <Age>22</Age>
                            <Subject>IT</Subject>
                            <University>Yale</University>
                          </Student>
                          <Student>
                            <Name>Susan Shannon</Name>
                            <Age>24</Age>
                            <Subject>Social Studies</Subject>
                            <University>Cambridge</University>
                          </Student>
                          <Student>
                            <Name>Rebecca Thomson</Name>
                            <Age>20</Age>
                            <Subject>Biology</Subject>
                            <University>Cambridge</University>
                          </Student>
                          <Student>
                            <Name>James Wilson</Name>
                            <Age>19</Age>
                            <Subject>Zoology</Subject>
                            <University>Yale</University>
                          </Student>
                          <Student>
                            <Name>Tyler Norton</Name>
                            <Age>20</Age>
                            <Subject>International Relations</Subject>
                            <University>Yale</University>
                          </Student>
                       </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name")?.Value,
                               Age = student.Element("Age")?.Value,
                               Subject = student.Element("Subject")?.Value,
                               University = student.Element("University")?.Value,
                           };

            var studentsByAge = from student in students orderby student.Age select student;

            foreach (var student in studentsByAge)
            {
                Console.WriteLine("Student {0} with age {1} studying {2} from {3} University", student.Name, student.Age, student.Subject, student.University);
            }
        }
    }
}