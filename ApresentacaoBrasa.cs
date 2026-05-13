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
        Jogadores jogador1 = new Jogadores();
        Jogadores jogador2 = new Jogadores();
        Jogadores jogador3 = new Jogadores();
        Jogadores jogador4 = new Jogadores();
        Jogadores jogador5 = new Jogadores();

        PictureBox img = new PictureBox();
        PictureBox img2 = new PictureBox();
        PictureBox img3 = new PictureBox();
        PictureBox img4 = new PictureBox();
        PictureBox img5 = new PictureBox();

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


            try
            {
                // 1. Carrega a imagem em um Bitmap para garantir a manipulação
                Bitmap bmp = new Bitmap(@"C:\Users\danyb\source\repos\Selecao_Brasa_POO\img\campo.jpg");

                // 2. Aplica a rotação
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // 3. Configura o PictureBox
                img.Image = bmp;
                img.SizeMode = PictureBoxSizeMode.StretchImage;

                // Inverti Width e Height aqui, pois ao girar 90º o que era largura vira altura
                img.Width = 450;
                img.Height = 500;

                this.img.Location = new Point(50, 115);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }


            Control[] elementos = { lblTitulo, lblNom, lblPos, lblTim, lblNum, lblIda, btnGol, btnZag1, btnZag2, img, img2, img3, img4, lblNom2, lblPos2, lblTim2, lblNum2, lblIda2 };
            this.Controls.AddRange(elementos);

            btnGol.BringToFront();
            btnZag1.BringToFront();
            btnZag2.BringToFront();
        }

        private void BtnGol_Click(object sender, EventArgs e)
        {
            jogador1.Nome = "Alisson";
            jogador1.Posicao = "Goleiro";
            jogador1.Numero = 1;
            jogador1.Time = "Liverpool";
            jogador1.Idade = 30;

            lblNom.Text = "Nome: " + jogador1.Nome;
            lblPos.Text = "Posição: " + jogador1.Posicao;
            lblNum.Text = "Número: " + jogador1.Numero;
            lblTim.Text = "Time: " + jogador1.Time;
            lblIda.Text = "Idade: " + jogador1.Idade;

            img2.Image = Image.FromFile(@"C:\Users\danyb\source\repos\Selecao_Brasa_POO\img\alisson.jpg");
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);

            this.img2.Location = new Point(550, 120);
            lblNom.Location = new Point(545, 400);
            lblPos.Location = new Point(545, 430);
            lblNum.Location = new Point(545, 460);
            lblTim.Location = new Point(545, 490);
            lblIda.Location = new Point(545, 520);

            lblNom.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPos.Font = new Font("Arial", 16, FontStyle.Bold);
            lblNum.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTim.Font = new Font("Arial", 16, FontStyle.Bold);
            lblIda.Font = new Font("Arial", 16, FontStyle.Bold);

            lblNom.AutoSize = true;
            lblPos.AutoSize = true;
            lblNum.AutoSize = true;
            lblTim.AutoSize = true;
            lblIda.AutoSize = true;
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
            lblPos.Text = "Posição: " + jogador2.Posicao;
            lblNum.Text = "Número: " + jogador2.Numero;
            lblTim.Text = "Time: " + jogador2.Time;
            lblIda.Text = "Idade: " + jogador2.Idade;

            lblNom2.Text = "Nome: " + jogador3.Nome;
            lblPos2.Text = "Posição: " + jogador3.Posicao;
            lblNum2.Text = "Número: " + jogador3.Numero;
            lblTim2.Text = "Time: " + jogador3.Time;
            lblIda2.Text = "Idade: " + jogador3.Idade;

            img2.Image = Image.FromFile(@"C:\Users\danyb\source\repos\Selecao_Brasa_POO\img\marquinhos.jpg");
            img2.SizeMode = PictureBoxSizeMode.StretchImage;
            img2.Size = new Size(200, 275);
            this.img2.Location = new Point(550, 120);
            img3.Image = Image.FromFile(@"C:\Users\danyb\source\repos\Selecao_Brasa_POO\img\magalhaes.jpg");
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
    }
}

