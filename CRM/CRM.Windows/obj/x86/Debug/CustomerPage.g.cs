﻿

#pragma checksum "C:\Users\SYShchipanov\Documents\GitHub\CRM\CRM\CRM.Windows\CustomerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BFC8D24EF316209C9AE498E02356B7CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM
{
    partial class CustomerPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 20 "..\..\..\CustomerPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnToMeetings_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 21 "..\..\..\CustomerPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnToTasks_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 22 "..\..\..\CustomerPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnToContacts_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 23 "..\..\..\CustomerPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnReLogin_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 33 "..\..\..\CustomerPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.Grid_Holding;
                 #line default
                 #line hidden
                #line 33 "..\..\..\CustomerPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.grdCustomer_KeyDown;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


