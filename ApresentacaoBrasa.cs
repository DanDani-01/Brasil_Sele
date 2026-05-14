using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Selecao_Brasa_POO
{
    internal class ApresentacaoBrasa : Form
    {
        Goleiro jogador1 = new Goleiro();
        Jogadores jogador2 = new Jogadores();
        Jogadores jogador3 = new Jogadores();
        Jogadores jogador4 = new Jogadores();
        Jogadores jogador5 = new Jogadores();
        Jogadores jogador6 = new Jogadores();
        Jogadores jogador7 = new Jogadores();
        Jogadores jogador8 = new Jogadores();
        Jogadores jogador9 = new Jogadores();
        Jogadores jogador10 = new Jogadores();
        Jogadores jogador11 = new Jogadores();
        Goleiro jogador12 = new Goleiro();

        PictureBox img = new PictureBox();
        PictureBox img2 = new PictureBox();
        PictureBox img3 = new PictureBox();

        Label lblTitulo = new Label();
        Label lblNom = new Label();
        Label lblPos = new Label();
        Label lblTim = new Label();
        Label lblNum = new Label();
        Label lblIda = new Label();
        Label lblNom2 = new Label();
        Label lblPos2 = new Label();
        Label lblTim2 = new Label();
        Label lblNum2 = new Label();
        Label lblIda2 = new Label();

        Button btnGol = new Button();
        Button btnZag1 = new Button();
        Button btnZag2 = new Button();
        Button btnLat1 = new Button();
        Button btnLat2 = new Button();
        Button btnMeia1 = new Button();
        Button btnMeia2 = new Button();
        Button btnPont1 = new Button();
        Button btnPont2 = new Button();
        Button btnAtac1 = new Button();
        Button btnAtac2 = new Button();


        public ApresentacaoBrasa()
        {
            this.Text = "Seleção Brasileira";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitulo.Text = "Seleção Brasileira";
            lblTitulo.Font = new Font("Arial", 25, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(510, 30);

            btnGol.Text = "GOLEIRO!";
            btnGol.Size = new Size(80, 25);
            btnGol.Location = new Point(235, 560);
            btnGol.Click += BtnGol_Click;

            btnZag1.Text = "ZAGUEIRO!";
            btnZag1.Size = new Size(80, 25);
            btnZag1.Location = new Point(320, 520);
            btnZag2.Text = "ZAGUEIRO!";
            btnZag2.Size = new Size(80, 25);
            btnZag2.Location = new Point(150, 520);
            btnZag1.Click += BtnZag_Click;
            btnZag2.Click += BtnZag_Click;

            btnMeia1.Text = "MEIO CAMPO!";
            btnMeia1.Size = new Size(80, 25);
            btnMeia1.Location = new Point(320, 400);
            btnMeia2.Text = "MEIO CAMPO!";
            btnMeia2.Size = new Size(80, 25);
            btnMeia2.Location = new Point(150, 400);
            btnMeia2.Click += BtnMeia_Click;
            btnMeia1.Click += BtnMeia_Click;

            btnLat1.Text = "LATERAL!";
            btnLat1.Size = new Size(80, 25);
            btnLat1.Location = new Point(400, 460);
            btnLat2.Text = "LATERAL!";
            btnLat2.Size = new Size(80, 25);
            btnLat2.Location = new Point(80, 460);
            btnLat1.Click += BtnLat_Click;
            btnLat2.Click += BtnLat_Click;

            btnPont1.Text = "PONTA!";
            btnPont1.Size = new Size(80, 25);
            btnPont1.Location = new Point(400, 340);
            btnPont2.Text = "PONTA!";
            btnPont2.Size = new Size(80, 25);
            btnPont2.Location = new Point(80, 340);
            btnPont1.Click += BtnPont_Click;
            btnPont2.Click += BtnPont_Click;

            btnAtac1.Text = "ATACANTE!";
            btnAtac1.Size = new Size(80, 25);
            btnAtac1.Location = new Point(170, 280);
            btnAtac2.Text = "ATACANTE!";
            btnAtac2.Size = new Size(80, 25);
            btnAtac2.Location = new Point(310, 280);
            btnAtac1.Click += BtnAtac_Click;
            btnAtac2.Click += BtnAtac_Click;


            try
            {
                
                Bitmap bmp = new Bitmap(@"C:\Users\LabInfo\Source\Repos\Brasil_Sele\img\campo.jpg");

               
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);

                
                img.Image = bmp;
                img.SizeMode = PictureBoxSizeMode.StretchImage;

                
                img.Width = 450;
                img.Height = 500;

                this.img.Location = new Point(50, 115);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }


            Control[] elementos = { lblTitulo, lblNom, lblPos, lblTim, lblNum, lblIda, btnGol, btnZag1, btnZag2, btnLat1, btnLat2, btnMeia1, btnMeia2, btnPont1, btnPont2, btnAtac1, btnAtac2, img, img2, img3, lblNom2, lblPos2, lblTim2, lblNum2, lblIda2 };
            this.Controls.AddRange(elementos);

            btnGol.BringToFront();
            btnZag1.BringToFront();
            btnZag2.BringToFront();
            btnLat1.BringToFront();
            btnLat2.BringToFront();
            btnPont1.BringToFront();
            btnPont2.BringToFront();
            btnMeia1.BringToFront();
            btnMeia2.BringToFront();
            btnAtac1.BringToFront();
            btnAtac2.BringToFront();

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnGol_Click(object sender, EventArgs e)
        {
            jogador1.Nome = "Alisson";
            jogador1.Posicao = "Goleiro" ;
            jogador1.Numero = 1;
            jogador1.Time = "Liverpool";
            jogador1.Idade = 30;
            jogador12.Nome = "Hugo Souza";
            jogador12.Posicao = "Goleiro";
            jogador12.Numero = 1;
            jogador12.Time = "Corinthians";
            jogador12.Idade = 37;

            lblNom.Text = "Nome: " + jogador1.Nome;
            lblPos.Text = jogador1.PosicaoCamp();
            lblNum.Text = "Número: " + jogador1.Numero;
            lblTim.Text = "Time: " + jogador1.Time;
            lblIda.Text = "Idade: " + jogador1.Idade;
            lblNom2.Text = "Nome: " + jogador12.Nome;
            lblPos2.Text = jogador12.PosicaoCamp(); ;
            lblNum2.Text = "Número: " + jogador12.Numero;
            lblTim2.Text = "Time: " + jogador12.Time;
            lblIda2.Text = "Idade: " + jogador12.Idade;



            img2.Image = Properties.Resources.alisson;
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);
            img3.Image = Properties.Resources.hugo;
            img3.SizeMode = PictureBoxSizeMode.StretchImage;
            img3.Size = new Size(200, 275);

            this.img2.Location = new Point(550, 120);
            this.img3.Location = new Point(850, 120);
            lblNom.Location = new Point(545, 400);
            lblPos.Location = new Point(545, 430);
            lblNum.Location = new Point(545, 460);
            lblTim.Location = new Point(545, 490);
            lblIda.Location = new Point(545, 520);
            lblNom2.Location = new Point(845, 400);
            lblPos2.Location = new Point(845, 430);
            lblNum2.Location = new Point(845, 460);
            lblTim2.Location = new Point(845, 490);
            lblIda2.Location = new Point(845, 520);

            lblNom.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNom2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda2.Font = new Font("Arial", 16, FontStyle.Bold);

            lblNom.AutoSize = true;
            lblPos.AutoSize = true;
            lblNum.AutoSize = true;
            lblTim.AutoSize = true;
            lblIda.AutoSize = true;
            lblNom2.AutoSize = true;
            lblPos2.AutoSize = true;
            lblNum2.AutoSize = true;
            lblTim2.AutoSize = true;
            lblIda2.AutoSize = true;



        }

        public void BtnZag_Click(object sender, EventArgs e)
        {
            jogador2.Nome = "Marquinhos";
            jogador2.Posicao = "Zagueiro";
            jogador2.Numero = 4;
            jogador2.Time = "PSG";
            jogador2.Idade = 30;
            jogador3.Nome = "Magalhães";
            jogador3.Posicao = "Zagueiro";
            jogador3.Numero = 3;
            jogador3.Time = "Arsenal";
            jogador3.Idade = 29;

            lblNom.Text = "Nome: " + jogador2.Nome;
            lblPos.Text = jogador2.PosicaoCamp(); ;
            lblNum.Text = "Número: " + jogador2.Numero;
            lblTim.Text = "Time: " + jogador2.Time;
            lblIda.Text = "Idade: " + jogador2.Idade;

            lblNom2.Text = "Nome: " + jogador3.Nome;
            lblPos2.Text = jogador3.PosicaoCamp(); ;
            lblNum2.Text = "Número: " + jogador3.Numero;
            lblTim2.Text = "Time: " + jogador3.Time;
            lblIda2.Text = "Idade: " + jogador3.Idade;

            img2.Image = Properties.Resources.marquinhos;
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);
            this.img2.Location = new Point(550, 120);
            img3.Image = Properties.Resources.magalhaes;
            img3.SizeMode = PictureBoxSizeMode.StretchImage;
            img3.Size = new Size(200, 275);
            this.img3.Location = new Point(850, 120);

            lblNom.Location = new Point(545, 400);
            lblPos.Location = new Point(545, 430);
            lblNum.Location = new Point(545, 460);
            lblTim.Location = new Point(545, 490);
            lblIda.Location = new Point(545, 520);
            lblNom2.Location = new Point(845, 400);
            lblPos2.Location = new Point(845, 430);
            lblNum2.Location = new Point(845, 460);
            lblTim2.Location = new Point(845, 490);
            lblIda2.Location = new Point(845, 520);

            lblNom.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNom2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda2.Font = new Font("Arial", 16, FontStyle.Bold);

            lblNom.AutoSize = true;
            lblPos.AutoSize = true;
            lblNum.AutoSize = true;
            lblTim.AutoSize = true;
            lblIda.AutoSize = true;
            lblNom2.AutoSize = true;
            lblPos2.AutoSize = true;
            lblNum2.AutoSize = true;
            lblTim2.AutoSize = true;
            lblIda2.AutoSize = true;
        }

        public void BtnLat_Click(object sender, EventArgs e)
        {
            jogador4.Nome = "Alex Sandro";
            jogador4.Posicao = "Lateral Esquerdo";
            jogador4.Numero = 6;
            jogador4.Time = "Flamengo";
            jogador4.Idade = 32;
            jogador5.Nome = "Danilo";
            jogador5.Posicao = "Lateral Direito";
            jogador5.Numero = 2;
            jogador5.Time = "Flamengo";
            jogador5.Idade = 32;

            lblNom.Text = "Nome: " + jogador4.Nome;
            lblPos.Text = jogador4.PosicaoCamp(); ;
            lblNum.Text = "Número: " + jogador4.Numero;
            lblTim.Text = "Time: " + jogador4.Time;
            lblIda.Text = "Idade: " + jogador4.Idade;

            lblNom2.Text = "Nome: " + jogador5.Nome;
            lblPos2.Text = jogador5.PosicaoCamp();
            lblNum2.Text = "Número: " + jogador5.Numero;
            lblTim2.Text = "Time: " + jogador5.Time;
            lblIda2.Text = "Idade: " + jogador5.Idade;

            img2.Image = Properties.Resources.alex;
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);
            this.img2.Location = new Point(550, 120);
            img3.Image = Properties.Resources.danilo;
            img3.SizeMode = PictureBoxSizeMode.StretchImage;
            img3.Size = new Size(200, 275);
            this.img3.Location = new Point(850, 120);

            lblNom.Location = new Point(545, 400);
            lblPos.Location = new Point(545, 430);
            lblNum.Location = new Point(545, 460);
            lblTim.Location = new Point(545, 490);
            lblIda.Location = new Point(545, 520);
            lblNom2.Location = new Point(845, 400);
            lblPos2.Location = new Point(845, 430);
            lblNum2.Location = new Point(845, 460);
            lblTim2.Location = new Point(845, 490);
            lblIda2.Location = new Point(845, 520);

            lblNom.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNom2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda2.Font = new Font("Arial", 16, FontStyle.Bold);

            lblNom.AutoSize = true;
            lblPos.AutoSize = true;
            lblNum.AutoSize = true;
            lblTim.AutoSize = true;
            lblIda.AutoSize = true;
            lblNom2.AutoSize = true;
            lblPos2.AutoSize = true;
            lblNum2.AutoSize = true;
            lblTim2.AutoSize = true;
            lblIda2.AutoSize = true;
        }

        public void BtnMeia_Click(object sender, EventArgs e)
        {
            jogador6.Nome = "Bruno Guimaraes";
            jogador6.Posicao = "Meio Campo";
            jogador6.Numero = 17;
            jogador6.Time = "Newcastle United";
            jogador6.Idade = 28;
            jogador7.Nome = "Casemiro";
            jogador7.Posicao = "Meio campista";
            jogador7.Numero = 5;
            jogador7.Time = "Manchester United";
            jogador7.Idade = 34;

            lblNom.Text = "Nome: " + jogador6.Nome;
            lblPos.Text = jogador6.PosicaoCamp();
            lblNum.Text = "Número: " + jogador6.Numero;
            lblTim.Text = "Time: " + jogador6.Time;
            lblIda.Text = "Idade: " + jogador6.Idade;

            lblNom2.Text = "Nome: " + jogador7.Nome;
            lblPos2.Text = jogador7.PosicaoCamp();
            lblNum2.Text = "Número: " + jogador7.Numero;
            lblTim2.Text = "Time: " + jogador7.Time;
            lblIda2.Text = "Idade: " + jogador7.Idade;

            img2.Image = Properties.Resources.bruno;
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);
            this.img2.Location = new Point(550, 120);
            img3.Image = Properties.Resources.casemiro;
            img3.SizeMode = PictureBoxSizeMode.StretchImage;
            img3.Size = new Size(200, 275);
            this.img3.Location = new Point(850, 120);

            lblNom.Location = new Point(545, 400);
            lblPos.Location = new Point(545, 430);
            lblNum.Location = new Point(545, 460);
            lblTim.Location = new Point(545, 490);
            lblIda.Location = new Point(545, 520);
            lblNom2.Location = new Point(845, 400);
            lblPos2.Location = new Point(845, 430);
            lblNum2.Location = new Point(845, 460);
            lblTim2.Location = new Point(845, 490);
            lblIda2.Location = new Point(845, 520);

            lblNom.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNom2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda2.Font = new Font("Arial", 16, FontStyle.Bold);

            lblNom.AutoSize = true;
            lblPos.AutoSize = true;
            lblNum.AutoSize = true;
            lblTim.AutoSize = true;
            lblIda.AutoSize = true;
            lblNom2.AutoSize = true;
            lblPos2.AutoSize = true;
            lblNum2.AutoSize = true;
            lblTim2.AutoSize = true;
            lblIda2.AutoSize = true;
        }

        public void BtnPont_Click(object sender, EventArgs e)
        {
            jogador8.Nome = "Raphinha";
            jogador8.Posicao = "Ponta Direita";
            jogador8.Numero = 11;
            jogador8.Time = "Barcelona";
            jogador8.Idade = 30;
            jogador9.Nome = "Neymar";
            jogador9.Posicao = "Ponta Esquerda";
            jogador9.Numero = 10;
            jogador9.Time = "Santos";
            jogador9.Idade = 32;

            lblNom.Text = "Nome: " + jogador8.Nome;
            lblPos.Text = jogador8.PosicaoCamp();
            lblNum.Text = "Número: " + jogador8.Numero;
            lblTim.Text = "Time: " + jogador8.Time;
            lblIda.Text = "Idade: " + jogador8.Idade;

            lblNom2.Text = "Nome: " + jogador9.Nome;
            lblPos2.Text = jogador9.PosicaoCamp();
            lblNum2.Text = "Número: " + jogador9.Numero;
            lblTim2.Text = "Time: " + jogador9.Time;
            lblIda2.Text = "Idade: " + jogador9.Idade;

            img2.Image = Properties.Resources.raphinha;
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);
            this.img2.Location = new Point(550, 120);
            img3.Image = Properties.Resources.neymar;
            img3.SizeMode = PictureBoxSizeMode.StretchImage;
            img3.Size = new Size(200, 275);
            this.img3.Location = new Point(850, 120);

            lblNom.Location = new Point(545, 400);
            lblPos.Location = new Point(545, 430);
            lblNum.Location = new Point(545, 460);
            lblTim.Location = new Point(545, 490);
            lblIda.Location = new Point(545, 520);
            lblNom2.Location = new Point(845, 400);
            lblPos2.Location = new Point(845, 430);
            lblNum2.Location = new Point(845, 460);
            lblTim2.Location = new Point(845, 490);
            lblIda2.Location = new Point(845, 520);

            lblNom.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNom2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda2.Font = new Font("Arial", 16, FontStyle.Bold);

            lblNom.AutoSize = true;
            lblPos.AutoSize = true;
            lblNum.AutoSize = true;
            lblTim.AutoSize = true;
            lblIda.AutoSize = true;
            lblNom2.AutoSize = true;
            lblPos2.AutoSize = true;
            lblNum2.AutoSize = true;
            lblTim2.AutoSize = true;
            lblIda2.AutoSize = true;

        }

        public void BtnAtac_Click(object sender, EventArgs e)
        {
            jogador10.Nome = "Richarlison";
            jogador10.Posicao = "Atacante";
            jogador10.Numero = 9;
            jogador10.Time = "Tottenham";
            jogador10.Idade = 30;
            jogador11.Nome = "Vinicius Jr.";
            jogador11.Posicao = "Atacante";
            jogador11.Numero = 9;
            jogador11.Time = "Real Madrid";
            jogador11.Idade = 28;

            lblNom.Text = "Nome: " + jogador10.Nome;
            lblPos.Text = jogador10.PosicaoCamp();
            lblNum.Text = "Número: " + jogador10.Numero;
            lblTim.Text = "Time: " + jogador10.Time;
            lblIda.Text = "Idade: " + jogador10.Idade;

            lblNom2.Text = "Nome: " + jogador11.Nome;
            lblPos2.Text = jogador11.PosicaoCamp();
            lblNum2.Text = "Número: " + jogador11.Numero;
            lblTim2.Text = "Time: " + jogador11.Time;
            lblIda2.Text = "Idade: " + jogador11.Idade;

            img2.Image = Properties.Resources.richarlison;
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);
            this.img2.Location = new Point(550, 120);
            img3.Image = Properties.Resources.vinicius;
            img3.SizeMode = PictureBoxSizeMode.StretchImage;
            img3.Size = new Size(200, 275);
            this.img3.Location = new Point(850, 120);

            lblNom.Location = new Point(545, 400);
            lblPos.Location = new Point(545, 430);
            lblNum.Location = new Point(545, 460);
            lblTim.Location = new Point(545, 490);
            lblIda.Location = new Point(545, 520);
            lblNom2.Location = new Point(845, 400);
            lblPos2.Location = new Point(845, 430);
            lblNum2.Location = new Point(845, 460);
            lblTim2.Location = new Point(845, 490);
            lblIda2.Location = new Point(845, 520);

            lblNom.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNom2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim2.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda2.Font = new Font("Arial", 16, FontStyle.Bold);

            lblNom.AutoSize = true;
            lblPos.AutoSize = true;
            lblNum.AutoSize = true;
            lblTim.AutoSize = true;
            lblIda.AutoSize = true;
            lblNom2.AutoSize = true;
            lblPos2.AutoSize = true;
            lblNum2.AutoSize = true;
            lblTim2.AutoSize = true;
            lblIda2.AutoSize = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ApresentacaoBrasa
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "ApresentacaoBrasa";
            this.Load += new System.EventHandler(this.ApresentacaoBrasa_Load);
            this.ResumeLayout(false);

        }

        private void ApresentacaoBrasa_Load(object sender, EventArgs e)
        {

        }
    }
}

