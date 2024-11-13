using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aluno_aprovado_ou_nao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show ("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNome.Focus();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media;
            string nome;
            nome=txtNome.Text;
            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            media = (nota1 + nota2) / 2;

            if (media >= 7) 
            {
                MessageBox.Show("O Aluno: " + nome + ", tem média: " + media + " e está Aprovado(a)", "Resultado");
            }
            
            else if (media >= 5) 
            { 
                MessageBox.Show("O Aluno: " + nome + ", tem média: " + media + " e está de Recuperação", "Resultado");
            }
            else
            {
                MessageBox.Show("O Aluno: " + nome + ", tem média: " + media + " e está Reprovado", "Resultado");
            }
                
            


        }
    }
}
