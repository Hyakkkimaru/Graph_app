namespace GraphApp
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
            this.VertexTextBox = new System.Windows.Forms.TextBox();
            this.AddVertexButton = new System.Windows.Forms.Button();
            this.StartVertexTextBox = new System.Windows.Forms.TextBox();
            this.EndVertexTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VertexTextBox
            // 
            this.VertexTextBox.Location = new System.Drawing.Point(12, 12);
            this.VertexTextBox.Name = "VertexTextBox";
            this.VertexTextBox.Size = new System.Drawing.Size(100, 20);
            this.VertexTextBox.TabIndex = 0;
            // 
            // AddVertexButton
            // 
            this.AddVertexButton.Location = new System.Drawing.Point(118, 12);
            this.AddVertexButton.Name = "AddVertexButton";
            this.AddVertexButton.Size = new System.Drawing.Size(75, 23);
            this.AddVertexButton.TabIndex = 1;
            this.AddVertexButton.Text = "Add Vertex";
            this.AddVertexButton.UseVisualStyleBackColor = true;
            this.AddVertexButton.Click += new System.EventHandler(this.AddVertexButton_Click);
            // 
            // StartVertexTextBox
            // 
            this.StartVertexTextBox.Location = new System.Drawing.Point(12, 38);
            this.StartVertexTextBox.Name = "StartVertexTextBox";
            this.StartVertexTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartVertexTextBox.TabIndex = 2;
            // 
            // EndVertexTextBox
            // 
            this.EndVertexTextBox.Location = new System.Drawing.Point(118, 38);
            this.EndVertexTextBox.Name = "EndVertexTextBox";
            this.EndVertexTextBox.Size = new System.Drawing.Size(100, 20);
            this.EndVertexTextBox.TabIndex = 3;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(224, 38);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.WeightTextBox.TabIndex = 4;
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Location = new System.Drawing.Point(330, 38);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(75, 23);
            this.AddEdgeButton.TabIndex = 5;
            this.AddEdgeButton.Text = "Add Edge";
            this.AddEdgeButton.UseVisualStyleBackColor = true;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.AddEdgeButton);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.EndVertexTextBox);
            this.Controls.Add(this.StartVertexTextBox);
            this.Controls.Add(this.AddVertexButton);
            this.Controls.Add(this.VertexTextBox);
            this.Name = "MainForm";
            this.Text = "Graph App";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VertexTextBox;
        private System.Windows.Forms.Button AddVertexButton;
        private System.Windows.Forms.TextBox StartVertexTextBox;
        private System.Windows.Forms.TextBox EndVertexTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button AddEdgeButton;
    }
}