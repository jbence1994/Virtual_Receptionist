﻿using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Alkalmazás bejelentkező ablaka
    /// </summary>
    public partial class FormLogin : Form
    {
        #region Adattagok

        /// <summary>
        /// Bejelentkező ablak prezenter egy példánya
        /// </summary>
        private LoginPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás bejelentkező ablak konstruktora
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        #endregion

        #region UI események

        private void FormLogin_Load(object sender, EventArgs e)
        {
            presenter.SetLogin(textBoxAccomodationID);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            presenter.EnterApplication(textBoxAccomodationID.Text, textBoxPassword.Text);
        }

        private void buttonLogin_KeyUp(object sender, KeyEventArgs e)
        {
            presenter.EnterApplication(e);
        }

        private void textBoxAccomodationID_KeyUp(object sender, KeyEventArgs e)
        {
            presenter.EnterApplication(e);
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            presenter.EnterApplication(e);
        }

        private void comboBoxConnectionType_KeyUp(object sender, KeyEventArgs e)
        {
            presenter.EnterApplication(e);
        }

        #endregion
    }
}
