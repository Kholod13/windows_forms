using System.Windows.Forms;

namespace wf_finder_full
{
    public partial class Form1 : Form
    {
        private const int preloadLevel = 2;
        private string currentPath;
        public Form1()
        {
            InitializeComponent();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            PreloadDirectories(desktopPath);
            currentPath = desktopPath;
        }

        private void PreloadDirectories(string root)
        {
            treeView1.Nodes.Clear();
            LoadDirectoriesRecursive(root, treeView1.Nodes, preloadLevel);
        }

        private void LoadDirectoriesRecursive(string root, TreeNodeCollection collection, int level)
        {
            DirectoryInfo rootDir = new(root);

            foreach (var dir in rootDir.GetDirectories()) 
            {
               
                if (toolStripButtonShowHidden.Checked == false && (dir.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    continue;
                }

                TreeNode node = new(dir.Name);

                node.Tag = dir.FullName;

                collection.Add(node);

                try
                {

                    if (level > 1 && dir.GetDirectories().Any())
                    {
                        LoadDirectoriesRecursive(dir.FullName, node.Nodes, level - 1);
                    }
                }
                catch { }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
            foreach (TreeNode node in e.Node.Nodes)
            {

                string path = node.Tag.ToString();
                LoadDirectoriesRecursive(path, node.Nodes, 1);
            }
        }

        private void toolStripButtonOpenRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentPath = dialog.SelectedPath;
                PreloadDirectories(dialog.SelectedPath);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            DirectoryInfo dir = new(path);
            listView1.Clear();

            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Size, kb", 100);
            listView1.Columns.Add("Last Modified", 150);
            foreach (var file in dir.GetFiles())
            {
                
                if (toolStripButtonShowHidden.Checked == false && (file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    continue;
                }

                ListViewItem item = new ListViewItem(file.Name, 0);
                item.Tag = file.FullName;
                item.SubItems.Add((file.Length / 1024).ToString());
                item.SubItems.Add(file.LastWriteTime.ToString());

                listView1.Items.Add(item);
            }
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void toolStripButtonNewDirectory_Click(object sender, EventArgs e)
        {
            
            string directoryName = toolStripTextBoxNewDirectory.Text;

            if (treeView1.SelectedNode.Nodes.ContainsKey(directoryName))
            {
                MessageBox.Show("Директорія з таким ім'ям вже існує.");
                return;
            }

           
            TreeNode newDirectoryNode = new TreeNode(directoryName);
            newDirectoryNode.Tag = Path.Combine((string)treeView1.SelectedNode.Tag, directoryName);
            newDirectoryNode.Name = directoryName;

            treeView1.SelectedNode.Nodes.Add(newDirectoryNode);

         
            string path = Path.Combine((string)treeView1.SelectedNode.Tag, directoryName);
            System.IO.Directory.CreateDirectory(path);
        }

        private void toolStripButtonRenameDirectory_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            string newName = toolStripTextBoxRenameDirectory.Text;

            if (selectedNode != null)
            {
                
                if (string.IsNullOrWhiteSpace(newName) || newName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    MessageBox.Show("Недопустиме ім'я папки.");
                    return;
                }

               
                if (selectedNode.Parent.Nodes.ContainsKey(newName))
                {
                    MessageBox.Show("Папка з таким ім'ям вже існує.");
                    return;
                }

                string oldPath = (string)treeView1.SelectedNode.Tag;
                string newPath = Path.Combine((string)treeView1.SelectedNode.Parent.Tag, newName);
                System.IO.Directory.Move(oldPath, newPath);


                selectedNode.Text = newName;
                selectedNode.Tag = Path.Combine((string)treeView1.SelectedNode.Parent.Tag, newName);
            }
        }

        private void toolStripButtonRenameFile_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedFile = listView1.SelectedItems[0];
                string currentFilePath = selectedFile.Tag.ToString(); 
               
                string newFileName = toolStripTextBoxRenameFile.Text;

                if (!string.IsNullOrEmpty(newFileName))
                {
                    try
                    {
                        string directoryPath = Path.GetDirectoryName(currentFilePath);
                        string newFilePath = Path.Combine(directoryPath, newFileName);

                        File.Move(currentFilePath, newFilePath);


                        selectedFile.Text = newFileName;
                        selectedFile.Tag = newFilePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при перейменуванні файлу: {ex.Message}");
                    }
                }
            }
        }

