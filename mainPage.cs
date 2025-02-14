namespace TaskManager
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
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
                taskTextBox.Clear();
                descriptionTextBox.Clear();
                
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
            {
                taskList.Items.Remove(taskList.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select a task to delete");
            }
                
        }
    }
}
