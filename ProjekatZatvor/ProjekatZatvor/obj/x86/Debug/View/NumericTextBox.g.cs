﻿#pragma checksum "C:\Users\Korisnik\Desktop\ProjekatLilaForme\ProjekatZatvor\View\NumericTextBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E0266BA70F1CECBE34A71A99DE32EEC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatZatvor.View
{
    partial class NumericTextBox : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Numeric = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 22 "..\..\..\View\NumericTextBox.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Numeric).SelectionChanged += this.TextBox_SelectionChanged;
                    #line 22 "..\..\..\View\NumericTextBox.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Numeric).TextChanged += this.TextBox_TextChanged;
                    #line 22 "..\..\..\View\NumericTextBox.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Numeric).TextChanging += this.TextBox_TextChanging;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
