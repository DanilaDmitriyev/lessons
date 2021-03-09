using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace SecondFileCategory
{
    [TypeConverter(typeof(TreeTypeConverter))]
    public enum TreeType {oak, apple, pine, cherry}
    class Tree
    {
        [FileCategory("myFileCategory.txt")]
        [DisplayName ("Вечнозелёный")]
        [TypeConverter (typeof(ForeverGreenConverter))]
        public bool ForeverGreen { get; set; }
        [FileCategory("myFileCategory2.txt")]
        [DisplayName("Порода дерева")]

        
        public TreeType TreeType { get; set; }
        [FileCategory("myFileCategory2.txt")]
        [DisplayName("Возраст дерева")]
        public int Age { get; set; }
        [FileCategory("myFileCategory2.txt")]
        [DisplayName("Высота дерева")]
        public int Height { get; set; }
        
        class ForeverGreenConverter : TypeConverter
        {
            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                return sourceType == typeof(string) || sourceType == typeof(bool);
            }
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                if (value is bool && destinationType == typeof(String))
                {
                    if ((bool)value) return "Да";
                    else return "Нет";
                } 
                return base.ConvertTo(context, culture, value, destinationType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
            {
                if(value is string)
                {
                    if ((string)value == "Да") return true;
                    else return false;
                }
                return base.ConvertFrom(context, culture, value);

            }
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                return destinationType == typeof(string) || destinationType == typeof(bool); 
            }

            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(new[] { "Да", "Нет" });
            }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
            {
                return true;
            }
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }
        }
    }
}
