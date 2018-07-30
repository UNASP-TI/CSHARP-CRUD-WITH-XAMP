using Database.Mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnsinoMedio
{
    public partial class Form1 : Form
    {
        unaspContext db;

        public Form1()
        {
            InitializeComponent();
            Load();

        }

        private void Load()
        {

            carregarComboBox();
            carregarDadosGrid();

            limparText();

            txtName.Focus();

            //configaração incial para adequar foto na exibição
            pbFotoAluno.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void limparText()
        {
            // retira todo texto que estão nos text box
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            
            //comboBox
            cmbEstado.SelectedIndex = 0;

            //button
            btCadastrarAluno.Text = "Cadastrar";
            btDeletarAluno.Enabled = false;

            //Imagem
            pbFotoAluno.Image = null;
            //Data da Matricula
            dtpDataMatricula.Value = DateTime.Now;

        }

        private void carregarDadosGrid()
        {

            using (db = new unaspContext())
            {
                //Database query direto na DataSource
                dgvAluno.DataSource = db.Aluno.Select(x =>
                    new
                    {
                        Id = x.Id,
                        Nome = x.Nome,
                        Idade = x.Idade,
                        Estado = x.IdEstadoNavigation.Nome,
                        DataMatricula = x.DataMatricula
                    }).ToList();

                //Configuracoes de DataGridView
                dgvAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAluno.AutoGenerateColumns = false;
                dgvAluno.ReadOnly = true;


                //Customizando as colunas
                dgvAluno.Columns["Id"].Visible = false;
                //dgvAluno.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dgvAluno.Columns["Idade"].HeaderText = "Idade do aluno";
                dgvAluno.Columns["Idade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAluno.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAluno.Columns["DataMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

        }

        private void carregarComboBox()
        {
            using (db = new unaspContext())
            {
                //Adicionando programaticamente um item na comboBox para poder iniciar corretamente o programa
                var list = new List<Object>();

                list.Add(new { Id = -1, Nome = "Selecione o Estado" });
                list.AddRange(db.Estado.Select(x => new { x.Id, x.Nome }).ToList());

                //carregando a cmbox1
                cmbEstado.DataSource = list;
                cmbEstado.DisplayMember = "Nome";
                cmbEstado.ValueMember = "Id";
            }

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                returnImage = Image.FromStream(ms);

            }
            catch
            {
                MessageBox.Show("Erro ao Exibir Imagem!");
            }
            return returnImage;
        }

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void btCreateState_Click(object sender, EventArgs e)
        {
            using (db = new unaspContext())
            {
                Aluno aluno = new Aluno();

                // Se a opção é atualizar, é necessário buscar as informações no banco de dados.
                //O if abaixo verificar se o botão deletar está abilitado ou não.
                if (btDeletarAluno.Enabled)
                {
                    int _id = Convert.ToInt16(dgvAluno.CurrentRow.Cells["Id"].Value);
                    aluno = db.Aluno.FirstOrDefault(x => x.Id == _id);
                }

                //adiciona no objeto aluno informações que estão no Forms
                aluno.Nome = txtName.Text;
                aluno.Idade = Convert.ToInt16(txtIdade.Text);
                aluno.IdEstado = Convert.ToInt32(cmbEstado.SelectedValue);
                aluno.DataMatricula = dtpDataMatricula.Value;

                //convertendo imagem para banco de dados
                if (pbFotoAluno.ImageLocation != null)
                {
                    Image img = resizeImage(pbFotoAluno.Image, new Size(500, 500));
                    byte[] bytes = imageToByteArray(img);
                    aluno.Foto = bytes;
                }


                //somente adiciona quando é um novo aluno
                if (!btDeletarAluno.Enabled)
                    db.Aluno.Add(aluno);


                db.SaveChanges();

                Load();
                //MessageBox.Show("Aluno Adicionado!");

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparText();
        }

        private void dgvAluno_DoubleClick(object sender, EventArgs e)
        {

            btCadastrarAluno.Text = "Atualizar";
            btDeletarAluno.Enabled = true;

            var _grid = dgvAluno.CurrentRow;

            txtName.Text = _grid.Cells["Nome"].Value.ToString();
            txtIdade.Text = _grid.Cells["Idade"].Value.ToString();

            //pega o nome do estado que está na gridView
            string _estado = _grid.Cells["Estado"].Value.ToString();
            cmbEstado.SelectedIndex = cmbEstado.FindStringExact(_estado);

            //Imagem do aluno
            int idAluno = Convert.ToInt16(_grid.Cells["Id"].Value.ToString());
            byte[] fotoAlunoEmByte = retornaImagemDoAluno(idAluno);
            pbFotoAluno.Image = byteArrayToImage(fotoAlunoEmByte);

            //Data da Matricula
            string dataMatricula = _grid.Cells["DataMatricula"].Value.ToString();
            dtpDataMatricula.Value = DateTime.Parse(dataMatricula);
        }

        private byte[] retornaImagemDoAluno(int idAluno)
        {
            using (db = new unaspContext())
            {
                var fotoAluno = db.Aluno.First(x => x.Id == idAluno).Foto;

                return fotoAluno;
            }
        }

        private void btDeletarAluno_Click(object sender, EventArgs e)
        {
            var _grid = dgvAluno.CurrentRow;

            string nomeAluno = _grid.Cells["Nome"].Value.ToString();

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Deletar Aluno - " + nomeAluno, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (DialogResult.Yes == confirm)
            {
                using (db = new unaspContext())
                {
                    int _id = Convert.ToInt16(_grid.Cells["Id"].Value);
                    Aluno aluno = db.Aluno.FirstOrDefault(x => x.Id == _id);

                    db.Aluno.Remove(aluno);
                    db.SaveChanges();
                    Load();
                };
            }
        }

        private void btProcurarFoto_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Selecione a foto do Aluno";
                dlg.Filter = "All Files|*.*|JPG|*.jpg|PNG|*.png|GIF|*.gif";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property

                    pbFotoAluno.ImageLocation = dlg.FileName;
                }
            }
        }
    }
}
