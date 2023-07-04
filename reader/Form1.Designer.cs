namespace reader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.list1 = new System.Windows.Forms.RichTextBox();
            this.cho = new System.Windows.Forms.Button();
            this.newFile = new System.Windows.Forms.Button();
            this.mic_ca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.Location = new System.Drawing.Point(32, 12);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(259, 371);
            this.list1.TabIndex = 3;
            this.list1.Text = "";
            // 
            // cho
            // 
            this.cho.Location = new System.Drawing.Point(314, 65);
            this.cho.Name = "cho";
            this.cho.Size = new System.Drawing.Size(125, 85);
            this.cho.TabIndex = 7;
            this.cho.Text = "choise_file && extract_name_of_mail";
            this.cho.UseVisualStyleBackColor = true;
            this.cho.Click += new System.EventHandler(this.cho_Click);
            // 
            // newFile
            // 
            this.newFile.Location = new System.Drawing.Point(314, 213);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(106, 30);
            this.newFile.TabIndex = 8;
            this.newFile.Text = "save_to_File";
            this.newFile.UseVisualStyleBackColor = true;
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // mic_ca
            // 
            this.mic_ca.Location = new System.Drawing.Point(325, 277);
            this.mic_ca.Name = "mic_ca";
            this.mic_ca.Size = new System.Drawing.Size(94, 29);
            this.mic_ca.TabIndex = 9;
            this.mic_ca.Text = "mic & cam";
            this.mic_ca.UseVisualStyleBackColor = true;
            this.mic_ca.Click += new System.EventHandler(this.mic_ca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 409);
            this.Controls.Add(this.mic_ca);
            this.Controls.Add(this.newFile);
            this.Controls.Add(this.cho);
            this.Controls.Add(this.list1);
            this.Name = "Form1";
            this.Text = "Extract_Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private RichTextBox list1;
        private Button cho;
        private Button newFile;
        private Button mic_ca;
    }
}