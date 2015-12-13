using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.Core
{
    public class EntityTraverserForeignKeyItem<T>
        where T: class, IModelObject
    {
        public T Master { get; internal set; }
        public T Detail { get; internal set; }
        public PropertyInfo DetailPropertyInfo { get; internal set; }
    }

    public class EntityTraverser<T>
        where T: class, IModelObject
    {
        private List<int> objectsHashes = new List<int>();
        private Dictionary<Type, List<T>> sets = new Dictionary<Type, List<T>>();
        private List<EntityTraverserForeignKeyItem<T>> foreignKeys = new List<EntityTraverserForeignKeyItem<T>>();

        public List<EntityTraverserForeignKeyItem<T>> ForeignKeys
        {
            get
            {
                return foreignKeys;
            }
        }

        public T Lookup(T input)
        {
            if (input == null)
                return default(T);
            var set = Set(input.GetType());
            return set.FirstOrDefault(row => row.EqualsTo(input));   
        }

        public List<T> Set(Type type)
        {
            List<T> set = null;
            if (sets.TryGetValue(type, out set))
                return set;
            set = new List<T>();
            sets.Add(type, set);
            return set;
        }

        public List<T> All()
        {
            var rv = new List<T>();
            foreach (var t in sets.Keys)
            {
                rv.AddRange(sets[t]);
            }
            return rv;
        }

        protected void OnEntityFound(T obj)
        {
            if (obj == null)
                return;

            Object[] key = EntityUtil.GetPrimaryKey(obj);
        }

        public void Traverse(T input)
        {
            objectsHashes.Clear();
            sets.Clear();

            ProcessObjectProperties(0, (T)null, input);
        }

        private void ProcessObjectProperties(int level, T parent, T input)
        {
            try
            {
                if (input == null)
                    return;
                if (objectsHashes.Contains(input.GetHashCode()))
                    return;

                objectsHashes.Add(input.GetHashCode());
                Set(input.GetType()).Add(input);

                foreach (PropertyInfo propertyInfo in EntityUtil.GetProperties(input.GetType()))
                {
                    T child = propertyInfo.GetValue(input) as T;
                    if (child != null)
                    {
                        if (!(child is IEnumerable))
                        {
                            if (!(input is IEnumerable))
                            {
                                var fk = new EntityTraverserForeignKeyItem<T>();
                                fk.Master = child;
                                fk.DetailPropertyInfo = propertyInfo;
                                fk.Detail = input;
                                foreignKeys.Add(fk);
                            }
                            ProcessObjectProperties(level + 1, input, child);
                        }
                        else
                        {
                            foreach (var item in ((IEnumerable)child))
                            {
                                if (item is T)
                                {
                                    ProcessObjectProperties(level + 1, input, (T)item);
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                //stack.Pop();
            }
        }
    }
}
