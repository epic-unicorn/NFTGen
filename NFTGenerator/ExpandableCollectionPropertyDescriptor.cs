using NFTGenerator.Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace NFTGenerator
{
    public class ExpandableCollectionPropertyDescriptor : PropertyDescriptor
    {
        private IList collection;
        private readonly int _index;

        public ExpandableCollectionPropertyDescriptor(IList coll, int idx)
            : base(GetDisplayName(coll, idx), null)
        {
            collection = coll;
            _index = idx;
        }

        private static string GetDisplayName(IList list, int index)
        {
            return list[index] as TraitAttribute != null ? ((TraitAttribute)list[index]).trait_type : "TraitAttribute"; 
        }

        public override bool CanResetValue(object component)
        {
            return true;
        }

        public override Type ComponentType
        {
            get { return this.collection.GetType(); }
        }

        public override object GetValue(object component)
        {
            return collection[_index] as TraitAttribute !=null ? ((TraitAttribute)collection[_index]).value : "TraitValue";
        }

        public override bool IsReadOnly
        {
            get { return true; }
        }

        public override string Name
        {
            get { return _index.ToString(CultureInfo.InvariantCulture); }
        }

        public override Type PropertyType
        {
            get { return collection[_index].GetType(); }
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }

        public override void SetValue(object component, object value)
        {
            collection[_index] = value;
        }
    }
}
