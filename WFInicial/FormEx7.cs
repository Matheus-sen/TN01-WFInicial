﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx7 : Form
    {
        public string[] NomeProdutos = new string[6];
        public double[] ValoresProdutos = new double[6];

        public FormEx7()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int quantVetor = NomeProdutos.Length; //length mostra o item na posição 1 e não 0
        }
    }
}
