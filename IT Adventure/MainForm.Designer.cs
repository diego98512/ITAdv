namespace IT_Adventure
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.group_Info = new System.Windows.Forms.GroupBox();
            this.group_Input = new System.Windows.Forms.GroupBox();
            this.group_Output = new System.Windows.Forms.GroupBox();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.picture_Output = new System.Windows.Forms.PictureBox();
            this.group_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Info
            // 
            this.group_Info.Location = new System.Drawing.Point(12, 478);
            this.group_Info.Name = "group_Info";
            this.group_Info.Size = new System.Drawing.Size(735, 144);
            this.group_Info.TabIndex = 0;
            this.group_Info.TabStop = false;
            this.group_Info.Text = "Player Info";
            // 
            // group_Input
            // 
            this.group_Input.Location = new System.Drawing.Point(14, 409);
            this.group_Input.Name = "group_Input";
            this.group_Input.Size = new System.Drawing.Size(732, 68);
            this.group_Input.TabIndex = 1;
            this.group_Input.TabStop = false;
            this.group_Input.Text = "Input";
            // 
            // group_Output
            // 
            this.group_Output.Controls.Add(this.picture_Output);
            this.group_Output.Controls.Add(this.rtb_Output);
            this.group_Output.Location = new System.Drawing.Point(12, 2);
            this.group_Output.Name = "group_Output";
            this.group_Output.Size = new System.Drawing.Size(735, 407);
            this.group_Output.TabIndex = 2;
            this.group_Output.TabStop = false;
            this.group_Output.Text = "Output";
            // 
            // rtb_Output
            // 
            this.rtb_Output.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_Output.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtb_Output.Location = new System.Drawing.Point(6, 214);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.ReadOnly = true;
            this.rtb_Output.Size = new System.Drawing.Size(723, 187);
            this.rtb_Output.TabIndex = 1;
            this.rtb_Output.Text = "";
            // 
            // picture_Output
            // 
            this.picture_Output.Location = new System.Drawing.Point(6, 18);
            this.picture_Output.Name = "picture_Output";
            this.picture_Output.Size = new System.Drawing.Size(722, 190);
            this.picture_Output.TabIndex = 1;
            this.picture_Output.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 630);
            this.Controls.Add(this.group_Output);
            this.Controls.Add(this.group_Input);
            this.Controls.Add(this.group_Info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "IT Adventure";
            this.group_Output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Output)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.GroupBox group_Info;
        private System.Windows.Forms.GroupBox group_Input;
        private System.Windows.Forms.GroupBox group_Output;
        private System.Windows.Forms.PictureBox picture_Output;
        private System.Windows.Forms.RichTextBox rtb_Output;
    }
}

