using System;
using System.Windows.Forms;


namespace LMV_lab_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            labelEnterMsg.Visible = false;
            buttonShowMsg.Visible = false;
            textBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuHELP_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuFILE_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пункт меню File три команди: Message, Check, Exit. " +
                "Пункт меню Help одну команду About. Вибір команди Message призведе " +
                "відкриття вікна повідомлення. Вибір команди Exit призведе закриття додатку." +
                "Вибір команди Check призведе до прапорця біля цієї команди та зробить команду Message доступною. " +
                "Повторний вибір команди Check призведе зворотних дій. " +
                "Вибір команди About призведе до інформації про ваш додаток. ");
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelEnterMsg.Visible = !labelEnterMsg.Visible;
            buttonShowMsg.Visible = !buttonShowMsg.Visible;
            textBox1.Visible = !textBox1.Visible;
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageToolStripMenuItem.Enabled = !messageToolStripMenuItem.Enabled;
            toolStripMsg.Enabled = !toolStripMsg.Enabled;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMsg_Click(object sender, EventArgs e)
        {
            messageToolStripMenuItem_Click(sender, e);
        }
        private void toolStripCheck_Click(object sender, EventArgs e)
        {
            checkToolStripMenuItem_Click(sender, e);
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void buttonShowMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void labelEnterMsg_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuCut_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
                textBox1.Text = string.Empty;
                MessageBox.Show("Дані успішно скопійовані");
            }
            catch (Exception)
            {
                MessageBox.Show("Відсутні дані для копіювання");
            }
        }

        private void toolStripMenuCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Дані успішно скопійовані");
            }
            catch (Exception)
            {
                MessageBox.Show("Відсутні дані для копіювання");
            }
        }

        private void toolStripMenuPaste_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += Clipboard.GetText();
            }
            catch (Exception)
            {
                MessageBox.Show("Буфер обміну пустий!");
            }
        }
    }
}

