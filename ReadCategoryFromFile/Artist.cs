using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ReadCategoryFromFile
{
    
    class Artist : ICustomTypeDescriptor
    {
        
        [Category("Художник")]
        public string Name { get; set; }
        [Category("Художник")]
        public DateTime Birth { get; set; }
        [Category("Художник")]
        public DateTime End { get; set; }

        AttributeCollection ICustomTypeDescriptor.GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this.GetType());
            
        }

        string ICustomTypeDescriptor.GetClassName()
        {
            return TypeDescriptor.GetClassName(this.GetType());
        }

        string ICustomTypeDescriptor.GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this.GetType());
        }

        TypeConverter ICustomTypeDescriptor.GetConverter()
        {
            return TypeDescriptor.GetConverter(this.GetType());
        }

        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this.GetType());
        }

        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this.GetType());
        }

        object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this.GetType(), editorBaseType);
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
        {
            return TypeDescriptor.GetEvents(this.GetType());
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this.GetType(), attributes);
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
            var tmp1 = TypeDescriptor.GetProperties(this.GetType());
            var tmp2 = new PropertyDescriptor[tmp1.Count];
            for(int i=0; i<tmp2.Length; i++)
            {
                tmp2[i] = new ArtistPropertyDescriptor(tmp1[i]);
            }
            return new PropertyDescriptorCollection(tmp2);
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        {
            var tmp1 = TypeDescriptor.GetProperties(this.GetType(), attributes);
            var tmp2 = new PropertyDescriptor[tmp1.Count];
            for (int i = 0; i < tmp2.Length; i++)
            {
                tmp2[i] = new ArtistPropertyDescriptor(tmp1[i]);
            }
            return new PropertyDescriptorCollection(tmp2);
        }

        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }
    }
}
