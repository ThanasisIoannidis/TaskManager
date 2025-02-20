namespace TaskManager
{
    public partial class mainPage : Form
    {
        private void LoadTasksIntoListView()
        {
            taskList.Items.Clear(); // Clear existing items

            List<Tuple<string, string>> tasks = dbHelper.GetAllTasks();

            foreach (var task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Item1);
                item.SubItems.Add(task.Item2);
                taskList.Items.Add(item);
            }
        }


        private DatabaseHelper dbHelper;


        public mainPage()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();  // This ensures the database is created
            LoadTasksIntoListView(); // 🔹 Now call the method to populate the list
        }


        private void newTaskButton_Click(object sender, EventArgs e)
        {

            if (taskTextBox.Text == "" || descriptionTextBox.Text == "")
            {
                { MessageBox.Show("Please enter a task and description"); return; }
            }
            else
            {
                var item = new ListViewItem(taskTextBox.Text);
                item.SubItems.Add(descriptionTextBox.Text);
                taskList.Items.Add(item);
                dbHelper.InsertTaskIntoDatabase(taskTextBox.Text, descriptionTextBox.Text); // Add the task and description to the database
                taskTextBox.Clear();
                descriptionTextBox.Clear();
                
            }
            
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
            {
                dbHelper.DeleteTaskFromDatabase(taskList.SelectedItems[0].Text);
                taskList.Items.Remove(taskList.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select a task to delete");
            }
                
        }
    }
}
