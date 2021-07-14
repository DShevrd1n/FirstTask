namespace ConsoleApp1
{
    class Person
    {
        int Age { get; set; }
        string Name { get; set; }
        public Person(int Age,string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }
        public Person()
        {

        }
        public string Method1() => ($"Person's Age {Age} Person's Name {Name}");

        
    }
}
