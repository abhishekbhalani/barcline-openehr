using Barcline.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.OpenEhr.Model
{
    public class OpenEhrModelTraverserEventArgs: EventArgs
    {
        public IModelObject Parent { get; internal set; }
        public IModelObject Current { get; internal set; }
        public int Level { get; internal set; }
    }

    public delegate void OpenEhrModelTraverserEventHandler(Object sender, OpenEhrModelTraverserEventArgs e);

    public class OpenEhrModelTraverser
    {
        public event OpenEhrModelTraverserEventHandler OnObject;

        public void Traverse(IModelObject value)
        {
            InternalTraverse(null, value, 0);
        }

        private void InternalTraverse(IModelObject parent, IModelObject current, int level)
        {
            if (OnObject != null)
            {
                OpenEhrModelTraverserEventArgs e = new OpenEhrModelTraverserEventArgs();
                e.Parent = parent;
                e.Current = current;
                e.Level = level;
                OnObject(this, e);
            }

            foreach (var item in current.GetChildren())
            {
                if (item is IModelObject)
                    InternalTraverse(current, (IModelObject)item, level + 1);
            }
        }
    }
}
