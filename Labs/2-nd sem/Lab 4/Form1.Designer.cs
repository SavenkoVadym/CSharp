namespace Lab_4
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
			this.output_field = new System.Windows.Forms.RichTextBox();
			this.search_file_field = new System.Windows.Forms.TextBox();
			this.search_button = new System.Windows.Forms.Button();
			this.choose_folder_field = new System.Windows.Forms.TextBox();
			this.choose_folder = new System.Windows.Forms.FolderBrowserDialog();
			this.choose_folder_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.files_list = new System.Windows.Forms.ListBox();
			this.open_file_button = new System.Windows.Forms.Button();
			this.file_label = new System.Windows.Forms.Label();
			this.folder_label = new System.Windows.Forms.Label();
			this.files_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// output_field
			// 
			this.output_field.Location = new System.Drawing.Point(12, 52);
			this.output_field.Name = "output_field";
			this.output_field.ReadOnly = true;
			this.output_field.Size = new System.Drawing.Size(973, 327);
			this.output_field.TabIndex = 0;
			this.output_field.Text = "";
			// 
			// search_file_field
			// 
			this.search_file_field.Location = new System.Drawing.Point(12, 26);
			this.search_file_field.Name = "search_file_field";
			this.search_file_field.Size = new System.Drawing.Size(255, 20);
			this.search_file_field.TabIndex = 1;
			this.search_file_field.Text = ".txt";
			this.search_file_field.TextChanged += new System.EventHandler(this.search_file_field_TextChanged);
			// 
			// search_button
			// 
			this.search_button.BackColor = System.Drawing.Color.Lime;
			this.search_button.Location = new System.Drawing.Point(910, 25);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(75, 20);
			this.search_button.TabIndex = 2;
			this.search_button.Text = "Search";
			this.search_button.UseVisualStyleBackColor = false;
			this.search_button.Visible = false;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// choose_folder_field
			// 
			this.choose_folder_field.Location = new System.Drawing.Point(273, 26);
			this.choose_folder_field.Name = "choose_folder_field";
			this.choose_folder_field.ReadOnly = true;
			this.choose_folder_field.Size = new System.Drawing.Size(626, 20);
			this.choose_folder_field.TabIndex = 3;
			this.choose_folder_field.TextChanged += new System.EventHandler(this.choose_folder_field_TextChanged);
			// 
			// choose_folder_button
			// 
			this.choose_folder_button.Location = new System.Drawing.Point(318, 4);
			this.choose_folder_button.Name = "choose_folder_button";
			this.choose_folder_button.Size = new System.Drawing.Size(104, 19);
			this.choose_folder_button.TabIndex = 4;
			this.choose_folder_button.Text = "Choose folder";
			this.choose_folder_button.UseVisualStyleBackColor = true;
			this.choose_folder_button.Click += new System.EventHandler(this.ChooseFolder);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Desktop;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(183, 561);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(610, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Warning! Searching time depends on count of how many folders/files are in root fo" +
	"lder";
			// 
			// files_list
			// 
			this.files_list.Enabled = false;
			this.files_list.FormattingEnabled = true;
			this.files_list.Location = new System.Drawing.Point(12, 398);
			this.files_list.Name = "files_list";
			this.files_list.Size = new System.Drawing.Size(973, 160);
			this.files_list.TabIndex = 7;
			this.files_list.SelectedIndexChanged += new System.EventHandler(this.files_list_SelectedIndexChanged);
			// 
			// open_file_button
			// 
			this.open_file_button.Location = new System.Drawing.Point(12, 564);
			this.open_file_button.Name = "open_file_button";
			this.open_file_button.Size = new System.Drawing.Size(75, 23);
			this.open_file_button.TabIndex = 8;
			this.open_file_button.Text = "Open File";
			this.open_file_button.UseVisualStyleBackColor = true;
			this.open_file_button.Visible = false;
			this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
			// 
			// file_label
			// 
			this.file_label.AutoSize = true;
			this.file_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.file_label.Location = new System.Drawing.Point(9, 10);
			this.file_label.Name = "file_label";
			this.file_label.Size = new System.Drawing.Size(61, 13);
			this.file_label.TabIndex = 9;
			this.file_label.Text = "File name";
			// 
			// folder_label
			// 
			this.folder_label.AutoSize = true;
			this.folder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.folder_label.Location = new System.Drawing.Point(270, 10);
			this.folder_label.Name = "folder_label";
			this.folder_label.Size = new System.Drawing.Size(42, 13);
			this.folder_label.TabIndex = 10;
			this.folder_label.Text = "Folder";
			// 
			// files_label
			// 
			this.files_label.AutoSize = true;
			this.files_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.files_label.Location = new System.Drawing.Point(12, 382);
			this.files_label.Name = "files_label";
			this.files_label.Size = new System.Drawing.Size(33, 13);
			this.files_label.TabIndex = 11;
			this.files_label.Text = "Files";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 590);
			this.Controls.Add(this.files_label);
			this.Controls.Add(this.folder_label);
			this.Controls.Add(this.file_label);
			this.Controls.Add(this.open_file_button);
			this.Controls.Add(this.files_list);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.choose_folder_button);
			this.Controls.Add(this.choose_folder_field);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.search_file_field);
			this.Controls.Add(this.output_field);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox output_field;
		private System.Windows.Forms.TextBox search_file_field;
		private System.Windows.Forms.Button search_button;
		private System.Windows.Forms.TextBox choose_folder_field;
		private System.Windows.Forms.FolderBrowserDialog choose_folder;
		private System.Windows.Forms.Button choose_folder_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox files_list;
		private System.Windows.Forms.Button open_file_button;
		private System.Windows.Forms.Label file_label;
		private System.Windows.Forms.Label folder_label;
		private System.Windows.Forms.Label files_label;
	}
}