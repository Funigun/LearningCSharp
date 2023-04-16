namespace DelegatesDemoLibrary.Services
{
    internal static class Workflows
    {
        internal static void CustomDelegateOverview()
        {
            CustomDelegateService delegatesService = new CustomDelegateService();
            EmployeeService employeeService = new EmployeeService();

            // Passing employeeService "ShowMessage" method as parameter
            delegatesService.ShowInformation(employeeService.ShowMessage);

            // Passing employeeService method and function as parameters
            delegatesService.ShowCalculatedSalary(employeeService.ShowMessage, employeeService.CalculateSalary, 7);

            delegatesService.ShowCalculatedSalary(employeeService.ShowMessage, employeeService.CalculateSalary, 11.5);
        }

        internal static void ActionDelegateOverview()
        {
            BuiltInDelegatesService delegatesService = new BuiltInDelegatesService();
            EmployeeService employeeService = new EmployeeService();

            // Passing employeeService "ShowMessage" method as parameter
            delegatesService.ShowInformation(employeeService.ShowMessage);
        }

        internal static void FuncDelegateOverview()
        {
            BuiltInDelegatesService delegatesService = new BuiltInDelegatesService();
            EmployeeService employeeService = new EmployeeService();

            // Passing employeeService method and function as parameters
            delegatesService.ShowCalculatedSalary(employeeService.ShowMessage, employeeService.CalculateSalary, 7);

            delegatesService.ShowCalculatedSalary(employeeService.ShowMessage, employeeService.CalculateSalary, 11.5);
        }
    }
}
