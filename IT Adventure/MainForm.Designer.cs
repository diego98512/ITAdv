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
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.group_Output = new System.Windows.Forms.GroupBox();
            this.picture_Output = new System.Windows.Forms.PictureBox();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.labelSanity = new System.Windows.Forms.Label();
            this.lbl_Sanity = new System.Windows.Forms.Label();
            this.group_Info.SuspendLayout();
            this.group_Input.SuspendLayout();
            this.group_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Output)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_Info
            // 
            this.group_Info.Controls.Add(this.tableLayoutPanel1);
            this.group_Info.Location = new System.Drawing.Point(12, 478);
            this.group_Info.Name = "group_Info";
            this.group_Info.Size = new System.Drawing.Size(735, 144);
            this.group_Info.TabIndex = 0;
            this.group_Info.TabStop = false;
            this.group_Info.Text = "Player Info";
            // 
            // group_Input
            // 
            this.group_Input.Controls.Add(this.btn_Send);
            this.group_Input.Controls.Add(this.txt_Input);
            this.group_Input.Location = new System.Drawing.Point(14, 409);
            this.group_Input.Name = "group_Input";
            this.group_Input.Size = new System.Drawing.Size(732, 68);
            this.group_Input.TabIndex = 1;
            this.group_Input.TabStop = false;
            this.group_Input.Text = "Input";
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Send.BackgroundImage = global::IT_Adventure.Properties.Resources.Right_Arrow1;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.Location = new System.Drawing.Point(599, 18);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(126, 38);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.UseVisualStyleBackColor = false;
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(14, 28);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(579, 20);
            this.txt_Input.TabIndex = 0;
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
            // picture_Output
            // 
            this.picture_Output.Location = new System.Drawing.Point(6, 18);
            this.picture_Output.Name = "picture_Output";
            this.picture_Output.Size = new System.Drawing.Size(722, 190);
            this.picture_Output.TabIndex = 1;
            this.picture_Output.TabStop = false;
            // 
            // rtb_Output
            // 
            this.rtb_Output.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_Output.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtb_Output.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Output.Location = new System.Drawing.Point(6, 214);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.ReadOnly = true;
            this.rtb_Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_Output.Size = new System.Drawing.Size(723, 187);
            this.rtb_Output.TabIndex = 1;
            this.rtb_Output.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.82562F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.17438F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Sanity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSanity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Location, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLocation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 40);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Name.Location = new System.Drawing.Point(107, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(253, 40);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLocation.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLocation.Location = new System.Drawing.Point(3, 40);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(98, 40);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location:";
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Location.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Location.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Location.Location = new System.Drawing.Point(107, 40);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(253, 40);
            this.lbl_Location.TabIndex = 3;
            this.lbl_Location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSanity
            // 
            this.labelSanity.AutoSize = true;
            this.labelSanity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSanity.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSanity.Location = new System.Drawing.Point(3, 80);
            this.labelSanity.Name = "labelSanity";
            this.labelSanity.Size = new System.Drawing.Size(98, 43);
            this.labelSanity.TabIndex = 4;
            this.labelSanity.Text = "Sanity:";
            this.labelSanity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Sanity
            // 
            this.lbl_Sanity.AutoSize = true;
            this.lbl_Sanity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sanity.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sanity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Sanity.Location = new System.Drawing.Point(107, 80);
            this.lbl_Sanity.Name = "lbl_Sanity";
            this.lbl_Sanity.Size = new System.Drawing.Size(253, 43);
            this.lbl_Sanity.TabIndex = 5;
            this.lbl_Sanity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.group_Info.ResumeLayout(false);
            this.group_Input.ResumeLayout(false);
            this.group_Input.PerformLayout();
            this.group_Output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Output)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.GroupBox group_Info;
        private System.Windows.Forms.GroupBox group_Input;
        private System.Windows.Forms.GroupBox group_Output;
        private System.Windows.Forms.PictureBox picture_Output;
        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lbl_Sanity;
        private System.Windows.Forms.Label labelSanity;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label lbl_Name;
    }
}

