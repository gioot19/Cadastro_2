using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_2
{
    public partial class Frm_cadastro : Form
    {
        public Frm_cadastro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Nome.Text + "  " + Txt_Sobrenome.Text + "\n" + 
                Txt_Idade.Text + "\n" +
                Txt_Bairro.Text + Txt_Celular.Text + "\n"  + Txt_Email.Text;
            //+ Concatenar (Juntar) "\N" Quebra de linha (descer)
        }

        private void Lbl_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Bairro.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Rad_tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.close_up_portrait_woman_holding_pencil;
        }

        private void Rad_Tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.hand_that_plays_smartphone_is_written_with_white_chalk_his_hand_draw_concept;
        }

        private void Rad_Tema3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.girl_is_typing_laptop_keyboard_girls_hands_keyboard;
        }

<<<<<<< HEAD
        private void Btn_Celular_Click(object sender, EventArgs e)
        {

        }

        private void Frm_cadastro_Load(object sender, EventArgs e)
        {

=======
        private void Btn_Nome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Nome.Text;
        }

        private void Btn_Sobrenome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Sobrenome.Text;
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Idade.Text;
        }

        private void Btn_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Bairro.Text;
        }

        private void Btn_Celular_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Celular.Text;
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Email.Text;
>>>>>>> 8af7a049e22362a27e0377c1e55dddfe9f33b982
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = ""; //limpandoa label 
            Txt_Bairro.Clear();
            Txt_Celular.Clear();    
            Txt_Email.Clear();
            Txt_Idade.Clear();
            Txt_Nome.Clear();
            Txt_Sobrenome.Clear();
           
		}

        private void Lbl_Cadastro_Pessoal_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {   
            Btn_Nome.Enabled = true; //ativando o botão nome
            Btn_Sobrenome.Enabled = true; //ativando o botão sobrenome
            Btn_Idade.Enabled = true; //ativando o botão idade
            btn_Email.Enabled = true; //ativando o botão email  
            Btn_Bairro.Enabled = true; //ativando o botão bairro
            Btn_D_Completos.Enabled = true; //ativando o botão dados completos
            Btn_Deastivar.Enabled = true; //ativando o botão desativar
            Btn_Ativar.Enabled = true; //  ativando o botão ativar 
            Btn_Enviar.Enabled = true; //ativando o botão enviar
            Txt_Bairro.Enabled = true; //ativando o textbox bairro
            Txt_Celular.Enabled = true; //ativando o textbox celular
            Txt_Nome.Enabled = true; //ativando o textbox nome
            Txt_Sobrenome.Enabled = true; //ativando o textbox sobrenome
            Txt_Idade.Enabled = true; //ativando o textbox idade
            Txt_Email.Enabled = true; //ativando o textbox email
            Txt_Celular.Enabled = true; //ativando o textbox celular
            Lbl_Nome.Enabled = true; //ativando a label nome
            Lbl_Sobrenome.Enabled = true; //ativando a label sobrenome
            Lbl_Idade.Enabled = true; //ativando a label idade
            Lbl_Bairro.Enabled = true; //ativando a label bairro
            Lbl_Celular.Enabled = true; //ativando a label celular
            Lbl_Email.Enabled = true; //ativando a label email
            Lbl_Cadastro_Pessoal.Enabled = true; //ativando a label cadastro pessoal
            Lbl_Resultado.Enabled = true; //ativando a label resultado
            Lbl_Conf_dados.Enabled = true; //ativando a label confirmação de dados
            Lbl_Bairro.Enabled = true; //ativando a label bairro
        }

        private void Btn_Deastivar_Click(object sender, EventArgs e)
        {
            Btn_Nome.Enabled = false; //desativando o botão nome
            Btn_Sobrenome.Enabled = false; //desativando o botão sobrenome
            Btn_Idade.Enabled = false; //desativando o botão idade
            btn_Email.Enabled = false; //desativando o botão email
            Btn_Bairro.Enabled = false; //desativando o botão bairro
            Btn_D_Completos.Enabled = false; //desativando o botão dados completos
            Btn_Deastivar.Enabled = false; //desativando o botão desativar
            Btn_Ativar.Enabled = false; //desativando o botão ativar
            Btn_Enviar.Enabled = false; //desativando o botão enviar
            Txt_Bairro.Enabled = false; //desativando o textbox bairro
            Txt_Celular.Enabled = false; //desativando o textbox celular
            Txt_Nome.Enabled = false; //desativando o textbox nome
            Txt_Sobrenome.Enabled = false; //desativando o textbox sobrenome
            Txt_Idade.Enabled = false; //desativando o textbox idade
            Txt_Email.Enabled = false; //desativando o textbox email
            Txt_Celular.Enabled = false; //desativando o textbox celular
            Lbl_Nome.Enabled = true; //ativando a label nome
            Lbl_Sobrenome.Enabled = false; //desativando a label sobrenome
            Lbl_Idade.Enabled = false; //desativando a label idade
            Lbl_Bairro.Enabled = false; //desativando a label bairro
            Lbl_Celular.Enabled = false; //desativando a label celular
            Lbl_Email.Enabled = false; //desativando a label email
            Lbl_Cadastro_Pessoal.Enabled = false; //desativando a label cadastro pessoal
            Lbl_Resultado.Enabled = false; //desativando a label resultado
            Lbl_Conf_dados.Enabled = false; //desativando a label confirmação de dados
            Lbl_Bairro.Enabled = false; //desativando a label bairro
        }
    }
}
