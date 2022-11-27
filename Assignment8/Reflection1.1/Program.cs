using Microsoft.Build.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Reflection1
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true)]
    class SoftwareAttribute : Attribute
    {
        public string SoftwareString { get; set; }
    }
    [Software(SoftwareString = "Class")]
    public class ProjectDetails
    {
        private string ProjectName;
        private string Description;
        private string ClientDetail;
        private string StartDate;
        private string EndDate;
        public string projectname
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public string ClientName
        {
            get { return ClientName; }
            set { ClientName = value; }
        }
        public string startdate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        public string enddate
        {
            get { return EndDate; }
            set
            {
                EndDate = value;
            }
        }
        [Software(SoftwareString = "Constructor")]
        public ProjectDetails(string ProjectName, string Description, string ClientName, string StartDate, string EndDate)
        {
            this.ProjectName = ProjectName;
            this.Description = Description;
            this.ClientDetail = ClientName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        [Software(SoftwareString = "Method")]
        public void Display()
        {
            Console.WriteLine("Project Name:{0} ", ProjectName);
            Console.WriteLine("Description:{0}", Description);
            Console.WriteLine("Client Name : {0}", ClientName);
            Console.WriteLine("Start Date: {0}", StartDate);
            Console.WriteLine("End Date: {0}", EndDate);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ProjectDetails PD = new ProjectDetails("C#", " To Create Appliclatons", "Name:ABC\nPhone.No:1234567890\nEmail:Abc@xyz.com", "07-07-2022", "07-07-2024");
            PD.Display();
            Console.WriteLine("------*******------");
            PD.projectname = "C#";
            PD.description = "To Create Applications";
            PD.ClientName = "Name:ABC\nPhone.No:1234567890\nEmail:Abc@xyz.com";
            PD.startdate = "07-07-2022";
            PD.enddate = "07-07-2024";
            Console.WriteLine("project name :" + PD.projectname);
            Console.WriteLine("description:" + PD.description);
            Console.WriteLine("client Name: " + PD.ClientName);
            Console.WriteLine("start date: " + PD.startdate);
            Console.WriteLine("end date: " + PD.enddate);
        }
    }
    [Software(45, "C#", "ToCreateApplication", "Name:ABC", "07-07-2022", "07-07-2024", Message = "Return type mismatch")]
    [Software(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
}