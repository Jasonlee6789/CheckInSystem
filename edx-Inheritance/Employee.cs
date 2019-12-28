namespace edx_Inheritance
{
    class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        // Public properties
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }

        // Constructor
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
            // add the upper code to increment this newly created "employeeCount" variable and then store that value in the objects ID variable.
        }

        // this method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        //This method returns the employee's name
        public string getName()
        {
            return this.Name;
        }
        // This method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }
        // This method needs to return the employee's ID and Name
        public string toString()
        {
            return this.ID + " " + this.Name;
        }
        //This method returns the employee's ID and Name and confirms that the employee is in the system
        public virtual string employeeStatus()
        {
            return toString() + " is in the company's system";
        }
        // Creates integer variable called "employeeCount" and assigns value to 1
        private static int employeeCount = 1;
        //This creates the variable "employeeCount" that will be incremented as objects are instantiated.
    }
}
