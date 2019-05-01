using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string courseName;

        public Course(string courseName)
        {
            if (courseName.Trim() != null)
            {
                CourseName = courseName;
            }
            else
            {
                throw new ArgumentNullException("Please enter a name for the course.");
            }
            InstructorName = "STAFF";
        }

        
        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName {
            get { return CourseName; }
            set
            {
                courseName = value;
                if (string.IsNullOrEmpty(courseName))
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits {
            get { return NumberOfCredits; }
            set
            {
                if (value >= 30 || value <= 0)
                {
                    throw new ArgumentException();
                }
            }
        }

    }
}
