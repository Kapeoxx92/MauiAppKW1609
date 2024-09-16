namespace MauiAppKW1609
{
    public partial class MainPage : ContentPage
    {


        public MainPage() => InitializeComponent();

        public int RollValue { get; private set; }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int diceRoll = r.Next(1, 7);

            CounterBtn.Text = "Wysolowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);

            Random random = new Random();
            if (kostkak4.IsChecked == true)
            {
                int roll = r.Next(1, 5);
                RollValueLabel.Text = roll.ToString();
            }

            else if (kostkak6.IsChecked == true)
            {
                int roll = r.Next(1, 7);
                RollValueLabel.Text = roll.ToString();
            }
        }

    }
}