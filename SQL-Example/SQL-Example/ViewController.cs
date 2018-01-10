using System;
using System.IO;
using SQLExample.Classes;
using UIKit;

namespace SQLExample
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
         
            // Perform any additional setup after loading the view, typically from a nib.
            // Do stuff when save button is clicked
            buttonSave.TouchUpInside += ButtonSave_TouchUpInside;
        }

        void ButtonSave_TouchUpInside(object sender, EventArgs e)
        {
            string db_name = "books_db.sqlite";
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string db_path = Path.Combine(folderPath, db_name);

            Book newBook = new Book() { Author = txtBookAuthor.Text, Name = txtBookTitle.Text };

            if (DatabaseHelper.Insert(ref newBook, db_path))
                
                //Console.WriteLine("SUCCESS");
                NavigationController.PopToRootViewController(true); //Goes back to the list 
            else
                Console.WriteLine("FAILURE");
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
