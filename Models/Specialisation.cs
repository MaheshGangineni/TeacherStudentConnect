using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeacherStudentConnect.Models
{
    public class Specialisation
    {
        public IEnumerable<SelectListItem> SpecialisationList
        {
            get
            {
                return new List<SelectListItem>()
                     {
                       new SelectListItem { Text = "Accounting", Value = "Accounting" },
                        new SelectListItem { Text = "Acquisitions", Value = "Acquisitions" },
                        new SelectListItem { Text = "Banking", Value = "Banking" },
                        new SelectListItem { Text = "Big Data Analytics", Value = "Big Data Analytics" },
                        new SelectListItem { Text = "Business Intelligence", Value = "Business Intelligence" },
                        new SelectListItem { Text = "Communications", Value = "Communications" },
                        new SelectListItem { Text = "Consultancy", Value = "Consultancy" },
                        new SelectListItem { Text = "Corporate Social Responsibility (CSR)", Value = "Corporate Social Responsibility (CSR)" },
                        new SelectListItem { Text = "Criminal Justice", Value = "Criminal Justice" },
                        new SelectListItem { Text = "Cyber Security", Value = "Cyber Security" },
                        new SelectListItem { Text = "e-business", Value = "e-business" },
                        new SelectListItem { Text = "Economics", Value = "Economics" },
                        new SelectListItem { Text = "Entrepreneurship", Value = "Entrepreneurship" },
                        new SelectListItem { Text = "Environmental Management", Value = "Environmental Management" },
                        new SelectListItem { Text = "Executive", Value = "Executive" },
                        new SelectListItem { Text = "Fashion Management", Value = "" },
                        new SelectListItem { Text = "Finance", Value = "Finance" },
                        new SelectListItem { Text = "Financial Planning", Value = "Financial Planning" },
                        new SelectListItem { Text = "Global Management", Value = "Global Managemen" },
                        new SelectListItem { Text = "Health Care Administration", Value = "Health Care Administration" },
                        new SelectListItem { Text = "Health Services Administration", Value = "Health Services Administration" },
                        new SelectListItem { Text = "Hospitality Management", Value = "Hospitality Management" },
                        new SelectListItem { Text = "Human Resources", Value = "Human Resources" },
                        new SelectListItem { Text = "Industry/Operations", Value = "Industry/Operations" },
                        new SelectListItem { Text = "Information Management", Value = "" },
                        new SelectListItem { Text = "Information Security", Value = "Information Security" },
                        new SelectListItem { Text = "Information Systems", Value = "Information Systems" },
                        new SelectListItem { Text = "Information Technology", Value = "Information Technology" },
                        new SelectListItem { Text = "Innovation Management", Value = "Innovation Management" },
                        new SelectListItem { Text = "Insurance", Value = "Insurance" },
                        new SelectListItem { Text = "International Business", Value = "International Business" },
                        new SelectListItem { Text = "Internet Marketing", Value = "Internet Marketing" },
                        new SelectListItem { Text = "Leadership", Value = "Leadership" },
                        new SelectListItem { Text = "Logistics", Value = "Logistics" },
                        new SelectListItem { Text = "Management", Value = "Management" },
                        new SelectListItem { Text = "Marketing", Value = "Marketing" },
                        new SelectListItem { Text = "Nonprofit/Ethics", Value = "Nonprofit/Ethics" },
                        new SelectListItem { Text = "Operations Management", Value = "Operations Management" },
                        new SelectListItem { Text = "Organizational Leadership", Value = "Organizational Leadership" },
                        new SelectListItem { Text = "Project Management", Value = "Project Management" },
                        new SelectListItem { Text = "Public Administration", Value = "Public Administration" },
                        new SelectListItem { Text = "Quantitative Analysis", Value = "Quantitative Analysis" },
                        new SelectListItem { Text = "Real Estate Management", Value = "Real Estate Management" },
                        new SelectListItem { Text = "Retail Management", Value = "Retail Management" },
                        new SelectListItem { Text = "Risk Management", Value = "Risk Management" },
                        new SelectListItem { Text = "Sports Management", Value = "Sports Management" },
                        new SelectListItem { Text = "Strategy", Value = "Strategy" },
                        new SelectListItem { Text = "Supply Chain Management", Value = "Supply Chain Management" },
                        new SelectListItem { Text = "Sustainability", Value = "Sustainability" },
                        new SelectListItem { Text = "Taxation", Value = "Taxation" },
                        new SelectListItem { Text = "Technology", Value = "Technology" },


                     };
            }
            set
            {

            }
        }
    }
}