namespace PersonNameLocation
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPersonName = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvLocation = new System.Windows.Forms.DataGridView();
			this.btnAssociate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Person Name:";
			// 
			// dgvPersonName
			// 
			this.dgvPersonName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPersonName.Location = new System.Drawing.Point(16, 30);
			this.dgvPersonName.Name = "dgvPersonName";
			this.dgvPersonName.Size = new System.Drawing.Size(295, 150);
			this.dgvPersonName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Location:";
			// 
			// dgvLocation
			// 
			this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLocation.Location = new System.Drawing.Point(16, 219);
			this.dgvLocation.Name = "dgvLocation";
			this.dgvLocation.Size = new System.Drawing.Size(295, 150);
			this.dgvLocation.TabIndex = 3;
			// 
			// btnAssociate
			// 
			this.btnAssociate.Location = new System.Drawing.Point(327, 183);
			this.btnAssociate.Name = "btnAssociate";
			this.btnAssociate.Size = new System.Drawing.Size(75, 23);
			this.btnAssociate.TabIndex = 4;
			this.btnAssociate.Text = "Associate";
			this.btnAssociate.UseVisualStyleBackColor = true;
			this.btnAssociate.Click += new System.EventHandler(this.btnAssociate_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(327, 30);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 380);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnAssociate);
			this.Controls.Add(this.dgvLocation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvPersonName);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPersonName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvPersonName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvLocation;
		private System.Windows.Forms.Button btnAssociate;
		private System.Windows.Forms.Button btnSave;
	}
}

