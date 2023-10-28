using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using DataManagementSuite.ServiceReference1;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Net;
using System.Drawing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataManagementSuite
{
    public partial class formulario : Form
    {
        private List<int> numbers = new List<int>();

        public class clsTeste
        {
            public int codigo { get; set; }
            public string descricao { get; set; }
        }

        public class Banco
        {
            public int Id { get; set; }
            public string ispb { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string fullName { get; set; }
        }

        public formulario()
        {
            InitializeComponent();
            listView2.View = View.List;
            listView2.Columns.Add("", -2);
            listView1.Items.Clear();
            listView3.View = View.List;
            listView3.Columns.Add("", -2);
            listView3.Enabled = false;

            buttonGravarLista.Visible = false;
            buttonAbrirArquivo.Visible = false;
            buttonLimparLista.Visible = false;
            buttonLimparGrid.Visible = false;
            dataGridView1.Visible = false;
            buttonLimpar.Visible = false;
            buttonLimparGridBanco.Visible = false;
            label12.Visible = false;

            this.MinimumSize = new System.Drawing.Size(Width, Height);
            this.MaximumSize = new System.Drawing.Size(Width, Height);
        }

        //CÓDIGO PAGINA 01

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                string selectedValue = listView2.SelectedItems[0].Text;
                MessageBox.Show("Valor selecionado: " + selectedValue);
            }
        }
        
        private void inputDeValor_TextChanged(object sender, EventArgs e) { }

        private void buttonAdicionarNumero_Click(object sender, EventArgs e)
        {
            buttonAbrirArquivo.Visible = false;

            if (int.TryParse(inputDeValor.Text, out int inputValue))
            {
                numbers.Add(inputValue);

                numbers.Sort();

                listView2.Items.Clear();

                foreach (int number in numbers)
                {
                    listView2.Items.Add(number.ToString());
                }

                inputDeValor.Clear();

                buttonLimparLista.Visible = true;

                buttonGravarLista.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor inteiro válido.");

                inputDeValor.Clear();
            }
        }

        private void buttonGravarLista_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                numbers.Sort();

                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(currentDirectory, "E:\\Users\\Eduardo Smith\\OneDrive - Diretório Padrão\\Área de Trabalho\\new_paste\\testeAvaliativoDotNet\\DataManagementSuite\\numeros_ordenar.txt");

                File.WriteAllLines(filePath, numbers.ConvertAll(n => n.ToString()));

                listView2.Items.Clear();

                MessageBox.Show("Valores gravados com sucesso!");

                buttonAbrirArquivo.Visible = true;
                buttonLimparLista.Visible = false;
            }
            else
            {
                MessageBox.Show("Não há valores para gravar.");
            }
            numbers.Clear();

            listView2.Items.Clear();
        }

        private void buttonAbrirArquivo_Click(object sender, EventArgs e)
        {
            string filePath = @"E:\Users\Eduardo Smith\OneDrive - Diretório Padrão\Área de Trabalho\new_paste\testeAvaliativoDotNet\DataManagementSuite\numeros_ordenar.txt";

            if (File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
                buttonLimparLista.Visible = false;
                buttonGravarLista.Visible = false;
            }
            else
            {
                MessageBox.Show("O arquivo 'numeros_ordenar.txt' não foi encontrado no caminho especificado.");
                buttonAbrirArquivo.Visible = false;
                buttonLimparLista.Visible = false;
                buttonGravarLista.Visible = false;
            }
        }

        private void labelInput_Click(object sender, EventArgs e) { }

        private void tabPage1_Click(object sender, EventArgs e) { }

        private void buttonLimparLista_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                numbers.Clear();

                listView2.Items.Clear();

                inputDeValor.Clear();

                buttonGravarLista.Visible = false;
                buttonAbrirArquivo.Visible = false;
                buttonLimparLista.Visible = false;
            }
        }

        //CÓDIGO PAGINA 02

        private void tabControlPage02_Click(object sender, EventArgs e) { }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void buttonCriarDataJson_Click(object sender, EventArgs e)
        {
            List<clsTeste> listaTeste = new List<clsTeste>();
            for (int i = 1; i <= 100; i++)
            {
                listaTeste.Add(new clsTeste
                {
                    codigo = i,
                    descricao = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")
                });
            }

            string filePath = "E:\\Users\\Eduardo Smith\\OneDrive - Diretório Padrão\\Área de Trabalho\\new_paste\\testeAvaliativoDotNet\\DataManagementSuite\\data.json";
            string json = JsonConvert.SerializeObject(listaTeste);
            File.WriteAllText(filePath, json);

            MessageBox.Show("Arquivo data.json criado ou atualizado com sucesso.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void buttonCarregarGrid_Click(object sender, EventArgs e)
        {
            string filePath = "E:\\Users\\Eduardo Smith\\OneDrive - Diretório Padrão\\Área de Trabalho\\new_paste\\testeAvaliativoDotNet\\DataManagementSuite\\data.json";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<clsTeste> listaTeste = JsonConvert.DeserializeObject<List<clsTeste>>(json);

                dataGridView1.DataSource = listaTeste;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dataGridView1.Visible = true;
                listView1.Items.Clear();
                listView1.Visible = false;

                if (dataGridView1.Rows.Count > 0)
                {
                    buttonLimparGrid.Visible = true;
                }
                else
                {
                    buttonLimparGrid.Visible = false;
                }

                MessageBox.Show("Grid carregado com sucesso.");
            }
            else
            {
                MessageBox.Show("O arquivo data.json não foi encontrado.");
            }
        }

        private void buttonLimparGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataGridView1.Visible = false;
            listView1.Visible = true;

            buttonLimparGrid.Visible = false;
        }

        //CÓDIGO PAGINA 03

        private void LimparEndereco()
        {
            listView3.Items.Clear();
            buttonLimpar.Visible = false;
        }

        private void LimparCampos()
        {
            inputPesquisa.Text = string.Empty;
        }

        private void inputPesquisa_TextChanged(object sender, EventArgs e) { }

        private void ConsultaCEP(string cep)
        {
            var client = new AtendeClienteClient("AtendeClientePort");

            try
            {
                var endereco = client.consultaCEP(cep);

                if (endereco == null || string.IsNullOrEmpty(endereco.cep))
                {
                    LimparEndereco();
                    LimparCampos();
                    listView3.Items.Add("CEP não encontrado");
                }
                else
                {
                    var enderecoObj = new
                    {
                        bairro = endereco.bairro,
                        cep = endereco.cep,
                        cidade = endereco.cidade,
                        complemento2 = endereco.complemento2,
                        end = endereco.end,
                        uf = endereco.uf,
                        unidadesPostagem = endereco.unidadesPostagem
                    };

                    string jsonEndereco = Newtonsoft.Json.JsonConvert.SerializeObject(enderecoObj, Newtonsoft.Json.Formatting.Indented);

                    LimparEndereco();

                    string[] jsonLines = jsonEndereco.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (var line in jsonLines)
                    {
                        listView3.Items.Add(line);
                    }
                }
            }
            catch (System.Exception ex)
            {
                LimparEndereco();
                LimparCampos();
                listView3.Items.Add("CEP não encontrado");
            }
            finally
            {
                if (client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    client.Close();
                }
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                string jsonEndereco = listView3.SelectedItems[0].Text;

                LimparEndereco();
                LimparCampos();

                listView3.Items.Add(jsonEndereco);
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            string cep = inputPesquisa.Text;

            string cpfDigitsOnly = new string(cep.Where(char.IsDigit).ToArray());


            if (string.IsNullOrEmpty(cpfDigitsOnly))
            {
                MessageBox.Show("Valor vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparEndereco();
                LimparCampos();
            }
            else if (cpfDigitsOnly.Length != 8)
            {
                MessageBox.Show("CEP inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparEndereco();
                LimparCampos();
            }
            else
            {
                cep = cpfDigitsOnly;

                ConsultaCEP(cep);
                buttonLimpar.Visible = true;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparEndereco();
            LimparCampos();
        }

        //PAGINA 04

        private void LimparDataGridView2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            buttonLimparGridBanco.Visible = false;
        }

        private async void buttonLimparGridBanco_Click(object sender, EventArgs e)
        {
            LimparDataGridView2();
        }

        private async void buttonConsultaBancos_Click(object sender, EventArgs e)
        {
            LimparDataGridView2();

            var bancos = await ConsultarBancosAsync();

            if (bancos != null)
            {
                dataGridView2.DataSource = bancos;
                buttonLimparGridBanco.Visible = true;
            }
        }

        private async Task<List<Banco>> ConsultarBancosAsync()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    string apiUrl = "https://brasilapi.com.br/api/banks/v1";
                    var response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var bancos = JsonConvert.DeserializeObject<List<Banco>>(json);

                        for (int i = 0; i < bancos.Count; i++)
                        {
                            bancos[i].Id = i + 1;
                        }

                        if (bancos.Count >= 2)
                        {
                            bancos.RemoveRange(bancos.Count - 2, 2);
                        }

                        return bancos;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao consultar a API de bancos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erro ao consultar a API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                string ispb = row.Cells["ispb"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();
                string code = row.Cells["code"].Value.ToString();
                string fullName = row.Cells["fullName"].Value.ToString();

                string message = $"ISPB: {ispb}\nName: {name}\nCode: {code}\nFull Name: {fullName}";

                MessageBox.Show(message, "Detalhes do Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //PAGINA 05

        private void DownloadImageAndDisplay()
        {
            string localImagePath = @"E:\Users\Eduardo Smith\OneDrive - Diretório Padrão\Área de Trabalho\new_paste\testeAvaliativoDotNet\DataManagementSuite\eduardoLehmamSmith.jpeg";

            if (File.Exists(localImagePath))
            {
                try
                {
                    Image image = Image.FromFile(localImagePath);

                    // Configurar o PictureBox para exibir a imagem com tamanho máximo
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = image;

                    // Limpar o RichTextBox
                    richTextBox1.Text = string.Empty;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O arquivo de imagem local não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBaixarGravar_Click(object sender, EventArgs e)
        {
            DownloadImageAndDisplay();
            label12.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e) { }
    }
}
