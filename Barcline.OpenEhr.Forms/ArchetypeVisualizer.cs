using Barcline.Core;
using Barcline.OpenEhr;
using Barcline.OpenEhr.Generator;
using Barcline.OpenEhr.Model;
using ScintillaNET;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Barcline.OpenEhr.Forms
{
    public partial class ArchetypeVisualizer : UserControl
    {
        private ArchetypeVisualizerPresenter presenter;
        private String text;

        public event EventHandler TextChanged;

        public String Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                if (TextChanged != null)
                    TextChanged(this, EventArgs.Empty);
            }
        }

        public ArchetypeVisualizer()
        {
            InitializeComponent();
            presenter = new ArchetypeVisualizerPresenter(this);
            InitScintillaXml(txtNodeXml);
            InitScintillaXml(txtInstanceXml);
        }

        private void InitScintillaXml(Scintilla scintilla)
        {
            scintilla.Lexer = Lexer.Xml;
            foreach (var style in scintilla.Styles)
            {
                style.Font = "Courier New";
                style.Size = 10;
            }
            scintilla.Styles[Style.Xml.Default].ForeColor = SystemColors.WindowText;
            scintilla.Styles[Style.Xml.Default].Font = "Courier New";
            scintilla.Styles[Style.Xml.Default].Size = 10;
            scintilla.Styles[Style.Xml.Comment].ForeColor = Color.DarkGray;
            scintilla.Styles[Style.Xml.Tag].ForeColor = Color.Blue;
            scintilla.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
            
        }

        public void LoadArchetype(ARCHETYPE archetype)
        {
            presenter.LoadArchetype(archetype);
        }

        private void tv_MouseDown(object sender, MouseEventArgs e)
        {
            var node = tvArchetype.GetNodeAt(e.X, e.Y);
            if (node != null)
                tvArchetype.SelectedNode = node;
        }

        private void splitContainer_Resize(object sender, EventArgs e)
        {
            splitContainer.SplitterDistance = (sender as Control).ClientSize.Width / 2;
        }

        private void OnSplitterMove(object sender, EventArgs e)
        {
            
        }

        private void OnXmlEditorResize(object sender, EventArgs e)
        {
            txtInstanceXml.Height = (sender as Control).Height;
            txtNodeXml.Height = txtInstanceXml.Height;
        }
    }

    internal class ArchetypeVisualizerPresenter
    {
        private ARCHETYPE archetype;
        private ArchetypeVisualizer view;

        internal ArchetypeVisualizerPresenter(ArchetypeVisualizer view)
        {
            this.view = view;
            this.view.tvArchetype.Nodes.Clear();
            this.view.tvArchetype.BeforeExpand += tv_BeforeExpand;
            this.view.tvArchetype.AfterSelect += tv_AfterSelect;
            this.view.tbbGenerateInstance.Click += mnuGenerateInstance_Click;
            this.view.mnuExpand.Click += mnuExpand_Click;
            this.view.mnuCollapse.Click += mnuCollapse_Click;
            this.view.mnuGenerateInstance.Click += mnuGenerateInstance_Click;
        }

        private void mnuGenerateInstance_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (this.archetype == null)
                    return;

                InstanceFactory instanceFactory = new InstanceFactory(archetype);
                LOCATABLE c = instanceFactory.Create();
                String xml = EntityUtil.GetXml(c);
                this.view.txtInstanceXml.Text = xml;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void mnuClipboard_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(600, 1200);
            this.view.tvArchetype.DrawToBitmap(bmp, new Rectangle(0, 0, 600, 1200));
            Clipboard.SetImage(bmp);
        }

        public void LoadArchetype(ARCHETYPE archetype)
        {
            this.archetype = archetype;
            view.txtNodeXml.Text = archetype.GetXml();
            this.view.tvArchetype.Nodes.Clear();
            this.view.pg.SelectedObject = null;
            if (archetype != null)
            {
                var complexObject = archetype.definition;
                var treeNode = new TreeNode();
                treeNode.ImageIndex = treeNode.SelectedImageIndex = 1;
                treeNode.Tag = new NodeData(archetype.definition);
                treeNode.Text = archetype.definition.rm_type_name;
                treeNode.Nodes.Add("");
                this.view.tvArchetype.Nodes.Add(treeNode);
                this.view.Text = archetype.archetype_id.value;
                treeNode.Expand();
            }
        }

        private void mnuCollapse_Click(object sender, EventArgs e)
        {
            var node = view.tvArchetype.SelectedNode;
            if (node != null)
                node.Collapse();
        }

        private void mnuExpand_Click(object sender, EventArgs e)
        {
            var node = view.tvArchetype.SelectedNode;
            if (node != null)
            {
                node.ExpandAll();
                node.EnsureVisible();
            }
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NodeData nodeData = (NodeData)e.Node.Tag;
            view.pg.SelectedObject = nodeData.Data;
            if (nodeData.Data is IModelObject)
            {
                view.txtNodeXml.Text = ((IModelObject)nodeData.Data).GetXml();
            }
            else
            {
                view.txtNodeXml.Text = "";
            }
        }

        private void tv_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeData nodeData = (NodeData)e.Node.Tag;
            try
            {
                view.tvArchetype.BeforeExpand -= tv_BeforeExpand;
                if (nodeData.Data is C_COMPLEX_OBJECT)
                {
                    C_COMPLEX_OBJECT complexObject = (C_COMPLEX_OBJECT)nodeData.Data;
                    e.Node.Nodes.Clear();
                    foreach (var attr in complexObject.attributes)
                    {
                        TreeNode treeNode = new TreeNode();
                        treeNode.Text = attr.rm_attribute_name + " of type " + attr.GetType().Name;
                        treeNode.Tag = new NodeData(attr);
                        treeNode.ImageIndex = treeNode.SelectedImageIndex = 0;
                        treeNode.Nodes.Add("");
                        e.Node.Nodes.Add(treeNode);
                    }
                }
                if (nodeData.Data is C_ATTRIBUTE)
                {
                    C_ATTRIBUTE attr = (C_ATTRIBUTE)nodeData.Data;
                    e.Node.Nodes.Clear();
                    foreach (var co in attr.children)
                    {
                        TreeNode treeNode = new TreeNode();
                        treeNode.Text = String.Format("[{0}] {1} of type {2} - {3}", co.node_id, co.rm_type_name, co.GetType().Name, this.archetype.LookupTranslationText("en", co.node_id));
                        treeNode.Tag = new NodeData(co);
                        treeNode.ImageIndex = treeNode.SelectedImageIndex = 1;
                        if (co is C_COMPLEX_OBJECT)
                        {
                            treeNode.Nodes.Add("");
                        }
                        e.Node.Nodes.Add(treeNode);
                    }
                }
            }
            finally
            {
                view.tvArchetype.BeforeExpand += tv_BeforeExpand;
            }
        }
    }

    internal class InstanceVisualizerPresenter
    {
        private CARE_ENTRY model;
        private ArchetypeVisualizer view;

        internal InstanceVisualizerPresenter(ArchetypeVisualizer view)
        {
            this.view = view;
            this.view = view;
            this.view.tvArchetype.Nodes.Clear();
            this.view.tvArchetype.BeforeExpand += tv_BeforeExpand;
            this.view.tvArchetype.AfterSelect += tv_AfterSelect;
            this.view.mnuExpand.Click += mnuExpand_Click;
            this.view.mnuCollapse.Click += mnuCollapse_Click;
        }

        public void Load(CARE_ENTRY value)
        {
            this.model = value;
        }

        private void mnuCollapse_Click(object sender, EventArgs e)
        {
            var node = view.tvArchetype.SelectedNode;
            if (node != null)
                node.Collapse();
        }

        private void mnuExpand_Click(object sender, EventArgs e)
        {
            var node = view.tvArchetype.SelectedNode;
            if (node != null)
                node.ExpandAll();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NodeData nodeData = (NodeData)e.Node.Tag;
            view.pg.SelectedObject = nodeData.Data;
        }

        private void tv_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }
    }

    internal class NodeData
    {
        public NodeData()
        {
        }

        public NodeData(Object data)
        {
            this.Data = data;
        }

        public Object Data { get; set; }
    }
}