using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.BL
{
    internal class Admin
    {
        public int UserID;
        public Admin() {
        }

        public void AddAuthor(string fname, string lname,int userId, DateTime dateofbirth, string nationality)
        {
            
                BL.Author author = new BL.Author(fname,lname,userId,dateofbirth,nationality);
                author.addAuthorInDatabase();
        }

        public void AddCategory(string name,int userid)
        {
            BL.Category category = new BL.Category(name,userid);
            category.addCategoryInDatabase();
        }
        public void AddPublisher(string name, string type, string language,int userid, string address)
        {
            BL.Publisher category = new BL.Publisher(name, type,language,userid,address);
            category.addPublisherInDatabase();
        }
    }
}
