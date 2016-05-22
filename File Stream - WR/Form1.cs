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
        private string hexGet;
        private string binaryGet;
        private bool editable = false;
        //
        public FSWR()
        {
            InitializeComponent();
            readBox.ScrollBars = ScrollBars.Vertical;
            readBox.WordWrap = true;
            typeFile.SelectedIndex = 0;
            
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            openFile();
        }
        /// <summary>
        /// Aqui acontece todo o processo de abrir o arquivo já convertido no formato escolhido
        /// </summary>
        private void openFile()
        {
            openFD = new OpenFileDialog();

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Seria bom fazer um botao de converter oq tem em tela para outro tipo...

                    if (typeFile.SelectedIndex == 0)
                    {
                        readBox.Clear();
                        fileLocal.Clear();
                        readBox.ReadOnly = true;
                        sHandler.fileFS = new System.IO.FileStream(openFD.FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
                        sHandler.bufReader = new System.IO.BufferedStream(sHandler.fileFS);
                        sHandler.reader = new System.IO.StreamReader(sHandler.bufReader);
                        fileLocal.Text = openFD.FileName;
                        lineGet = sHandler.reader.ReadToEnd();
                        readBox.Text = lineGet;
                        sHandler.reader.Close();
                    }
                    else if (typeFile.SelectedIndex == 1) {
                        readBox.Clear();
                        fileLocal.Clear();
                        readBox.ReadOnly = true;
                        sHandler.fileFS = new System.IO.FileStream(openFD.FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
                        sHandler.bufReader = new System.IO.BufferedStream(sHandler.fileFS);
                        sHandler.reader = new System.IO.StreamReader(sHandler.bufReader);
                        fileLocal.Text = openFD.FileName;
                        lineGet = sHandler.reader.ReadToEnd();
                        byte[] converted = Encoding.Default.GetBytes(lineGet);
                        hexGet = BitConverter.ToString(converted);
                        hexGet = hexGet.Replace("-", "");
                        readBox.Text = hexGet;
                        sHandler.reader.Close();
                    }
                    else if (typeFile.SelectedIndex == 2)
                    {
                        readBox.Clear();
                        fileLocal.Clear();
                        readBox.ReadOnly = true;
                        sHandler.fileFS = new System.IO.FileStream(openFD.FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
                        sHandler.bufReader = new System.IO.BufferedStream(sHandler.fileFS);
                        sHandler.reader = new System.IO.StreamReader(sHandler.bufReader);
                        fileLocal.Text = openFD.FileName;
                        lineGet = sHandler.reader.ReadToEnd();
                        sHandler.sb = new StringBuilder();
                        foreach (char s in lineGet.ToCharArray())
                        {
                            sHandler.sb.Append(Convert.ToString(s, 2).PadLeft(8, '0'));
                            
                        }
                        readBox.Text =  sHandler.sb.ToString();
                        
                        sHandler.reader.Close();
                    }
                    else if (typeFile.SelectedIndex == 3)
                    {
                        readBox.Clear();
                        fileLocal.Clear();
                        readBox.ReadOnly = true;
                        sHandler.fileFS = new System.IO.FileStream(openFD.FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
                        sHandler.bufReader = new System.IO.BufferedStream(sHandler.fileFS);
                        sHandler.reader = new System.IO.StreamReader(sHandler.bufReader);
                        fileLocal.Text = openFD.FileName;
                        lineGet = sHandler.reader.ReadToEnd();
                        var myFile = Encoding.UTF8.GetBytes(lineGet);
                        readBox.Text = Convert.ToBase64String(myFile);
                        sHandler.reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nothing.....[error]");
                    }
                    
                    
                   
                    
                        
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
        /// <summary>
        /// Isso deve ser deletado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //readBox.ReadOnly = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (typeFile.SelectedIndex == 0)
            {
                readBox.Text = Convert.ToString(lineGet);
            }
            else if (typeFile.SelectedIndex == 1)
            {
                byte[] converted = Encoding.Default.GetBytes(lineGet);
                hexGet = BitConverter.ToString(converted);
                hexGet = hexGet.Replace("-", "");
                readBox.Text = hexGet;
            }
            else if(typeFile.SelectedIndex == 2)
            {
                sHandler.sb = new StringBuilder();
                foreach (char s in lineGet.ToCharArray())
                {
                    sHandler.sb.Append(Convert.ToString(s, 2).PadLeft(8, '0'));

                }
                readBox.Text = sHandler.sb.ToString();
            }
            else if (typeFile.SelectedIndex == 3)
            {
                var myFile = Encoding.UTF8.GetBytes(lineGet);
                readBox.Text = Convert.ToBase64String(myFile);
            }
            else { }
        }
    }
}
