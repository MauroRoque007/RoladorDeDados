namespace RoladorDados
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            /* count++;

             if (count == 1)
                 CounterBtn.Text = $"Clicked {count} time";
             else
                 CounterBtn.Text = $"Clicked {count} times";

             SemanticScreenReader.Announce(CounterBtn.Text);*/
        }

        private void RolarDadoBtn_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(QteLadosPck.SelectedItem);
            int valor;
            Random rnd = new();
            valor = rnd.Next(1, n + 1);
            NumSorteadoLbl.Text = Convert.ToString(valor);


        }
    }

}
