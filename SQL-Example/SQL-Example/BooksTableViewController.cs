using Foundation;
using System;
using UIKit;
using System.IO;
using SQLExample.Classes;
using System.Collections.Generic;

namespace SQLExample
{
    public partial class BooksTableViewController : UITableViewController
    {
        List<Book> books;

        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

			string db_name = "books_db.sqlite";
			string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			string db_path = Path.Combine(folderPath, db_name);

            books = DatabaseHelper.Read(db_path);

            TableView.ReloadData();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            books = new List<Book>();

        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("bookCell", indexPath);

            var data = books[indexPath.Row];

            cell.TextLabel.Text = data.Name;
            cell.DetailTextLabel.Text = data.Author;

            return cell;    
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return books.Count;
        }

    }
}