namespace TaskManager
{
    partial class mainPage
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
            taskManagerLabel = new Label();
            newTaskButton = new Button();
            panel1 = new Panel();
            taskTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label1 = new Label();
            taskList = new ListView();
            task = new ColumnHeader();
            description = new ColumnHeader();
            deleteButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // taskManagerLabel
            // 
            taskManagerLabel.AccessibleRole = AccessibleRole.SplitButton;
            taskManagerLabel.AutoSize = true;
            taskManagerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            taskManagerLabel.ForeColor = Color.DarkBlue;
            taskManagerLabel.Location = new Point(0, 0);
            taskManagerLabel.Name = "taskManagerLabel";
            taskManagerLabel.Size = new Size(195, 37);
            taskManagerLabel.TabIndex = 0;
            taskManagerLabel.Text = "Task Manager";
            // 
            // newTaskButton
            // 
            newTaskButton.BackColor = Color.DimGray;
            newTaskButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newTaskButton.Location = new Point(650, 12);
            newTaskButton.Name = "newTaskButton";
            newTaskButton.Size = new Size(130, 48);
            newTaskButton.TabIndex = 3;
            newTaskButton.Text = "New Task";
            newTaskButton.UseVisualStyleBackColor = false;
            newTaskButton.Click += newTaskButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(taskTextBox);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(taskManagerLabel);
            panel1.Controls.Add(newTaskButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 81);
            panel1.TabIndex = 2;
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(204, 26);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.PlaceholderText = "Task";
            taskTextBox.Size = new Size(109, 34);
            taskTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(319, 26);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Description";
            descriptionTextBox.Size = new Size(325, 34);
            descriptionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(353, 107);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 3;
            label1.Text = "Task List";
            // 
            // taskList
            // 
            taskList.BackColor = SystemColors.ActiveCaption;
            taskList.Columns.AddRange(new ColumnHeader[] { task, description });
            taskList.FullRowSelect = true;
            taskList.GridLines = true;
            taskList.Location = new Point(92, 153);
            taskList.Name = "taskList";
            taskList.Size = new Size(630, 269);
            taskList.TabIndex = 0;
            taskList.TabStop = false;
            taskList.UseCompatibleStateImageBehavior = false;
            taskList.View = View.Details;
            // 
            // task
            // 
            task.Text = "Task";
            task.Width = 250;
            // 
            // description
            // 
            description.Text = "Description";
            description.Width = 380;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DimGray;
            deleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(730, 428);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 28);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(817, 468);
            Controls.Add(deleteButton);
            Controls.Add(taskList);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 15F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5, 6, 5, 6);
            Name = "mainPage";
            Text = "Task Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskManagerLabel;
        private Button newTaskButton;
        private Panel panel1;
        private Label label1;
        private ListView taskList;
        private ColumnHeader task;
        private ColumnHeader description;
        private TextBox descriptionTextBox;
        private TextBox taskTextBox;
        private Button deleteButton;
    }
}
