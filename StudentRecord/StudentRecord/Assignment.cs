using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    public class Assignment : Class
    {
        public string assignmentName;
        public string category;
        public string weight;
        public string pointsReceived;
        public string totalPoints;
        public double percentage;

        public string displayCategory
        {
            get
            {
                return category + ": " + weight + "%";
            }
        }

        public string displayAssignment
        {
            get
            {
                return category + " - " + weight + "%" + assignmentName + ": " + calculatePercentage(pointsReceived, totalPoints);
            }
        }

        public double calculatePercentage(string pointsReceived, string totalPoints)
        {
            double points = Convert.ToDouble(pointsReceived);
            double total= Convert.ToDouble(totalPoints);
            percentage = points / total;
            return percentage;
        }
    }
}
