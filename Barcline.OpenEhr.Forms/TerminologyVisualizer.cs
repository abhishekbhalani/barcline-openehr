using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barcline.OpenEhr.Storage;
using WeifenLuo.WinFormsUI.Docking;

namespace Barcline.OpenEhr.Forms
{
    public partial class TerminologyVisualizer : DockContent
    {
        private TerminologyVisualizerPresenter presenter;

        public TerminologyVisualizer()
        {
            InitializeComponent();
            presenter = new TerminologyVisualizerPresenter(this);
        }

        public TerminologyVisualizerPresenter Presenter
        {
            get
            {
                return presenter;
            }
        }

        private void bsCodeSystem_ListChanged(object sender, ListChangedEventArgs e)
        {
            lvCodeSystems.Items.Clear();
            foreach (CodeSystem cs in bsCodeSystem)
            {
                lvCodeSystems.Items.Add(cs.Code).Tag = cs;
            }
        }

        private void lvCodeSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCodeSystems.SelectedIndices.Count != 0)
            {
                bsCodeSystem.Position = lvCodeSystems.SelectedIndices[0];
                bsCodeSystemVersion.Position = 0;
            }
        }

        private void bsConcept_ListChanged(object sender, ListChangedEventArgs e)
        {
            lvConcepts.Items.Clear();
            foreach (Concept concept in bsConcept)
            {
                lvConcepts.Items.Add(concept.Code);
            }
        }
    }

    public class TerminologyVisualizerPresenter
    {
        private TerminologyVisualizer view;
        private ITerminologyService service;

        public TerminologyVisualizerPresenter(TerminologyVisualizer view)
        {
            this.view = view;
        }

        public ITerminologyService Service
        {
            get
            {
                return service;
            }
            set
            {
                service = value;
                if (service != null)
                {
                    view.bsCodeSystem.DataSource = service.GetCodeSystems();
                }
            }
        }
    }
}
