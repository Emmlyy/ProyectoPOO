﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPOO
{
    public partial class Form1 : Form
    {
        private UserControl change;
        private Jugar jg = new Jugar();
        private Puntaje pun = new Puntaje();
        public Form1()
        {
            InitializeComponent();
            jg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jg.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            tableLayoutPanel1.Controls.Remove(change);
            tableLayoutPanel1.Controls.Add(jg, 0, 0);
            change = jg;
            tableLayoutPanel1.SetRowSpan(change,6);
            tableLayoutPanel1.SetColumnSpan(change, 3);   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?",
                "Consulta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}