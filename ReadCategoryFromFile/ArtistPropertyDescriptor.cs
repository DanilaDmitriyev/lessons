using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace ReadCategoryFromFile
{
    class ArtistPropertyDescriptor : PropertyDescriptor
    {
        public ArtistPropertyDescriptor(PropertyDescriptor propertyDescriptor)
        : base (propertyDescriptor)
        {
            this.propertyDescriptor = propertyDescriptor;
        }
        
        PropertyDescriptor propertyDescriptor;
        public override Type ComponentType => propertyDescriptor.ComponentType;

        public override bool IsReadOnly => propertyDescriptor.IsReadOnly;

        //пример записи без использования лямбда выражений:
        public override Type PropertyType
        {
            get { return propertyDescriptor.PropertyType; } 
        }

        public override bool CanResetValue(object component)
        {
            return propertyDescriptor.CanResetValue(component);
        }

        public override object GetValue(object component)
        {
            return propertyDescriptor.GetValue(component);
        }

        public override void ResetValue(object component)
        {
            propertyDescriptor.ResetValue(component);
        }

        public override void SetValue(object component, object value)
        {
            propertyDescriptor.SetValue(component, value);
        }

        public override bool ShouldSerializeValue(object component)
        {
            return propertyDescriptor.ShouldSerializeValue(component);
        }

        public override string Category => File.ReadAllText("myCategory.txt");
    }
}
