using System.IO;
using System.Drawing.Printing;
namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file...";
            if (saveFile.ShowDialog() == DialogResult.OK) {
                StreamWriter txt = new StreamWriter(saveFile.FileName);
                txt.Write(richTextBox1.Text);
                txt.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open a file...";
            if (openFile.ShowDialog() == DialogResult.OK) {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(openFile.FileName)) {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pD = new PrintDocument();
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == DialogResult.OK) {
                pD.Print();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pD = new PrintDocument();
            PrintPreviewDialog p = new PrintPreviewDialog();
            p.Document = pD;
            if (p.ShowDialog() == DialogResult.OK) { 
                pD.Print();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font(form2.Font(), form2.size());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
//17/07/2022 4hrs 53mins