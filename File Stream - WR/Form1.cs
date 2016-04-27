﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Stream___WR
{
    public partial class FSWR : Form
    {

        //
        private StreamHandler sHandler = new StreamHandler();
        private OpenFileDialog openFD;
        private string lineGet;
        private bool editable = false;
        //
        public FSWR()
        {
            InitializeComponent();
            readBox.ScrollBars = ScrollBars.Vertical;
            readBox.WordWrap = true;
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {
            openFD = new OpenFileDialog();

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    
                    
                        sHandler.reader = new System.IO.StreamReader(openFD.FileName);
                        lineGet = sHandler.reader.ReadToEnd();
                        readBox.Text = lineGet;
                    sHandler.reader.Close();
                    
                   
                    
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arquivo não pode ser aberto, Erro: " + ex.Message);
                }
                finally { readBox.Focus(); }
            }
        }

        private void FSWR_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            readBox.ReadOnly = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //readBox.Enabled = false;
            readBox.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sHandler.writer = new System.IO.StreamWriter(openFD.FileName);
            sHandler.writer.WriteLine(readBox.Text);
            sHandler.writer.Close();
            readBox.ReadOnly = true;
        
        }
    }
}