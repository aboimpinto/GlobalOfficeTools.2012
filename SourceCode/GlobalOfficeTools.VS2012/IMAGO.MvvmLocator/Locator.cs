using System;
using System.Linq;
using System.ComponentModel.Composition;
using System.Collections.Generic;

namespace IMAGO.MvvmLocator
{
    public class Locator
    {
        #region Import Properties 
        [ImportMany("ViewModel", AllowRecomposition = true)]
        public IEnumerable<Lazy<object, IViewModelMetadata>> _viewModelLazy { get; set; }
        public object this[string viewModel]
        {
            get
            {
                return _viewModelLazy.Single(x => x.Metadata.Name.Equals(viewModel)).Value;
            }
        }
        #endregion

        #region Constructor 
        public Locator() 
        {
            CompositionInitializer.SatisfyImports(this);
        }
        #endregion
    }
}
