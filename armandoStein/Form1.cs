using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace armandoStein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            soma = new Contagem();
        }

        private Contagem soma;
        int res;

        private void somar_Click(object sender, EventArgs e)
        {
            if (res < 10)
            {
                soma.setsomarValor(soma.getValor() + 1);
                res = soma.getValor();
                contadorClick.Text = Convert.ToString(res);
            }
            

            switch (res)
            {
                case 7:
                    mensagem.Text = "Faltam apenas mais 3";
                    break;
                case 8:
                    mensagem.Text = "Faltam apenas mais 2";
                    break;
                case 9:
                    mensagem.Text = "Faltam apenas mais 1";
                    break;
                case 10:
                    mensagem.Text = "Acabou!";
                    break;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            res = 0;
            soma = new Contagem();
            contadorClick.Text = "0";
            mensagem.Text = "";
        }

        public class Contagem
        {
            private int valor;

            public Contagem()
            {
                
            }

            public void setsomarValor(int novovalor)
            {
                valor = novovalor;
            }

            public int getValor()
            {
                return valor;
            }
        }
    }
}
