namespace ByteBite_Express
{
    public partial class Form1 : Form
    {
        private readonly TouchTriggerButton[] categoryButtons;
        private readonly LeftTabScript leftTabScript = new LeftTabScript();
        private readonly MiddleTabScript middleTabScript = new MiddleTabScript();
        public Form1()
        {
            InitializeComponent();
            categoryButtons = new[] { categoryBtn1, categoryBtn2, categoryBtn3, categoryBtn4, categoryBtn5, categoryBtn6 };
            leftTabScript.Run(categoryButtons);
            middleTabScript.Run(MenuGrid, CategoryDisplayLabel, categoryButtons);
            AppState.SelectedValueChanged += AppState.ClearSelectedItem;
        }

        private void categoryBtn1_Click(object sender, EventArgs e)
        {

        }
    }
}
