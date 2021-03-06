﻿using CalceranosInvaders;
using GameTerminal;
using HangmanD_7;
using Pingpong;
using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                popup.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm popup = new MainForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel) 
            {
                popup.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            snakeForm popup = new snakeForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel) 
            {
                popup.Dispose();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loginForm popup = new loginForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                popup.Dispose();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hangman popup = new Hangman();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                popup.Dispose();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tutorial popup = new WindowsFormsApplication2.Tutorial();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                popup.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pongForm popup = new pongForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                popup.Dispose();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            accountForm popup = new accountForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                popup.Dispose();
            }
        }
    }
}
