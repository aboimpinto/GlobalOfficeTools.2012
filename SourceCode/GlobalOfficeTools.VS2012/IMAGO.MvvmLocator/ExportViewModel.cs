using System;
using System.ComponentModel.Composition;

namespace IMAGO.MvvmLocator
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class ExportViewModel : ExportAttribute 
    {
        #region Public Properties 
        public string Name { get; private set; }
        #endregion

        #region Constructor 
        public ExportViewModel(string name) : base("ViewModel") 
        {
            Name = name;
        }
        #endregion
    }
}
