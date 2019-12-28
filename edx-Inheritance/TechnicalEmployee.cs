namespace edx_Inheritance
{
    //TechnicalEmployee Class inheriting from Employee Class
    class TechnicalEmployee : Employee
    {
        // Calls upon base-class (Employee Class) constructor from within derived class (TechnicalEmployee Class)
        // Sets baseSalary to 75000 for all TechnicalEmployee objects
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        // Creates integer variable called "successfulCheckIns" and assigns value to 5
        public int successfulCheckIns = 5;

        // I need to use the "override" keyword in our method header to override the inherited version and create our sub class specific method. 
        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns +
                " successful check ins";
        }
        // This method returns the toString() method - which is the employee's ID number and name - and prints the number of successful check ins the employee has had.
    }

}
