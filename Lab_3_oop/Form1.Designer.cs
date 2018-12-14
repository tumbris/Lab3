namespace Lab_3_oop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameChB = new System.Windows.Forms.CheckBox();
            this.surnameChB = new System.Windows.Forms.CheckBox();
            this.fnameChB = new System.Windows.Forms.CheckBox();
            this.facChB = new System.Windows.Forms.CheckBox();
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.cbSurnames = new System.Windows.Forms.ComboBox();
            this.cbFathernames = new System.Windows.Forms.ComboBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.cathdrChB = new System.Windows.Forms.CheckBox();
            this.cbCathedra = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.markChB = new System.Windows.Forms.CheckBox();
            this.cbMarks = new System.Windows.Forms.ComboBox();
            this.rbDOM = new System.Windows.Forms.RadioButton();
            this.rbSAX = new System.Windows.Forms.RadioButton();
            this.rbLtX = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransf = new System.Windows.Forms.ToolStripMenuItem();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fathers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.faculty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cathedra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameChB
            // 
            this.nameChB.AutoSize = true;
            this.nameChB.Location = new System.Drawing.Point(12, 30);
            this.nameChB.Name = "nameChB";
            this.nameChB.Size = new System.Drawing.Size(54, 17);
            this.nameChB.TabIndex = 1;
            this.nameChB.Text = "Name";
            this.nameChB.UseVisualStyleBackColor = true;
            // 
            // surnameChB
            // 
            this.surnameChB.AutoSize = true;
            this.surnameChB.Location = new System.Drawing.Point(12, 57);
            this.surnameChB.Name = "surnameChB";
            this.surnameChB.Size = new System.Drawing.Size(68, 17);
            this.surnameChB.TabIndex = 1;
            this.surnameChB.Text = "Surname";
            this.surnameChB.UseVisualStyleBackColor = true;
            // 
            // fnameChB
            // 
            this.fnameChB.AutoSize = true;
            this.fnameChB.Location = new System.Drawing.Point(12, 84);
            this.fnameChB.Name = "fnameChB";
            this.fnameChB.Size = new System.Drawing.Size(82, 17);
            this.fnameChB.TabIndex = 1;
            this.fnameChB.Text = "Fathername";
            this.fnameChB.UseVisualStyleBackColor = true;
            // 
            // facChB
            // 
            this.facChB.AutoSize = true;
            this.facChB.Location = new System.Drawing.Point(12, 111);
            this.facChB.Name = "facChB";
            this.facChB.Size = new System.Drawing.Size(60, 17);
            this.facChB.TabIndex = 1;
            this.facChB.Text = "Faculty";
            this.facChB.UseVisualStyleBackColor = true;
            // 
            // cbNames
            // 
            this.cbNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(114, 28);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(200, 21);
            this.cbNames.TabIndex = 2;
            // 
            // cbSurnames
            // 
            this.cbSurnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSurnames.FormattingEnabled = true;
            this.cbSurnames.Location = new System.Drawing.Point(114, 55);
            this.cbSurnames.Name = "cbSurnames";
            this.cbSurnames.Size = new System.Drawing.Size(200, 21);
            this.cbSurnames.TabIndex = 2;
            // 
            // cbFathernames
            // 
            this.cbFathernames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFathernames.FormattingEnabled = true;
            this.cbFathernames.Location = new System.Drawing.Point(114, 82);
            this.cbFathernames.Name = "cbFathernames";
            this.cbFathernames.Size = new System.Drawing.Size(200, 21);
            this.cbFathernames.TabIndex = 2;
            // 
            // cbFaculty
            // 
            this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Location = new System.Drawing.Point(114, 109);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(200, 21);
            this.cbFaculty.TabIndex = 2;
            // 
            // cathdrChB
            // 
            this.cathdrChB.AutoSize = true;
            this.cathdrChB.Location = new System.Drawing.Point(12, 138);
            this.cathdrChB.Name = "cathdrChB";
            this.cathdrChB.Size = new System.Drawing.Size(69, 17);
            this.cathdrChB.TabIndex = 1;
            this.cathdrChB.Text = "Cathedra";
            this.cathdrChB.UseVisualStyleBackColor = true;
            // 
            // cbCathedra
            // 
            this.cbCathedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCathedra.FormattingEnabled = true;
            this.cbCathedra.Location = new System.Drawing.Point(114, 136);
            this.cbCathedra.Name = "cbCathedra";
            this.cbCathedra.Size = new System.Drawing.Size(200, 21);
            this.cbCathedra.TabIndex = 2;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.surname,
            this.name,
            this.fathers,
            this.faculty,
            this.cathedra,
            this.mark});
            this.listView.Location = new System.Drawing.Point(320, 28);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(468, 343);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // markChB
            // 
            this.markChB.AutoSize = true;
            this.markChB.Location = new System.Drawing.Point(12, 165);
            this.markChB.Name = "markChB";
            this.markChB.Size = new System.Drawing.Size(50, 17);
            this.markChB.TabIndex = 1;
            this.markChB.Text = "Mark";
            this.markChB.UseVisualStyleBackColor = true;
            // 
            // cbMarks
            // 
            this.cbMarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarks.FormattingEnabled = true;
            this.cbMarks.Location = new System.Drawing.Point(114, 163);
            this.cbMarks.Name = "cbMarks";
            this.cbMarks.Size = new System.Drawing.Size(200, 21);
            this.cbMarks.TabIndex = 2;
            // 
            // rbDOM
            // 
            this.rbDOM.AutoSize = true;
            this.rbDOM.Location = new System.Drawing.Point(12, 308);
            this.rbDOM.Name = "rbDOM";
            this.rbDOM.Size = new System.Drawing.Size(50, 17);
            this.rbDOM.TabIndex = 4;
            this.rbDOM.TabStop = true;
            this.rbDOM.Text = "DOM";
            this.rbDOM.UseVisualStyleBackColor = true;
            // 
            // rbSAX
            // 
            this.rbSAX.AutoSize = true;
            this.rbSAX.Location = new System.Drawing.Point(12, 331);
            this.rbSAX.Name = "rbSAX";
            this.rbSAX.Size = new System.Drawing.Size(46, 17);
            this.rbSAX.TabIndex = 4;
            this.rbSAX.TabStop = true;
            this.rbSAX.Text = "SAX";
            this.rbSAX.UseVisualStyleBackColor = true;
            // 
            // rbLtX
            // 
            this.rbLtX.AutoSize = true;
            this.rbLtX.Location = new System.Drawing.Point(12, 354);
            this.rbLtX.Name = "rbLtX";
            this.rbLtX.Size = new System.Drawing.Size(87, 17);
            this.rbLtX.TabIndex = 4;
            this.rbLtX.TabStop = true;
            this.rbLtX.Text = "LINQ to XML";
            this.rbLtX.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 377);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(320, 377);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(75, 23);
            this.btnTransform.TabIndex = 6;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(401, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileDropDown
            // 
            this.fileDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnTransf});
            this.fileDropDown.Image = ((System.Drawing.Image)(resources.GetObject("fileDropDown.Image")));
            this.fileDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileDropDown.Name = "fileDropDown";
            this.fileDropDown.Size = new System.Drawing.Size(38, 22);
            this.fileDropDown.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(180, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnTransf
            // 
            this.btnTransf.Name = "btnTransf";
            this.btnTransf.Size = new System.Drawing.Size(180, 22);
            this.btnTransf.Text = "Transform";
            this.btnTransf.DoubleClick += new System.EventHandler(this.btnTransform_Click);
            // 
            // name
            // 
            this.name.DisplayIndex = 0;
            this.name.Text = "Name";
            this.name.Width = 84;
            // 
            // surname
            // 
            this.surname.DisplayIndex = 1;
            this.surname.Text = "Surname";
            this.surname.Width = 81;
            // 
            // fathers
            // 
            this.fathers.Text = "Fathers";
            this.fathers.Width = 94;
            // 
            // faculty
            // 
            this.faculty.Text = "Faculty";
            this.faculty.Width = 98;
            // 
            // cathedra
            // 
            this.cathedra.Text = "Cathedra";
            // 
            // mark
            // 
            this.mark.Text = "Mark";
            this.mark.Width = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbLtX);
            this.Controls.Add(this.rbSAX);
            this.Controls.Add(this.rbDOM);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.cbMarks);
            this.Controls.Add(this.cbCathedra);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.markChB);
            this.Controls.Add(this.cbFathernames);
            this.Controls.Add(this.cbSurnames);
            this.Controls.Add(this.cathdrChB);
            this.Controls.Add(this.cbNames);
            this.Controls.Add(this.facChB);
            this.Controls.Add(this.fnameChB);
            this.Controls.Add(this.surnameChB);
            this.Controls.Add(this.nameChB);
            this.Name = "Form1";
            this.Text = "Herashchenko Serhii, K-26";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox nameChB;
        private System.Windows.Forms.CheckBox surnameChB;
        private System.Windows.Forms.CheckBox fnameChB;
        private System.Windows.Forms.CheckBox facChB;
        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.ComboBox cbSurnames;
        private System.Windows.Forms.ComboBox cbFathernames;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.CheckBox cathdrChB;
        private System.Windows.Forms.ComboBox cbCathedra;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.CheckBox markChB;
        private System.Windows.Forms.ComboBox cbMarks;
        private System.Windows.Forms.RadioButton rbDOM;
        private System.Windows.Forms.RadioButton rbSAX;
        private System.Windows.Forms.RadioButton rbLtX;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnTransf;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader fathers;
        private System.Windows.Forms.ColumnHeader faculty;
        private System.Windows.Forms.ColumnHeader cathedra;
        private System.Windows.Forms.ColumnHeader mark;
    }
}

