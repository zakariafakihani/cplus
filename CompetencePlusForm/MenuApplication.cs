﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageFilieres;
using CompetencePlus.PackageStagiaires;
using CompetencePlus.PackageGroupes;
using CompetencePlus.PackageFormateurs;

namespace CompetencePlus
{
    public partial class MenuApplication : Form
    {
        public MenuApplication()
        {
            InitializeComponent();
        }

        private void gérerFiliereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionFiliere f = new FormGestionFiliere();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDinformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUneInscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gérerLesInscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerLesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gestionDesGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionGroupes f = new FormGestionGroupes();
            f.Show();
        }

        private void gérerStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionStagiaires f = new FormGestionStagiaires();
            f.Show();
        }

        private void ajouterUneInscriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStagiairesInscription f = new FormStagiairesInscription();
            f.Show();
        }

        private void validationDesInscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStagiairesConfirmerInscription form = new FormStagiairesConfirmerInscription();



        }

        private void suiviToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionFormateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionFormateur f = new FormGestionFormateur();
            f.Show();
        }

        private void ajouterFormateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormateur f = new FormFormateur();
            f.Show();

        }
    }
}
