namespace VisualizeThis
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
      this.btnOpen = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.prop_grid = new System.Windows.Forms.DataGridView();
      this.object_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.fixture_grid = new System.Windows.Forms.DataGridView();
      this.fixture_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fixture_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fixture_num_members = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnMatrix = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtFileName = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.prop_grid)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fixture_grid)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(451, 12);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(75, 23);
      this.btnOpen.TabIndex = 0;
      this.btnOpen.Text = "Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(532, 529);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // prop_grid
      // 
      this.prop_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.prop_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.object_name,
            this.id});
      this.prop_grid.Location = new System.Drawing.Point(6, 6);
      this.prop_grid.Name = "prop_grid";
      this.prop_grid.Size = new System.Drawing.Size(384, 468);
      this.prop_grid.TabIndex = 2;
      // 
      // object_name
      // 
      this.object_name.HeaderText = "Name";
      this.object_name.Name = "object_name";
      // 
      // id
      // 
      this.id.HeaderText = "ID";
      this.id.Name = "id";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 40);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(478, 506);
      this.tabControl1.TabIndex = 3;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.prop_grid);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(470, 480);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Props";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.fixture_grid);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(470, 480);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Fixtures";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // fixture_grid
      // 
      this.fixture_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.fixture_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fixture_name,
            this.fixture_id,
            this.fixture_num_members});
      this.fixture_grid.Location = new System.Drawing.Point(6, 6);
      this.fixture_grid.Name = "fixture_grid";
      this.fixture_grid.Size = new System.Drawing.Size(346, 468);
      this.fixture_grid.TabIndex = 3;
      // 
      // fixture_name
      // 
      this.fixture_name.HeaderText = "Name";
      this.fixture_name.Name = "fixture_name";
      // 
      // fixture_id
      // 
      this.fixture_id.HeaderText = "ID";
      this.fixture_id.Name = "fixture_id";
      // 
      // fixture_num_members
      // 
      this.fixture_num_members.HeaderText = "Members";
      this.fixture_num_members.Name = "fixture_num_members";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnMatrix);
      this.groupBox1.Location = new System.Drawing.Point(496, 62);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(111, 286);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add New Element:";
      // 
      // btnMatrix
      // 
      this.btnMatrix.Location = new System.Drawing.Point(18, 31);
      this.btnMatrix.Name = "btnMatrix";
      this.btnMatrix.Size = new System.Drawing.Size(75, 23);
      this.btnMatrix.TabIndex = 0;
      this.btnMatrix.Text = "Matrix";
      this.btnMatrix.UseVisualStyleBackColor = true;
      this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(532, 12);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "SaveAs";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(12, 14);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(433, 20);
      this.txtFileName.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(619, 564);
      this.Controls.Add(this.txtFileName);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnOpen);
      this.Name = "Form1";
      this.Text = "VisualizeThis";
      ((System.ComponentModel.ISupportInitialize)(this.prop_grid)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.fixture_grid)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.DataGridView prop_grid;
    private System.Windows.Forms.DataGridViewTextBoxColumn object_name;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView fixture_grid;
    private System.Windows.Forms.DataGridViewTextBoxColumn fixture_name;
    private System.Windows.Forms.DataGridViewTextBoxColumn fixture_id;
    private System.Windows.Forms.DataGridViewTextBoxColumn fixture_num_members;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnMatrix;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtFileName;
  }
}

