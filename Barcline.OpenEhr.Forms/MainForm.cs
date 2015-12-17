using Barcline.OpenEhr.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcline.OpenEhr.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            m_StorageView = new ArchetypeStorageToolWindow();
            m_StorageView.Show(dockPanel);
            m_StorageView.CloseButtonVisible = false;

            presenter = new MainFormPresenter(this);
        }

        internal ArchetypeStorageToolWindow m_StorageView;
        private MainFormPresenter presenter;
    }

    public class MainFormPresenter
    {
        private MainForm view;

        public MainFormPresenter(MainForm view)
        {
            this.view = view;
            this.view.mnuOpenArchetypeStorage.Click += mnuOpenArchetypeStorage_Click;
            this.view.Load += view_Load;
            this.view.FormClosing += view_FormClosing;
            this.view.ctxRecent.Opening += ctxRecent_Opening;

            this.view.m_StorageView.StorageVisualizer.OnCommandArchetypeOpen += StorageVisualizer_OnCommandArchetypeOpen;
            this.view.mnuTerminology.Click += OnOpenTerminology;
            this.view.mnuFileExit.Click += mnuFileExit_Click;
        }

        void OnOpenTerminology(object sender, EventArgs e)
        {
            var view = new TerminologyVisualizer();
            view.Show(this.view.dockPanel);
            view.Presenter.Service = new SimpleTerminologyService();
            
        }

        void ctxRecent_Opening(object sender, CancelEventArgs e)
        {
            var ctx = view.ctxRecent;
            ctx.Items.Clear();
            if (Properties.Settings.Default.MainForm_Storages != null)
            {
                foreach (var path in Properties.Settings.Default.MainForm_Storages)
                {
                    var menuItem = ctx.Items.Add(path);
                    menuItem.Click += (a, b) =>
                    {
                        if (Directory.Exists(menuItem.Text))
                        {
                            this.view.m_StorageView.StorageVisualizer.Load(menuItem.Text);
                        }
                    };
                }
            }
        }

        void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuOpenArchetypeStorage_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.MainForm_LastStorage))
                view.fbd.SelectedPath = Properties.Settings.Default.MainForm_LastStorage;

            if (view.fbd.ShowDialog() == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(view.fbd.SelectedPath))
                {
                    DirectoryInfo di = new DirectoryInfo(view.fbd.SelectedPath);
                    if (!di.Exists)
                        return;
                    this.view.m_StorageView.StorageVisualizer.Load(di.FullName);
                    if (Properties.Settings.Default.MainForm_Storages == null)
                        Properties.Settings.Default.MainForm_Storages = new System.Collections.Specialized.StringCollection();
                    if (!Properties.Settings.Default.MainForm_Storages.Contains(view.fbd.SelectedPath))
                        Properties.Settings.Default.MainForm_Storages.Insert(0, view.fbd.SelectedPath);
                    Properties.Settings.Default.MainForm_LastStorage = view.fbd.SelectedPath;
                }
            }
        }

        private void StorageVisualizer_OnCommandArchetypeOpen(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var objectRef = this.view.m_StorageView.StorageVisualizer.SelectedArchetype;
                if (objectRef != null)
                {
                    var archetype = this.view.m_StorageView.StorageVisualizer.Presenter.Storage.LoadArchetype(objectRef.id.value);
                    if (archetype != null)
                    {
                        var window = new ArchetypeVisualizerToolWindow();
                        window.ArchetypeVisualizer.LoadArchetype(archetype);
                        window.Show(this.view.dockPanel);
                    }
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        void view_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == 0)
            {
                Point location = view.Location;
                Size size = view.Size;
                if (view.WindowState != FormWindowState.Normal)
                {
                    location = view.RestoreBounds.Location;
                    size = view.RestoreBounds.Size;
                }
                string initLocation = string.Join(",", location.X, location.Y, size.Width, size.Height);
                Properties.Settings.Default.MainForm_InitialLocation = initLocation;
                Properties.Settings.Default.Save();
            }
        }

        void view_Load(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Properties.Settings.Default.MainForm_InitialLocation;
                Point il = new Point(0, 0);
                Size sz = view.Size;
                if (!string.IsNullOrWhiteSpace(initLocation))
                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                    if (parts.Length >= 4)
                    {
                        sz = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                }
                view.Size = sz;
                view.Location = il;
            }
        }
    }
}