using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProjectDB1.BL
{
    internal class Admin
    {
        //public int UserID;
        public Admin() {
        }

        public void AddAuthor(string fname, string lname,int userId, DateTime dateofbirth, string nationality,int status)
        {
            
                BL.Author author = new BL.Author(fname,lname,userId,dateofbirth,nationality,status);
                author.addAuthorInDatabase();
        }

        public void AddCategory(string name,int userid)
        {
            BL.Category category = new BL.Category(name,userid);
            category.addCategoryInDatabase();
        }
        public void AddPublisher(string name, string type, string language,int userid, string address,int status)
        {
            BL.Publisher category = new BL.Publisher(name, type,language,userid,address,status);
            category.addPublisherInDatabase();
        }

        public void AddLocation(int shelfNo,int capacity,int userid)
        {
            BL.Location location = new Location(shelfNo,capacity,userid);
            location.addLocationInDatabase();
        }

        public void AddBook(string title, string isbn, int categoryID, int publisherID, int publicationYear, int edition, int totalCopies, int availableCopies, int locationID, int adminid,int authorid)
        {
            BL.Book book = new BL.Book(title, isbn, categoryID, publisherID, publicationYear, edition, totalCopies, availableCopies, locationID, adminid,authorid);
            book.addBookToDatabase();
        }
        public void UpdateAuthor(string fname, string lname, int id,DateTime dateofbirth, string nationality,int status)
        {
            BL.Author author = new BL.Author(fname, lname,id, dateofbirth, nationality, status);
            author.UpdateAuthorInDatabase();
        }

        public void DeleteAuthor(string fname, string lname, int id, DateTime dateofbirth, string nationality,int status)
        {
            BL.Author author = new BL.Author(fname, lname, id, dateofbirth, nationality,status);
            author.DeleteAuthorInDatabase();
        }

        public void DeleteCategory(int id,string name)
        {
            BL.Category category = new BL.Category(name, id);
            category.removeCategoryInDatabase();
            
        }

        public void updatePublisher(string publisherName, string publicationType, string publicationLanguage, int userid, string publisherAddress,int status)
        {
            BL.Publisher pub = new Publisher(publisherName, publicationType, publicationLanguage, userid, publisherAddress,status);
            pub.UpdatePublisher();
        }
        public void DeletePublisher(string publisherName, string publicationType, string publicationLanguage, int userid, string publisherAddress, int status)
        {
            BL.Publisher pub = new Publisher(publisherName, publicationType, publicationLanguage, userid, publisherAddress, status);
            pub.DeletePublisher();
        }
        public void UpdateLocation(int shelfNo, int capacity, int id)
        {
            BL.Location location = new Location(shelfNo, capacity, id);
            location.DeleteLocationInDatabase();
        }

        public void AddStudent(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate)
        {
            BL.Student student = new BL.Student(firstName, lastName, email, password, contact, cnic, city, usertype, registrationNo, department, semester, status, studentShip_StartDate);
            student.AddStudentInDatabase();
        }

        public void UpdateStudent(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate,int id)
        {
            BL.Student student = new BL.Student(firstName, lastName, email, password, contact, cnic, city, usertype, registrationNo, department, semester, status, studentShip_StartDate,id);
            student.UpdateStudentInDatabase();
        }
        public void DeleteStudent(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate, int id)
        {
            BL.Student student = new BL.Student(firstName, lastName, email, password, contact, cnic, city, usertype, registrationNo, department, semester, status, studentShip_StartDate, id);
            student.RemoveStudentFromDatabase();
        }

        public void AddStaff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary,int status)
        {
            BL.Staff staff =  new BL.Staff(firstName, lastName, email, password, contact, cnic, city, usertype, designation, salary,status);
            staff.AddStaffInDataBase();
        }
        public void UpdateStaff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary,int id,int status)
        {
            BL.Staff staff = new BL.Staff(firstName, lastName, email, password, contact, cnic, city, usertype, designation, salary,id,status);
            staff.UpdateStaffInDataBase();
        }
        public void DeleteStaff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary, int id, int status)
        {
            BL.Staff staff = new BL.Staff(firstName, lastName, email, password, contact, cnic, city, usertype, designation, salary, id, status);
            staff.RemoveStaffFromDataBase();
        }
    }
}
