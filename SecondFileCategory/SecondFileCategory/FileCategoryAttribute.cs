using System.ComponentModel;
using System.IO;

namespace SecondFileCategory
{
    class FileCategoryAttribute : CategoryAttribute
    {
        public FileCategoryAttribute(string filename) : base(filename) { }
        //ключевое слово base передаёт параметр filename базовому классу (классу родителю) CategoryAttribute
        protected override string GetLocalizedString(string value)
        {
            if (File.Exists(value)) return File.ReadAllText(value);
            else return base.GetLocalizedString(value);
        }
    }
}
//проверка работы репозитория
