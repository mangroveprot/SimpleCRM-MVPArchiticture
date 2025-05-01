using System;
using System.Windows.Forms;

namespace SimpleCRM.View._base
{
    public class BaseView
    {
        protected TabControl tabControl;
        protected TabPage listTab;
        protected TabPage detailsTab;

        public EventHandler SearchEvent;
        public EventHandler AddNewEvent;
        public EventHandler EditEvent;
        public EventHandler DeleteEvent;
        public EventHandler SaveEvent;
        public EventHandler CancelEvent;

        protected Button searchBtn, addNewBtn, editBtn, saveBtn, cancelBtn, deleteBtn;
        protected TextBox searchField;

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public string AddModeTitle { get; set; } = "Add New";
        public string EditModeTitle { get; set; } = "Edit";

        public BaseView(
            Button searchBtn,
            TextBox searchField,
            Button addNewBtn,
            Button editBtn,
            Button saveBtn,
            Button cancelBtn,
            Button deleteBtn,
            TabControl tabControl,
            TabPage listTab,
            TabPage detailsTab,
            string addModeTitle = "Add New",
            string editModeTitle = "Edit")
        {
            this.searchBtn = searchBtn;
            this.searchField = searchField;
            this.addNewBtn = addNewBtn;
            this.editBtn = editBtn;
            this.saveBtn = saveBtn;
            this.cancelBtn = cancelBtn;
            this.deleteBtn = deleteBtn;
            this.tabControl = tabControl;
            this.listTab = listTab;
            this.detailsTab = detailsTab;
            this.AddModeTitle = addModeTitle;
            this.EditModeTitle = editModeTitle;

            AssociateAndRaiseViewEvents();
        }

        protected void AssociateAndRaiseViewEvents()
        {
            searchBtn.Click += (s, e) => SearchEvent?.Invoke(this, EventArgs.Empty);
            searchField.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            addNewBtn.Click += (s, e) =>
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                SwitchToDetails(AddModeTitle);
            };

            editBtn.Click += (s, e) =>
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                SwitchToDetails(EditModeTitle);
            };

            saveBtn.Click += (s, e) =>
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    SwitchToList();
                }
                MessageBox.Show(Message);
            };

            cancelBtn.Click += (s, e) =>
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                SwitchToList();
            };

            deleteBtn.Click += (s, e) =>
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected item?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        private void SwitchToDetails(string title)
        {
            tabControl.TabPages.Remove(listTab);
            tabControl.TabPages.Add(detailsTab);
            detailsTab.Text = title;
        }

        private void SwitchToList()
        {
            tabControl.TabPages.Remove(detailsTab);
            tabControl.TabPages.Add(listTab);
        }

        public void SetBindingSource(BindingSource bindingSource, DataGridView targetGrid)
        {
            targetGrid.DataSource = bindingSource;
        }

        public static T GetInstance<T>(Form parentContainer) where T : Form, new()
        {
            T instance;

            var existing = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (existing == null || existing.IsDisposed)
            {
                instance = new T
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
            }
            else
            {
                instance = existing;
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;

                instance.BringToFront();
            }

            return instance;
        }
    }
}
