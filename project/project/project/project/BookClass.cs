using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class BookClass
    {
       private int id;
        private String name;
        private String authorName;
        private int isbnNumber;
        private int quantity;
        private DateTime purchaseDate;
        private String category;
        private double price;

        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setAuthorName(String authorName)
        {
            this.authorName = authorName;
        }
        public void setIsbnNumber(int isbnNumber)
        {
            this.isbnNumber = isbnNumber;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void setCategory(String category)
        {
            this.category = category;
        }
        public void setPrice(double price)
        { 
            this.price = price;
        }
        public void setPurchaseDate(DateTime purchaseDate)
        {
            this.purchaseDate = purchaseDate;
        }
        public int getId() { return id; }
        public String getName() { return name; }
        public String getAuthorName() { return authorName; }
        public int getIsbnNumber() { return isbnNumber; }
        public int getQuantity() { return quantity; }
        public String getCategory() { return category; }
        public double getPrice() { return price; }
        public DateTime getPurchaseDate() { return purchaseDate; }
    }
    }

