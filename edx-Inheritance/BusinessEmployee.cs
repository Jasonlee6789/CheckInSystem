namespace edx_Inheritance
{
    // BusinessEmployee Class inheriting from Employee Class
    class BusinessEmployee : Employee
    {
        // I need to create the constructor for our BusinessEmployee() Class that sets the base salary to 50000. To do so, use the base keyword again and type the following code:
        public BusinessEmployee(string name, double baseSalary) : base(name, 50000)
        {
            // Sets baseSalary to 50000 for all BusinessEmployee objects
        }
        //  Calls upon base-class (Employee Class) constructor from within derived class (BusinessEmployee Class)

        // Creates double variable called "bonusBudget" and assigns value to 1000
        public double bonusBudget = 1000;


        // Now I am ready to write the code for the method! We will be using the "override" keyword again to create the unique sub class version of this method. 
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
        // This method returns the toString() method - which is the employee's ID number and name - and prints the bonus budget
    }
}
