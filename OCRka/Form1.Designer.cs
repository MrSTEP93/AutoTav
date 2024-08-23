namespace OCRka
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
            FilePathTextBox = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            TryButton = new Button();
            SelectFileButton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            statusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Location = new Point(12, 27);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.Size = new Size(132, 23);
            FilePathTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "FilePath";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TryButton
            // 
            TryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TryButton.Location = new Point(357, 28);
            TryButton.Name = "TryButton";
            TryButton.Size = new Size(75, 23);
            TryButton.TabIndex = 2;
            TryButton.Text = "Try";
            TryButton.UseVisualStyleBackColor = true;
            TryButton.Click += bTry_Click;
            // 
            // SelectFileButton
            // 
            SelectFileButton.Location = new Point(158, 28);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(75, 23);
            SelectFileButton.TabIndex = 3;
            SelectFileButton.Text = "Select file...";
            SelectFileButton.UseVisualStyleBackColor = true;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 115);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "Изображение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 199);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "Text";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 224);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(416, 166);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel1 });
            statusStrip1.Location = new Point(0, 396);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(444, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new Size(79, 17);
            statusLabel1.Text = "Ready to start";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 418);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(SelectFileButton);
            Controls.Add(TryButton);
            Controls.Add(label1);
            Controls.Add(FilePathTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FilePathTextBox;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button TryButton;
        private Button SelectFileButton;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel1;
    }
}