        private void toolStripButtonDeleteFile_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedFile = listView1.SelectedItems[0];
                string filePath = selectedFile.Tag.ToString(); // Передбачається, що шлях до файлу зберігається в властивості Tag елементу ListViewItem

                try
                {
                    File.Delete(filePath);

                    listView1.Items.Remove(selectedFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при видаленні файлу: {ex.Message}");
                }
            }
        }

        private void toolStripButtonDublicate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedFile = listView1.SelectedItems[0];
                string filePath = selectedFile.Tag.ToString(); 

                try
                {
                    string directoryPath = Path.GetDirectoryName(filePath);
                    string uniqueFileName = GenerateUniqueFileName(filePath);
                    string newFilePath = Path.Combine(directoryPath, uniqueFileName);

                    File.Copy(filePath, newFilePath);

                    ListViewItem duplicateFile = new ListViewItem(Path.GetFileName(newFilePath));
                    duplicateFile.Tag = newFilePath;
                    duplicateFile.ImageIndex = 0; 
                    listView1.SmallImageList = imageList1;
                    listView1.Items.Add(duplicateFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при створенні дублікату файлу: {ex.Message}");
                }
            }
        }
        private string GenerateUniqueFileName(string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string fileExtension = Path.GetExtension(filePath);
            string uniqueFileName = $"{fileName}_copy{fileExtension}";
            int counter = 1;

            while (File.Exists(Path.Combine(directoryPath, uniqueFileName)))
            {
                uniqueFileName = $"{fileName}_copy{counter}{fileExtension}";
                counter++;
            }

            return uniqueFileName;
        }

        private void toolStripButtonShowHidden_Click(object sender, EventArgs e)
        {
            if (toolStripButtonShowHidden.Checked == true)
            {
                toolStripButtonShowHidden.Checked = false;
                toolStripButtonShowHidden.Text = "Hide Hidden";
            }
            else
            {
                toolStripButtonShowHidden.Checked = true;
                toolStripButtonShowHidden.Text = "Show Hidden";
            }

            listView1.Items.Clear();
            treeView1.Nodes.Clear();
            LoadDirectoriesRecursive(currentPath, treeView1.Nodes, 2);
        }

        private void toolStripComboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (toolStripComboBoxView.SelectedIndex == 0)
                listView1.View = View.Tile;
            else if (toolStripComboBoxView.SelectedIndex == 1)
                listView1.View = View.Details;
            else if (toolStripComboBoxView.SelectedIndex == 2)
                listView1.View = View.LargeIcon;
            else if (toolStripComboBoxView.SelectedIndex == 3)
                listView1.View = View.SmallIcon;
            else if (toolStripComboBoxView.SelectedIndex == 4)
                listView1.View = View.List;

            if (toolStripComboBoxView.SelectedIndex == 0)
            {
                toolStripButtonMinus.Visible = true;
                toolStripButtonPlus.Visible = true;
            }
            else
            {
                toolStripButtonMinus.Visible = false;
                toolStripButtonPlus.Visible = false;
            }
        }

        private void toolStripButtonMinus_Click(object sender, EventArgs e)
        {
            listView1.TileSize = new Size(listView1.TileSize.Width - 10, listView1.TileSize.Height - 10);
        }

        private void toolStripButtonPlus_Click(object sender, EventArgs e)
        {
            listView1.TileSize = new Size(listView1.TileSize.Width + 10, listView1.TileSize.Height + 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}