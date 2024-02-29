using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        private Funcionario func;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func = new Funcionario();

            func.setNome(textBox1.Text);
            func.setEndereco(textBox2.Text);
            func.setSalario(Convert.ToDouble(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                richTextBox1.Text = func.printInformacao1();
            else
                richTextBox1.Text = func.printInformacao2();
        }
    }
    public class Funcionario
    {
        private string nome;
        private string endereco;
        private double salario;

        public Funcionario()
        {
            nome = "";
            endereco = "";
            salario = 0;
        }

        public void setNome(string newnome)
        {
            
            nome = newnome;
        }
        public void setEndereco(string newendereco)
        {
            endereco = newendereco;
        }
        public void setSalario(double newsalario)
        {
            salario = (Convert.ToDouble(newsalario));
        }
        public string printInformacao1()
        {
            return "Nome: "+nome+"\n"+"Endereço: "+endereco+"\n"+"Salário: R$"+salario+"/mês"+"\n"+"Aprovado: True";
        }
        public string printInformacao2()
        {
            return "Nome: " + nome + "\n" + "Endereço: " + endereco + "\n" + "Salário: R$" + salario + "/mês" + "\n" + "Aprovado: False";
        }


    }
}
