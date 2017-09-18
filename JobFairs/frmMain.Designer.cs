namespace JobFairs
{
  partial class frmMain
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
      this.label1 = new System.Windows.Forms.Label();
      this.m_btnAddPeople = new System.Windows.Forms.Button();
      this.m_gbAddData = new System.Windows.Forms.GroupBox();
      this.m_gbAddData.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(509, 37);
      this.label1.TabIndex = 1;
      this.label1.Text = "Dave\'s Amazing Job Fair Manager";
      // 
      // m_btnAddPeople
      // 
      this.m_btnAddPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.m_btnAddPeople.Location = new System.Drawing.Point(21, 39);
      this.m_btnAddPeople.Name = "m_btnAddPeople";
      this.m_btnAddPeople.Size = new System.Drawing.Size(91, 31);
      this.m_btnAddPeople.TabIndex = 2;
      this.m_btnAddPeople.Text = "People";
      this.m_btnAddPeople.UseVisualStyleBackColor = true;
      this.m_btnAddPeople.Click += new System.EventHandler(this.m_btnAddPeople_Click);
      // 
      // m_gbAddData
      // 
      this.m_gbAddData.Controls.Add(this.m_btnAddPeople);
      this.m_gbAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.m_gbAddData.Location = new System.Drawing.Point(20, 91);
      this.m_gbAddData.Name = "m_gbAddData";
      this.m_gbAddData.Size = new System.Drawing.Size(161, 275);
      this.m_gbAddData.TabIndex = 4;
      this.m_gbAddData.TabStop = false;
      this.m_gbAddData.Text = "Add Data";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(766, 483);
      this.Controls.Add(this.m_gbAddData);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Dave\'s Amazing Job Fair Manager";
      this.m_gbAddData.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button m_btnAddPeople;
    private System.Windows.Forms.GroupBox m_gbAddData;
  }
}

