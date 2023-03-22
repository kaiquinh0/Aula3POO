﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3POO
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela; //declaração do form
        private void btnCliente_Click(object sender, EventArgs e)
        {
            tela = new TelaCliente //instanciação da tela
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();
        }
    }
}
