using System;
using System.ComponentModel.Composition;

namespace IMAGO.MvvmLib.Navigation
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class ExportWindow : ExportAttribute
    {
        #region Public Properties
        public string Name { get; private set; }
        #endregion

        #region Constructor
        public ExportWindow(string name)
            : base("Window")
        {
            Name = name;
        }
        #endregion
    }
}
