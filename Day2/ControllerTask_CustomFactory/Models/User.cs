namespace ControllerTask_CustomFactory.Models
{
    public class User
    {
        private static int id = 0;

        public string Name { get; set; }

        public string SecondName { get; set; }

        public int Id { get; private set; }

        public User()
        {
            this.Id = id++;
        }
    }
}