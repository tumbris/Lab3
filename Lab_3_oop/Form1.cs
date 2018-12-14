using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Lab_3_oop
{
    public partial class Form1 : Form
    {

        private string pathToXml;
        public Form1()
        {
            InitializeComponent();
        }

        public void GetAllStudents(string path)
        {
            pathToXml = path;
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("student");
            foreach (XmlNode n in childnodes)
            {
                string temp = n.SelectSingleNode("@Name").InnerXml;
                if (!cbNames.Items.Contains(temp)) cbNames.Items.Add(temp);
                temp = n.SelectSingleNode("@Surname").InnerXml;
                if (!cbSurnames.Items.Contains(temp)) cbSurnames.Items.Add(temp);
                temp = n.SelectSingleNode("@Pathers").InnerXml;
                if (!cbFathernames.Items.Contains(temp)) cbFathernames.Items.Add(temp);
                temp = n.SelectSingleNode("@Faculty").InnerXml;
                if (!cbFaculty.Items.Contains(temp)) cbFaculty.Items.Add(temp);
                temp = n.SelectSingleNode("@Cathedra").InnerXml;
                if (!cbCathedra.Items.Contains(temp)) cbCathedra.Items.Add(temp);
                temp = n.SelectSingleNode("@Mark").InnerXml;
                if (!cbMarks.Items.Contains(temp)) cbMarks.Items.Add(temp);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        GetAllStudents(ofd.FileName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            Transform();
        }

        private void Transform()
        {
            if (pathToXml == null) return;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "HTML file|*.html";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    XslCompiledTransform xct = new XslCompiledTransform();
                    xct.Load("transform.xsl");
                    string fXml = pathToXml;
                    xct.Transform(fXml, ofd.FileName);
                    MessageBox.Show("Done!");
                }
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            if (nameChB.Checked) stud.Name = cbNames.Text;
            if (surnameChB.Checked) stud.Surname = cbSurnames.Text;
            if (fnameChB.Checked) stud.Pathers = cbFathernames.Text;
            if (facChB.Checked) stud.Faculty = cbFaculty.Text;
            if (cathdrChB.Checked) stud.Cathedra = cbCathedra.Text;
            if (markChB.Checked) stud.Mark = cbMarks.Text;
            List<Student> list;
            Searcher alg;
            if (rbDOM.Checked) alg = new DOMSearch();
            else if (rbLtX.Checked) alg = new LINQSearch();
            else if (rbSAX.Checked) alg = new SAXSearch();
            else return;
            list = Search.GetResult(pathToXml, stud, alg);

            listView.Items.Clear();

            foreach(Student s in list)
            {
                ListViewItem lvi = new ListViewItem(s.Name);
                lvi.SubItems.Add(s.Surname);
                lvi.SubItems.Add(s.Pathers);
                lvi.SubItems.Add(s.Faculty);
                lvi.SubItems.Add(s.Cathedra);
                lvi.SubItems.Add(s.Mark);
                listView.Items.Add(lvi);
            }

            listView.View = View.Details;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure?";
            const string caption = "Exit";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            e.Cancel = result == DialogResult.No;
        }

    }
}
