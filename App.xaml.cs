using avillarroelS5.Utils;
using avillarroelS5.Views;

namespace avillarroelS5
{
    public partial class App : Application
    {
        public static PersonRepository personrepo { get; set; }
        public App(PersonRepository person)
        {
            InitializeComponent();

            MainPage = new vHome();
            personrepo = person;

        }
    }
}
