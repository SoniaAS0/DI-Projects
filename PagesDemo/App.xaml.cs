namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPAge = new AppShell();
            //MainPage = new MainPage();
            //MainPage = new ContentPageDemo();
            MainPage = new TabbedPageDemo();

        }
    }
}
