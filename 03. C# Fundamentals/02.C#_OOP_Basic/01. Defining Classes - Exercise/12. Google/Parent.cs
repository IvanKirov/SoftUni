namespace _12._Google
{
    public class Parent
    {
        private string name;
        private string birthday;

        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.birthday = birthday;
        }

        public string Name { get => this.name; set => this.name = value; }

        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
    }
}
