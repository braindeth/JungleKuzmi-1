namespace ToDo_Lista_Kuzmić
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
            this.TodoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InprogressBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DoneListBox = new System.Windows.Forms.ListBox();
            this.startedGumb = new System.Windows.Forms.Button();
            this.doneGumb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.descbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dodajGumb = new System.Windows.Forms.Button();
            this.obrisiGumb = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TodoListBox
            // 
            this.TodoListBox.FormattingEnabled = true;
            this.TodoListBox.Location = new System.Drawing.Point(12, 52);
            this.TodoListBox.Name = "TodoListBox";
            this.TodoListBox.Size = new System.Drawing.Size(162, 160);
            this.TodoListBox.TabIndex = 0;
            this.TodoListBox.SelectedIndexChanged += new System.EventHandler(this.TodoListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "In progess";
            // 
            // InprogressBox
            // 
            this.InprogressBox.FormattingEnabled = true;
            this.InprogressBox.Location = new System.Drawing.Point(264, 52);
            this.InprogressBox.Name = "InprogressBox";
            this.InprogressBox.Size = new System.Drawing.Size(162, 160);
            this.InprogressBox.TabIndex = 2;
            this.InprogressBox.SelectedIndexChanged += new System.EventHandler(this.InprogressBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Done";
            // 
            // DoneListBox
            // 
            this.DoneListBox.FormattingEnabled = true;
            this.DoneListBox.Location = new System.Drawing.Point(517, 52);
            this.DoneListBox.Name = "DoneListBox";
            this.DoneListBox.Size = new System.Drawing.Size(162, 160);
            this.DoneListBox.TabIndex = 4;
            this.DoneListBox.SelectedIndexChanged += new System.EventHandler(this.DoneListBox_SelectedIndexChanged);
            // 
            // startedGumb
            // 
            this.startedGumb.Location = new System.Drawing.Point(180, 109);
            this.startedGumb.Name = "startedGumb";
            this.startedGumb.Size = new System.Drawing.Size(78, 59);
            this.startedGumb.TabIndex = 6;
            this.startedGumb.Text = "In progress>>";
            this.startedGumb.UseVisualStyleBackColor = true;
            this.startedGumb.Click += new System.EventHandler(this.startedGumb_Click);
            // 
            // doneGumb
            // 
            this.doneGumb.Location = new System.Drawing.Point(433, 109);
            this.doneGumb.Name = "doneGumb";
            this.doneGumb.Size = new System.Drawing.Size(78, 59);
            this.doneGumb.TabIndex = 7;
            this.doneGumb.Text = "Done>>";
            this.doneGumb.UseVisualStyleBackColor = true;
            this.doneGumb.Click += new System.EventHandler(this.doneGumb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obrisiGumb);
            this.groupBox1.Controls.Add(this.dodajGumb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descbox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.namebox);
            this.groupBox1.Location = new System.Drawing.Point(16, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task details";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(124, 19);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(145, 20);
            this.namebox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(126, 91);
            this.descbox.Multiline = true;
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(264, 66);
            this.descbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Task name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // dodajGumb
            // 
            this.dodajGumb.Location = new System.Drawing.Point(492, 48);
            this.dodajGumb.Name = "dodajGumb";
            this.dodajGumb.Size = new System.Drawing.Size(148, 38);
            this.dodajGumb.TabIndex = 6;
            this.dodajGumb.Text = "Add";
            this.dodajGumb.UseVisualStyleBackColor = true;
            this.dodajGumb.Click += new System.EventHandler(this.dodajGumb_Click);
            // 
            // obrisiGumb
            // 
            this.obrisiGumb.Location = new System.Drawing.Point(492, 108);
            this.obrisiGumb.Name = "obrisiGumb";
            this.obrisiGumb.Size = new System.Drawing.Size(148, 38);
            this.obrisiGumb.TabIndex = 7;
            this.obrisiGumb.Text = "Delete";
            this.obrisiGumb.UseVisualStyleBackColor = true;
            this.obrisiGumb.Click += new System.EventHandler(this.obrisiGumb_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Press F1 for help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doneGumb);
            this.Controls.Add(this.startedGumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoneListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InprogressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TodoListBox);
            this.Name = "Form1";
            this.Text = "ToDo ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TodoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox InprogressBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DoneListBox;
        private System.Windows.Forms.Button startedGumb;
        private System.Windows.Forms.Button doneGumb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button obrisiGumb;
        private System.Windows.Forms.Button dodajGumb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label7;
    }
}

