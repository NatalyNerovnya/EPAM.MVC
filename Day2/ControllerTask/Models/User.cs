namespace ControllerTask.Models
{
    public class User
    {
        private static int id = 0;

        public string Name { get; set; }

        public string SecondName { get; set; }

        public int Id {
            get
            {
                return id;
            }
            private set {
                id = value;
            }
        }

        public User()
        {
            this.Id++;
        }
    }
}