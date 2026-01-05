namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
            lblVez.Text = "Agora é a vez de X";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            // Marcar jogada
            btn.Text = vez;
            vez = (vez == "X") ? "O" : "X";
            lblVez.Text = $"Agora é a vez de {vez}";

            // Verificar vitória X
            if (VerificarVitoria("X"))
            {
                DisplayAlert("Parabéns!", "O X Ganhou!", "Jogar novamente");
                Zerar();
                return;
            }

            // Verificar vitória O
            if (VerificarVitoria("O"))
            {
                DisplayAlert("Parabéns!", "A Bolinha Ganhou!", "Jogar novamente");
                Zerar();
                return;
            }

            // Verificar empate
            if (VerificarEmpate())
            {
                DisplayAlert("Empate!", "Deu velha", "Jogar novamente");
                Zerar();
            }
        }

        bool VerificarVitoria(string jogador)
        {
            return
                // Linhas
                (btn10.Text == jogador && btn11.Text == jogador && btn12.Text == jogador) ||
                (btn20.Text == jogador && btn21.Text == jogador && btn22.Text == jogador) ||
                (btn30.Text == jogador && btn31.Text == jogador && btn32.Text == jogador) ||

                // Colunas
                (btn10.Text == jogador && btn20.Text == jogador && btn30.Text == jogador) ||
                (btn11.Text == jogador && btn21.Text == jogador && btn31.Text == jogador) ||
                (btn12.Text == jogador && btn22.Text == jogador && btn32.Text == jogador) ||

                // Diagonais
                (btn10.Text == jogador && btn21.Text == jogador && btn32.Text == jogador) ||
                (btn30.Text == jogador && btn21.Text == jogador && btn12.Text == jogador);
        }

        bool VerificarEmpate()
        {
            return
                !btn10.IsEnabled &&
                !btn11.IsEnabled &&
                !btn12.IsEnabled &&
                !btn20.IsEnabled &&
                !btn21.IsEnabled &&
                !btn22.IsEnabled &&
                !btn30.IsEnabled &&
                !btn31.IsEnabled &&
                !btn32.IsEnabled;
        }

        void Zerar()
        {
            vez = "X";
            lblVez.Text = "Agora é a vez de X";

            btn10.Text = btn11.Text = btn12.Text = "";
            btn20.Text = btn21.Text = btn22.Text = "";
            btn30.Text = btn31.Text = btn32.Text = "";

            btn10.IsEnabled = btn11.IsEnabled = btn12.IsEnabled = true;
            btn20.IsEnabled = btn21.IsEnabled = btn22.IsEnabled = true;
            btn30.IsEnabled = btn31.IsEnabled = btn32.IsEnabled = true;
        }
    }
}
