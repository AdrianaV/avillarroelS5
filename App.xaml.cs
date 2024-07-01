using avillarroelS5.Utils;
using avillarroelS5.Views;

namespace avillarroelS5
{
    public partial class App : Application
    {
        public static PersonRepository personRepo { get; set; }
        public App(PersonRepository person)
        {
            InitializeComponent();

            MainPage = new vHome();
            personRepo = person;

        }
    }
}
