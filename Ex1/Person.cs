namespace Exam_AP
{
    public class Person
    {
        private string _name = "N/A";
        private int _age = 0;

        // Declare a Name property of type string:
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Declare an Age property of type int:
        public int Age
        {
            get { return _age; }

            set { _age = value; }
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }
    }
}