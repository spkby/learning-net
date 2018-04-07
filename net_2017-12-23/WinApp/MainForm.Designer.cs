namespace WinApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLSaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLDOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLSaxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLDOMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSSerializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deSerializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataContractToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptSerializerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butNext = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butPrev = new System.Windows.Forms.Button();
            this.textCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.linqXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLLinqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.butNext);
            this.splitContainer1.Panel2.Controls.Add(this.butDelete);
            this.splitContainer1.Panel2.Controls.Add(this.butEdit);
            this.splitContainer1.Panel2.Controls.Add(this.butAdd);
            this.splitContainer1.Panel2.Controls.Add(this.butPrev);
            this.splitContainer1.Panel2.Controls.Add(this.textCourse);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textGroup);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textAge);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textLastName);
            this.splitContainer1.Panel2.Controls.Add(this.labelLastName);
            this.splitContainer1.Panel2.Controls.Add(this.textFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.labelFirstName);
            this.splitContainer1.Size = new System.Drawing.Size(438, 474);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 24);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(438, 332);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFIleToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.serializeToolStripMenuItem,
            this.deSerializeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFIleToolStripMenuItem
            // 
            this.loadFromFIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.binToolStripMenuItem,
            this.xMLSaxToolStripMenuItem,
            this.xMLDOMToolStripMenuItem,
            this.xMLLinqToolStripMenuItem});
            this.loadFromFIleToolStripMenuItem.Name = "loadFromFIleToolStripMenuItem";
            this.loadFromFIleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFromFIleToolStripMenuItem.Text = "Load From File";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.binToolStripMenuItem.Text = "Bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
            // 
            // xMLSaxToolStripMenuItem
            // 
            this.xMLSaxToolStripMenuItem.Name = "xMLSaxToolStripMenuItem";
            this.xMLSaxToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.xMLSaxToolStripMenuItem.Text = "XML Sax";
            this.xMLSaxToolStripMenuItem.Click += new System.EventHandler(this.xMLSaxToolStripMenuItem_Click);
            // 
            // xMLDOMToolStripMenuItem
            // 
            this.xMLDOMToolStripMenuItem.Name = "xMLDOMToolStripMenuItem";
            this.xMLDOMToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.xMLDOMToolStripMenuItem.Text = "XML DOM";
            this.xMLDOMToolStripMenuItem.Click += new System.EventHandler(this.xMLDOMToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem1,
            this.binToolStripMenuItem1,
            this.xMLSaxToolStripMenuItem1,
            this.xMLDOMToolStripMenuItem1,
            this.linqXMLToolStripMenuItem});
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToFileToolStripMenuItem.Text = "Save To File";
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.textToolStripMenuItem1.Text = "Text";
            this.textToolStripMenuItem1.Click += new System.EventHandler(this.textToolStripMenuItem1_Click);
            // 
            // binToolStripMenuItem1
            // 
            this.binToolStripMenuItem1.Name = "binToolStripMenuItem1";
            this.binToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.binToolStripMenuItem1.Text = "Bin";
            this.binToolStripMenuItem1.Click += new System.EventHandler(this.binToolStripMenuItem1_Click);
            // 
            // xMLSaxToolStripMenuItem1
            // 
            this.xMLSaxToolStripMenuItem1.Name = "xMLSaxToolStripMenuItem1";
            this.xMLSaxToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xMLSaxToolStripMenuItem1.Text = "XML Sax";
            this.xMLSaxToolStripMenuItem1.Click += new System.EventHandler(this.xMLSaxToolStripMenuItem1_Click);
            // 
            // xMLDOMToolStripMenuItem1
            // 
            this.xMLDOMToolStripMenuItem1.Name = "xMLDOMToolStripMenuItem1";
            this.xMLDOMToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xMLDOMToolStripMenuItem1.Text = "XML DOM";
            this.xMLDOMToolStripMenuItem1.Click += new System.EventHandler(this.xMLDOMToolStripMenuItem1_Click);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.dataContractToolStripMenuItem,
            this.jSSerializeToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // dataContractToolStripMenuItem
            // 
            this.dataContractToolStripMenuItem.Name = "dataContractToolStripMenuItem";
            this.dataContractToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.dataContractToolStripMenuItem.Text = "DataContract";
            this.dataContractToolStripMenuItem.Click += new System.EventHandler(this.dataContractToolStripMenuItem_Click);
            // 
            // jSSerializeToolStripMenuItem
            // 
            this.jSSerializeToolStripMenuItem.Name = "jSSerializeToolStripMenuItem";
            this.jSSerializeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.jSSerializeToolStripMenuItem.Text = "JavaScriptSerializer";
            this.jSSerializeToolStripMenuItem.Click += new System.EventHandler(this.jSSerializeToolStripMenuItem_Click);
            // 
            // deSerializeToolStripMenuItem
            // 
            this.deSerializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.dataContractToolStripMenuItem1,
            this.javaScriptSerializerToolStripMenuItem});
            this.deSerializeToolStripMenuItem.Name = "deSerializeToolStripMenuItem";
            this.deSerializeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deSerializeToolStripMenuItem.Text = "Deserialize";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // dataContractToolStripMenuItem1
            // 
            this.dataContractToolStripMenuItem1.Name = "dataContractToolStripMenuItem1";
            this.dataContractToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.dataContractToolStripMenuItem1.Text = "DataContract";
            this.dataContractToolStripMenuItem1.Click += new System.EventHandler(this.dataContractToolStripMenuItem1_Click);
            // 
            // javaScriptSerializerToolStripMenuItem
            // 
            this.javaScriptSerializerToolStripMenuItem.Name = "javaScriptSerializerToolStripMenuItem";
            this.javaScriptSerializerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.javaScriptSerializerToolStripMenuItem.Text = "JavaScriptSerializer";
            this.javaScriptSerializerToolStripMenuItem.Click += new System.EventHandler(this.javaScriptSerializerToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(346, 77);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(75, 23);
            this.butNext.TabIndex = 14;
            this.butNext.Text = "Next";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(262, 77);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 13;
            this.butDelete.Text = "Del";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(181, 77);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 12;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(100, 77);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 11;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butPrev
            // 
            this.butPrev.Location = new System.Drawing.Point(16, 77);
            this.butPrev.Name = "butPrev";
            this.butPrev.Size = new System.Drawing.Size(75, 23);
            this.butPrev.TabIndex = 10;
            this.butPrev.Text = "Prev";
            this.butPrev.UseVisualStyleBackColor = true;
            this.butPrev.Click += new System.EventHandler(this.butPrev_Click);
            // 
            // textCourse
            // 
            this.textCourse.Location = new System.Drawing.Point(383, 31);
            this.textCourse.MaxLength = 1;
            this.textCourse.Name = "textCourse";
            this.textCourse.Size = new System.Drawing.Size(38, 20);
            this.textCourse.TabIndex = 9;
            this.textCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCourse_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Курс";
            // 
            // textGroup
            // 
            this.textGroup.Location = new System.Drawing.Point(287, 31);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(90, 20);
            this.textGroup.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Группа";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(228, 31);
            this.textAge.MaxLength = 3;
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(53, 20);
            this.textAge.TabIndex = 5;
            this.textAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAge_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Возраст";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(122, 31);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(119, 15);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Фамилия";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(16, 31);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(13, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя";
            // 
            // linqXMLToolStripMenuItem
            // 
            this.linqXMLToolStripMenuItem.Name = "linqXMLToolStripMenuItem";
            this.linqXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linqXMLToolStripMenuItem.Text = "Linq XML ";
            this.linqXMLToolStripMenuItem.Click += new System.EventHandler(this.linqXMLToolStripMenuItem_Click);
            // 
            // xMLLinqToolStripMenuItem
            // 
            this.xMLLinqToolStripMenuItem.Name = "xMLLinqToolStripMenuItem";
            this.xMLLinqToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xMLLinqToolStripMenuItem.Text = "XML Linq";
            this.xMLLinqToolStripMenuItem.Click += new System.EventHandler(this.xMLLinqToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 474);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Student Database";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butPrev;
        private System.Windows.Forms.TextBox textCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ToolStripMenuItem loadFromFIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLSaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLSaxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deSerializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataContractToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSSerializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javaScriptSerializerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLDOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLDOMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem linqXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLLinqToolStripMenuItem;
    }
}

