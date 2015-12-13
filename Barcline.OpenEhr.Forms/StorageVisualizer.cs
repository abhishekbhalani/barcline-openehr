using Barcline.OpenEhr;
using Barcline.OpenEhr.Model;
using Barcline.OpenEhr.Storage;
using System;
using System.Windows.Forms;

namespace Barcline.OpenEhr.Forms
{
    public partial class StorageVisualizer : UserControl
    {
        public StorageVisualizer()
        {
            InitializeComponent();
            presenter = new StorageVisualizerPresenter(this);
        }

        private StorageVisualizerPresenter presenter;

        internal StorageVisualizerPresenter Presenter
        {
            get
            {
                return presenter;
            }
        }

        public event EventHandler OnCommandArchetypeOpen;

        public new void Load(String path)
        {
            IArchetypeStorage storage = new ArchetypeFileStorage(path);
            presenter.Load(storage);
        }

        public OBJECT_REF SelectedArchetype
        {
            get
            {
                if (lv.SelectedItems.Count == 0)
                    return null;
                OBJECT_REF objectRef = lv.SelectedItems[0].Tag as OBJECT_REF;
                return objectRef;
            }
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            if (OnCommandArchetypeOpen != null)
                OnCommandArchetypeOpen(sender, e);
        }
    }

    internal partial class StorageVisualizerPresenter
    {
        public StorageVisualizerPresenter(StorageVisualizer view)
        {
            this.view = view;
            this.view.tv.BeforeExpand += tv_BeforeExpand;
            this.view.tv.AfterSelect += tv_AfterSelect;
            this.view.tbbReload.Click += tbbReload_Click;
        }

        void mnuArchetypeOpen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void tbbReload_Click(object sender, EventArgs e)
        {
            Load(this.storage);
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is FOLDER)
            {
                FOLDER folder = e.Node.Tag as FOLDER;
                view.lv.Items.Clear();
                foreach (var item in folder.items)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = 1;
                    lvi.Text = item.id.value;
                    lvi.Tag = item;
                    view.lv.Items.Add(lvi);
                }
            }
        }

        private void tv_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                this.view.tv.BeforeExpand -= tv_BeforeExpand;
                e.Node.Nodes.Clear();
                if (e.Node.Tag is FOLDER)
                {
                    FOLDER folder = (FOLDER)e.Node.Tag;
                    foreach (var subFolder in folder.folders)
                    {
                        TreeNode subFolderNode = new TreeNode();
                        subFolderNode.ImageIndex = subFolderNode.SelectedImageIndex = 0;
                        subFolderNode.Tag = subFolder;
                        subFolderNode.Text = subFolder.name.value;
                        if (subFolder.folders.Count != 0)
                            subFolderNode.Nodes.Add("");
                        e.Node.Nodes.Add(subFolderNode);
                    }
                }
            }
            finally
            {
                this.view.tv.BeforeExpand += tv_BeforeExpand;
            }
        }

        private StorageVisualizer view;
        private IArchetypeStorage storage;

        public IArchetypeStorage Storage
        {
            get
            {
                return storage;
            }
        }

        public void Load(IArchetypeStorage storage)
        {
            this.storage = storage;
            this.view.lv.Items.Clear();
            this.view.tv.Nodes.Clear();

            if (storage != null)
            {
                FOLDER folder = this.storage.GetRootFolder(null);

                var rootNode = new TreeNode();
                rootNode.ImageIndex = rootNode.SelectedImageIndex = 0;
                rootNode.Text = folder.name.value;
                rootNode.Nodes.Add("");
                rootNode.Tag = folder;

                this.view.tv.Nodes.Add(rootNode);
                rootNode.Expand();
            }
        }
    }
}