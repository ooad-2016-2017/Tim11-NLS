﻿#pragma checksum "C:\Users\Korisnik\Desktop\OVDJERADIS\ProjekatZatvor\ProjekatZatvor\View\Posjetioci.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4616BE529C268CE993F76AADBB6D098A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatZatvor
{
    partial class Posjetioci : 
        global::Windows.UI.Xaml.Controls.Page, 
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
                    global::Windows.UI.Xaml.Controls.Button element1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\View\Posjetioci.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element1).Click += this.Back_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.listica4 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 3:
                {
                    this.listica3 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 4:
                {
                    this.listica2 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 5:
                {
                    this.listica1 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
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

