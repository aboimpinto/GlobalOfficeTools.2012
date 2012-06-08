using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using System.Windows.Interactivity;

namespace IMAGO.SL5.Behaviours
{
    public class TabNavByKey : Behavior<Panel>
    {
        /// <summary>
        /// Handle for KeyDown event
        /// </summary>
        private KeyEventHandler hdlKeyDown;

        /// <summary>
        /// Initialization
        /// </summary>
        public TabNavByKey()
        {
            hdlKeyDown = new KeyEventHandler(f_KeyDown);

            IsEnabled = true;
            KeyToTab = Key.Enter;
            NavigationMode = KeyboardNavigationMode.Cycle;
        }

        /// <summary>
        /// Overrides attached
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            var f = this.AssociatedObject as Panel;
            f.KeyDown += hdlKeyDown;

        }

        /// <summary>
        /// Overrides detaching
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            var f = this.AssociatedObject as Panel;
            f.KeyDown -= hdlKeyDown;
        }


        /// <summary>
        /// It's enabled key event to tab?
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The Key to use for tab
        /// </summary>
        public Key KeyToTab { get; set; }

        /// <summary>
        /// Navigation mode
        /// </summary>
        public KeyboardNavigationMode NavigationMode { get; set; }


        /// <summary>
        /// Event for handle the Key
        /// </summary>
        private void f_KeyDown(object sender, KeyEventArgs e)
        {
            //if it's not enabled, out
            if (!IsEnabled)
                return;

            //if it's not the correctly key, out
            if (e.Key != KeyToTab)
                return;

            e.Handled = true;

            //get the Panel
            var pn = sender as Panel;
            //get the current control focused
            var focused = FocusManager.GetFocusedElement() as Control;

            //It's my parent?
            if ((focused == null) || !IsMyParent(pn, focused))
                return;

            //Get a list of controls recusive or "local"
            List<Control> Ctrls = GetAllControls(pn, (NavigationMode != KeyboardNavigationMode.Local));
            //Put in a list with index
            var lsCtrl = Ctrls.Select(s => new { ctrl = s, idx = Ctrls.IndexOf(s) }).ToList();

            //Get a index of selected control in list
            var myIdx = Ctrls.IndexOf(focused);

            //Take a list of possibles nexts controls from selected
            //and by index on list, get next
            var next = lsCtrl
                .Where(w => w.ctrl.TabIndex >= focused.TabIndex && w.idx > myIdx)
                .Select(s => s.ctrl).FirstOrDefault();

            //it's last, do what? go to first
            if (next == null)
            {
                if (NavigationMode != KeyboardNavigationMode.Once)
                    next = Ctrls.FirstOrDefault();
            }

            //so, put focus on next
            if (next != null)
                next.Focus();
        }


        /// <summary>
        /// Function to see if a Control is my parent
        /// </summary>
        private bool IsMyParent(FrameworkElement me, FrameworkElement ctrl)
        {
            FrameworkElement par = ctrl;
            while ((par != null) && (par.Parent != null))
            {
                if (par.Parent == me)
                    return true;
                par = par.Parent as FrameworkElement;
            }
            return false;
        }

        /// <summary>
        /// Function to return a list of contros to tab
        /// </summary>
        /// <param name="pn">Panel to get the childrens</param>
        /// <param name="recursive">Look in others panels inside me</param>
        private List<Control> GetAllControls(Panel pn, bool recursive)
        {
            var lst = new List<Control>();
            foreach (var i in pn.Children)
            {
                if (i is Control)
                {
                    if (((Control)i).IsTabStop)
                        lst.Add(i as Control);
                }
                else if (recursive && (i is Panel))
                    lst.AddRange(GetAllControls(i as Panel, true));
            }
            return lst;
        }

    }
}
