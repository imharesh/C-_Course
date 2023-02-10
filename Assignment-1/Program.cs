namespace EmployeeAssignment
{

    // Employee class take three properties Id, Name, DepartmentName 
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }


        // Employee class  delegate  MethodCalledEventHandler and event MethodCalled


        public delegate void MethodCalledEventHandler(string message);
        public event MethodCalledEventHandler MethodCalled;

        // Constructor 
        public Employee(int id, string name, string departmentName)
        {
            Id = id;
            Name = name;
            DepartmentName = departmentName;
        }

        // Get Method for all three Properties
        public int GetId()
        {
            OnMethodCalled(" method call");
            return Id;
        }

        public string GetName()
        {
            OnMethodCalled(" method call");

            return Name;
        }

        public string GetDepartmentName()
        {
            OnMethodCalled(" method call");

            return DepartmentName;
        }
         
        // update the three method        
        public void Update(int id)
        {
            Id = id;
        }
        public void Update(string name)
        {
            Name = name;
        }
        public void Update(string departmentName, int id = -1)
        {
            DepartmentName = departmentName;
            if (id != -1)
            {
                id = id;
            }
        }
        protected virtual void OnMethodCalled(string message)
        {
            MethodCalled?.Invoke(message);
        }

        // main method
        static void Main(string[] args)
        {
            // take input 
            Console.WriteLine("Enter Employee id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name : ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Employee DepartmentName : ");
            var departmentName = Convert.ToString(Console.ReadLine());

            // instance of the employee  
            Employee employee = new Employee(id, name, departmentName);


            // Print Info
            Console.WriteLine("Employee Information : ");
            Console.WriteLine("ID: " + employee.GetId());
            Console.WriteLine("Name: " + employee.GetName());
            Console.WriteLine("DepartmentName: " + employee.GetDepartmentName());


            Console.ReadLine();
        }
    }
}            