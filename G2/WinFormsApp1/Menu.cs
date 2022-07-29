﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void picturecliente_Click(object sender, EventArgs e)
        {
            Paciente pa = new Paciente();
            pa.Show();
            this.Hide();
        }

        private void picturecliente_MouseHover(object sender, EventArgs e)
        {
            picturecliente.BackColor = Color.FromArgb(255, 255, 255);
            lbcliente.BackColor = Color.FromArgb(255, 255, 255);
            lbcliente.ForeColor = Color.FromArgb(49, 101, 244);
            picturecliente.Size = new System.Drawing.Size(139, 119);
            lbcliente.Location = new Point(111, 205);

        }

        private void picturecliente_MouseLeave(object sender, EventArgs e)
        {
            picturecliente.BackColor = Color.FromArgb(49, 101, 244);
            lbcliente.ForeColor = Color.FromArgb(255, 255, 255);
            lbcliente.BackColor = Color.FromArgb(49, 101, 244);
            picturecliente.Size = new System.Drawing.Size(129, 109);
            lbcliente.Location = new Point(105, 196);
        }

        private void lbtrabajador_MouseHover(object sender, EventArgs e)
        {
            picturetrabajador.BackColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.BackColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.ForeColor = Color.FromArgb(49, 101, 244);
            picturetrabajador.Size = new System.Drawing.Size(139, 119);
            lbtrabajador.Location = new Point(375, 205);
        }

        private void lbtrabajador_MouseLeave(object sender, EventArgs e)
        {
            picturetrabajador.BackColor = Color.FromArgb(49, 101, 244);
            lbtrabajador.ForeColor = Color.FromArgb(255, 255, 255);
            lbtrabajador.BackColor = Color.FromArgb(49, 101, 244);
            picturetrabajador.Size = new System.Drawing.Size(129, 109);
            lbtrabajador.Location = new Point(368, 196);
        }

        private void lblaboratorio_MouseHover(object sender, EventArgs e)
        {
            picturelaboratorio.BackColor = Color.FromArgb(255, 255, 255);
            lblaboratorio.BackColor = Color.FromArgb(255, 255, 255);
            lblaboratorio.ForeColor = Color.FromArgb(49, 101, 244);
            picturelaboratorio.Size = new System.Drawing.Size(139, 119);
            lblaboratorio.Location = new Point(649, 205);
        }

        private void picturelaboratorio_MouseLeave(object sender, EventArgs e)
        {
            picturelaboratorio.BackColor = Color.FromArgb(49, 101, 244);
            lblaboratorio.ForeColor = Color.FromArgb(255, 255, 255);
            lblaboratorio.BackColor = Color.FromArgb(49, 101, 244);
            picturelaboratorio.Size = new System.Drawing.Size(129, 109);
            lblaboratorio.Location = new Point(643, 196);
        }

        private void picturecita_MouseHover(object sender, EventArgs e)
        {
            picturecita.BackColor = Color.FromArgb(255, 255, 255);
            lbcita.BackColor = Color.FromArgb(255, 255, 255);
            lbcita.ForeColor = Color.FromArgb(49, 101, 244);
            picturecita.Size = new System.Drawing.Size(139, 119);
            lbcita.Location = new Point(129, 412);
        }

        private void picturecita_MouseLeave(object sender, EventArgs e)
        {
            picturecita.BackColor = Color.FromArgb(49, 101, 244);
            lbcita.ForeColor = Color.FromArgb(255, 255, 255);
            lbcita.BackColor = Color.FromArgb(49, 101, 244);
            picturecita.Size = new System.Drawing.Size(129, 109);
            lbcita.Location = new Point(120, 401);
        }

        private void picturedoctor_MouseHover(object sender, EventArgs e)
        {
            picturedoctor.BackColor = Color.FromArgb(255, 255, 255);
            lbdoctor.BackColor = Color.FromArgb(255, 255, 255);
            lbdoctor.ForeColor = Color.FromArgb(49, 101, 244);
            picturedoctor.Size = new System.Drawing.Size(139, 119);
            lbdoctor.Location = new Point(392, 412);
        }

        private void picturedoctor_MouseLeave(object sender, EventArgs e)
        {
            picturedoctor.BackColor = Color.FromArgb(49, 101, 244);
            lbdoctor.ForeColor = Color.FromArgb(255, 255, 255);
            lbdoctor.BackColor = Color.FromArgb(49, 101, 244);
            picturedoctor.Size = new System.Drawing.Size(129, 109);
            lbdoctor.Location = new Point(386, 401);
        }
    }
}
