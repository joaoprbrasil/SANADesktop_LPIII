using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using SANA.Model.Entities;
using SANA.Util;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;

namespace SANA
{
    public partial class Form1 : Form
    {
        List<Navio> navios = new List<Navio>();

        const string usuario = "admin";
        const string senha = "admin";
        private MySqlConnection? con;



        public Form1()
        {

            InitializeComponent();

            ConexaoBD conexaoBD = new ConexaoBD();
            this.con = conexaoBD.RetornaConexao();

            carregarNavios();
        }



        //metodo apenas para adicionar alguns navios
        private void carregarNavios()
        {
            try
            {
                this.con.Open();
                navios.Add(new Navio("Navio Kappa", 10.3, 2400, 55.0, 5.1, 4.8, 31.0, 16.2, 22.5, 2008, "Graneleiro", "Em processo."));
                navios.Add(new Navio("Navio Lambda", 9.8, 2200, 50.0, 4.5, 4.3, 29.5, 15.0, 21.0, 2006, "Petroleiro", "Em processo."));
                navios.Add(new Navio("Navio Mu", 11.2, 2600, 60.0, 5.4, 5.1, 32.0, 17.5, 23.0, 2011, "Cargueiro", "Em processo."));
                navios.Add(new Navio("Navio Nu", 10.5, 2500, 54.0, 5.0, 4.7, 30.0, 16.0, 22.0, 2009, "Graneleiro", "Em processo."));
                navios.Add(new Navio("Navio Xi", 10.8, 2700, 57.0, 5.3, 5.0, 33.0, 17.0, 23.5, 2014, "Petroleiro", "Em processo."));
                navios.Add(new Navio("Navio Omicron", 9.7, 2300, 52.0, 4.6, 4.4, 28.5, 14.8, 20.5, 2005, "Cargueiro", "Em processo."));
                navios.Add(new Navio("Navio Pi", 11.0, 2800, 59.0, 5.5, 5.2, 34.0, 18.0, 24.0, 2016, "Graneleiro", "Em processo."));
                navios.Add(new Navio("Navio Rho", 10.2, 2400, 55.0, 5.1, 4.9, 31.0, 16.3, 22.3, 2012, "Petroleiro", "Em processo."));
                navios.Add(new Navio("Navio Sigma", 10.6, 2500, 56.0, 5.2, 5.0, 32.0, 17.0, 22.0, 2010, "Cargueiro", "Em processo."));
                navios.Add(new Navio("Navio Tau", 10.1, 2200, 53.0, 4.8, 4.6, 29.0, 15.0, 21.0, 2004, "Graneleiro", "Em processo."));
                navios.Add(new Navio("Navio Alpha", 12.0, 3000, 65.0, 6.0, 5.5, 36.0, 19.0, 26.0, 2017, "Petroleiro", "Em processo."));
                navios.Add(new Navio("Navio Beta", 11.5, 2900, 63.0, 5.8, 5.3, 35.0, 18.5, 25.0, 2015, "Cargueiro", "Em processo."));
                navios.Add(new Navio("Navio Gamma", 12.3, 3100, 68.0, 6.1, 5.6, 37.0, 20.0, 27.0, 2019, "Graneleiro", "Em processo."));
                navios.Add(new Navio("Navio Delta", 11.8, 2800, 62.0, 5.9, 5.4, 34.0, 18.0, 24.0, 2013, "Petroleiro", "Em processo."));
                navios.Add(new Navio("Navio Epsilon", 10.7, 2500, 58.0, 5.2, 5.0, 32.5, 17.2, 23.5, 2010, "Cargueiro", "Em processo."));
                navios.Add(new Navio("Navio Zeta", 12.5, 3200, 70.0, 6.3, 5.7, 38.0, 21.0, 28.0, 2021, "Graneleiro", "Em processo."));
                navios.Add(new Navio("Navio Eta", 11.0, 2700, 60.0, 5.6, 5.2, 33.0, 17.8, 23.0, 2012, "Petroleiro", "Em processo."));
                navios.Add(new Navio("Navio Theta", 10.4, 2600, 57.0, 5.5, 5.1, 32.0, 17.0, 22.5, 2014, "Cargueiro", "Em processo."));
                navios.Add(new Navio("Navio Iota", 11.3, 3100, 65.0, 6.2, 5.8, 35.0, 18.7, 24.5, 2017, "Graneleiro", "Em processo."));
                navios.Add(new Navio("Navio Kappa II", 10.9, 2500, 55.0, 5.0, 4.9, 30.0, 16.0, 22.0, 2009, "Petroleiro", "Em processo."));

                foreach (var navio in navios)
                {
                    string comandoSQL = @"
                    INSERT INTO Navio (NomeNavio, CaladoAereo, DWT, Loa, CaladoSaida, CaladoEntrada, Boca, Pontal, Lanca, AnoConstrucao, Tipo, Solicitacao)
                    VALUES (@NomeNavio, @CaladoAereo, @DWT, @Loa, @CaladoSaida, @CaladoEntrada, @Boca, @Pontal, @Lanca, @AnoConstrucao, @Tipo, @Solicitacao)"
                    ;

                    using (var comando = new MySqlCommand(comandoSQL, con))
                    {
                        comando.Parameters.AddWithValue("@NomeNavio", navio.NomeNavio);
                        comando.Parameters.AddWithValue("@CaladoAereo", navio.CaladoAereo);
                        comando.Parameters.AddWithValue("@DWT", navio.DWT);
                        comando.Parameters.AddWithValue("@Loa", navio.Loa);
                        comando.Parameters.AddWithValue("@CaladoSaida", navio.CaladoSaida);
                        comando.Parameters.AddWithValue("@CaladoEntrada", navio.CaladoEntrada);
                        comando.Parameters.AddWithValue("@Boca", navio.Boca);
                        comando.Parameters.AddWithValue("@Pontal", navio.Pontal);
                        comando.Parameters.AddWithValue("@Lanca", navio.Lanca);
                        comando.Parameters.AddWithValue("@AnoConstrucao", navio.AnoConstrucao);
                        comando.Parameters.AddWithValue("@Tipo", navio.Tipo);
                        comando.Parameters.AddWithValue("@Solicitacao", navio.Solicitacao);
                        comando.ExecuteNonQuery();
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar os navios: {ex.Message}");
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(usuario) && txtBox1.Text.Equals(senha))
            {
                MenuPrincipal telaMenu = new MenuPrincipal();
                telaMenu.FormClosed += TelaMenu_FormClosed;
                telaMenu.Show();
                this.Hide();
            }
            else if (!textBox2.Text.Equals(usuario) || !txtBox1.Text.Equals(senha))
            {
                MessageBox.Show("Usuário ou Senha incorretos!");
            }
        }
        private void TelaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
