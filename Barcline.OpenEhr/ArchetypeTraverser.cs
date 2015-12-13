using Barcline.OpenEhr.Model;
using System;

namespace Barcline.OpenEhr
{
    public delegate void ArchetypeTraverserObjectFoundEvent(object sender, ArchetypeTraverserObjectFoundEventArgs e);

    public sealed class ArchetypeTraverser
    {
        private ARCHETYPE archetype;
        private ArchetypeTraverserObjectFoundEventArgs eventArgs;

        public ArchetypeTraverser(ARCHETYPE archetype)
        {
            this.archetype = archetype;
        }

        public ARCHETYPE Archetype
        {
            get
            {
                return this.archetype;
            }
        }

        public event ArchetypeTraverserObjectFoundEvent OnObjectFound;

        public void Traverse(Object userData = null)
        {
            eventArgs = new ArchetypeTraverserObjectFoundEventArgs();
            eventArgs.UserData = userData;

            InternalTraverse(this.archetype, null, null, this.archetype.definition, 0);
        }

        private void InternalTraverse(ARCHETYPE a, C_COMPLEX_OBJECT parent, C_ATTRIBUTE parentAttribute, C_OBJECT current, int level)
        {
            if (this.OnObjectFound == null)
                return;

            eventArgs.Archetype = a;
            eventArgs.Parent = parent;
            eventArgs.Attribute = parentAttribute;
            eventArgs.Current = current;
            eventArgs.Level = level;
            eventArgs.RmTypeName = current.rm_type_name;
            eventArgs.Stop = false;
            OnObjectFound(this, eventArgs);
            if (eventArgs.Stop)
                return;

            if (current is C_COMPLEX_OBJECT)
            {
                C_COMPLEX_OBJECT complexObject = (C_COMPLEX_OBJECT)current;
                foreach (C_ATTRIBUTE attr in complexObject.attributes)
                {
                    foreach (C_OBJECT chobj in attr.children)
                    {
                        InternalTraverse(archetype, complexObject, attr, chobj, level + 1);
                    }
                }
            }
        }
    }

    public sealed class ArchetypeTraverserObjectFoundEventArgs : EventArgs
    {
        public ARCHETYPE Archetype { get; internal set; }

        public C_OBJECT Current { get; internal set; }

        public int Level { get; internal set; }

        public C_ATTRIBUTE Attribute { get; internal set; }

        public C_COMPLEX_OBJECT Parent { get; internal set; }

        public String RmTypeName { get; internal set; }

        public Object UserData { get; set; }

        public bool Stop { get; set; }
    }
}