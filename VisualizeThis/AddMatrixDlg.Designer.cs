namespace VisualizeThis
{
  partial class AddMatrixDlg
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
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.txtRows = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtColumns = new System.Windows.Forms.TextBox();
      this.rdoRGB = new System.Windows.Forms.RadioButton();
      this.rdoSingle = new System.Windows.Forms.RadioButton();
      this.label3 = new System.Windows.Forms.Label();
      this.txtChannelsToAllocate = new System.Windows.Forms.TextBox();
      this.txtTotalChannels = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.matrix_grid = new System.Windows.Forms.DataGridView();
      this.dmx_universe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dmx_start_channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dmx_num_channels = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label5 = new System.Windows.Forms.Label();
      this.txtMatrixName = new System.Windows.Forms.TextBox();
      this.txtXpos = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtYpos = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtSpacing = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnOpen = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.matrix_grid)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(426, 13);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Create";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(426, 42);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // txtRows
      // 
      this.txtRows.Location = new System.Drawing.Point(78, 11);
      this.txtRows.Name = "txtRows";
      this.txtRows.Size = new System.Drawing.Size(55, 20);
      this.txtRows.TabIndex = 2;
      this.txtRows.Text = "8";
      this.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtRows.Validating += new System.ComponentModel.CancelEventHandler(this.txtRows_Validating);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(35, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Rows:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Columns:";
      // 
      // txtColumns
      // 
      this.txtColumns.Location = new System.Drawing.Point(78, 37);
      this.txtColumns.Name = "txtColumns";
      this.txtColumns.Size = new System.Drawing.Size(55, 20);
      this.txtColumns.TabIndex = 4;
      this.txtColumns.Text = "8";
      this.txtColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtColumns.Validating += new System.ComponentModel.CancelEventHandler(this.txtColumns_Validating);
      // 
      // rdoRGB
      // 
      this.rdoRGB.AutoSize = true;
      this.rdoRGB.Checked = true;
      this.rdoRGB.Location = new System.Drawing.Point(156, 13);
      this.rdoRGB.Name = "rdoRGB";
      this.rdoRGB.Size = new System.Drawing.Size(48, 17);
      this.rdoRGB.TabIndex = 6;
      this.rdoRGB.TabStop = true;
      this.rdoRGB.Text = "RGB";
      this.rdoRGB.UseVisualStyleBackColor = true;
      this.rdoRGB.CheckedChanged += new System.EventHandler(this.rdoRGB_CheckedChanged);
      // 
      // rdoSingle
      // 
      this.rdoSingle.AutoSize = true;
      this.rdoSingle.Location = new System.Drawing.Point(156, 36);
      this.rdoSingle.Name = "rdoSingle";
      this.rdoSingle.Size = new System.Drawing.Size(54, 17);
      this.rdoSingle.TabIndex = 7;
      this.rdoSingle.Text = "Single";
      this.rdoSingle.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(222, 14);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Channels to Allocate:";
      // 
      // txtChannelsToAllocate
      // 
      this.txtChannelsToAllocate.Enabled = false;
      this.txtChannelsToAllocate.Location = new System.Drawing.Point(335, 12);
      this.txtChannelsToAllocate.Name = "txtChannelsToAllocate";
      this.txtChannelsToAllocate.Size = new System.Drawing.Size(75, 20);
      this.txtChannelsToAllocate.TabIndex = 9;
      // 
      // txtTotalChannels
      // 
      this.txtTotalChannels.Enabled = false;
      this.txtTotalChannels.Location = new System.Drawing.Point(335, 38);
      this.txtTotalChannels.Name = "txtTotalChannels";
      this.txtTotalChannels.Size = new System.Drawing.Size(75, 20);
      this.txtTotalChannels.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(248, 41);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(81, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Total Channels:";
      // 
      // matrix_grid
      // 
      this.matrix_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.matrix_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dmx_universe,
            this.dmx_start_channel,
            this.dmx_num_channels});
      this.matrix_grid.Location = new System.Drawing.Point(25, 108);
      this.matrix_grid.Name = "matrix_grid";
      this.matrix_grid.Size = new System.Drawing.Size(363, 202);
      this.matrix_grid.TabIndex = 12;
      this.matrix_grid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.matrix_grid_RowValidating);
      // 
      // dmx_universe
      // 
      this.dmx_universe.HeaderText = "Universe";
      this.dmx_universe.Name = "dmx_universe";
      // 
      // dmx_start_channel
      // 
      this.dmx_start_channel.HeaderText = "Start Channel";
      this.dmx_start_channel.Name = "dmx_start_channel";
      // 
      // dmx_num_channels
      // 
      this.dmx_num_channels.HeaderText = "Number of Channels";
      this.dmx_num_channels.Name = "dmx_num_channels";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(34, 77);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "Name:";
      // 
      // txtMatrixName
      // 
      this.txtMatrixName.Location = new System.Drawing.Point(78, 74);
      this.txtMatrixName.Name = "txtMatrixName";
      this.txtMatrixName.Size = new System.Drawing.Size(139, 20);
      this.txtMatrixName.TabIndex = 14;
      this.txtMatrixName.Text = "Matrix";
      // 
      // txtXpos
      // 
      this.txtXpos.Location = new System.Drawing.Point(438, 108);
      this.txtXpos.Name = "txtXpos";
      this.txtXpos.Size = new System.Drawing.Size(63, 20);
      this.txtXpos.TabIndex = 15;
      this.txtXpos.Text = "3473";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(415, 111);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(17, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "X:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(415, 137);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(17, 13);
      this.label7.TabIndex = 18;
      this.label7.Text = "Y:";
      // 
      // txtYpos
      // 
      this.txtYpos.Location = new System.Drawing.Point(438, 134);
      this.txtYpos.Name = "txtYpos";
      this.txtYpos.Size = new System.Drawing.Size(63, 20);
      this.txtYpos.TabIndex = 17;
      this.txtYpos.Text = "2835";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(279, 77);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(49, 13);
      this.label8.TabIndex = 20;
      this.label8.Text = "Spacing:";
      // 
      // txtSpacing
      // 
      this.txtSpacing.Location = new System.Drawing.Point(335, 74);
      this.txtSpacing.Name = "txtSpacing";
      this.txtSpacing.Size = new System.Drawing.Size(55, 20);
      this.txtSpacing.TabIndex = 19;
      this.txtSpacing.Text = "3";
      this.txtSpacing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(426, 287);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 21;
      this.btnSave.Text = "Save As";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(426, 258);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(75, 23);
      this.btnOpen.TabIndex = 22;
      this.btnOpen.Text = "Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // AddMatrixDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(513, 322);
      this.Controls.Add(this.btnOpen);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtSpacing);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtYpos);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtXpos);
      this.Controls.Add(this.txtMatrixName);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.matrix_grid);
      this.Controls.Add(this.txtTotalChannels);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtChannelsToAllocate);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.rdoSingle);
      this.Controls.Add(this.rdoRGB);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtColumns);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtRows);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnAdd);
      this.Name = "AddMatrixDlg";
      this.Text = "Matrix";
      this.Load += new System.EventHandler(this.AddMatrixDlg_Load);
      ((System.ComponentModel.ISupportInitialize)(this.matrix_grid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox txtRows;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtColumns;
    private System.Windows.Forms.RadioButton rdoRGB;
    private System.Windows.Forms.RadioButton rdoSingle;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtChannelsToAllocate;
    private System.Windows.Forms.TextBox txtTotalChannels;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridView matrix_grid;
    private System.Windows.Forms.DataGridViewTextBoxColumn dmx_universe;
    private System.Windows.Forms.DataGridViewTextBoxColumn dmx_start_channel;
    private System.Windows.Forms.DataGridViewTextBoxColumn dmx_num_channels;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtMatrixName;
    private System.Windows.Forms.TextBox txtXpos;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtYpos;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtSpacing;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnOpen;
  }
}