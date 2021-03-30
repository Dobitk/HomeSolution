namespace HomeProject.Domain
{
    public class AllManager
    {
        public IEmployeeItems employeeManager { get; set; }
        public IWorkHistoryItems workManager { get; set; }
        public IFamilyItems familyManager { get; set; }

        public AllManager(IEmployeeItems employee, IWorkHistoryItems work, IFamilyItems family)
        {
            employeeManager = employee;
            workManager = work;
            familyManager = family;
        }

 
    }
}
