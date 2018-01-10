// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SQLExample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonSave { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBookAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBookTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonSave != null) {
                buttonSave.Dispose ();
                buttonSave = null;
            }

            if (txtBookAuthor != null) {
                txtBookAuthor.Dispose ();
                txtBookAuthor = null;
            }

            if (txtBookTitle != null) {
                txtBookTitle.Dispose ();
                txtBookTitle = null;
            }
        }
    }
}