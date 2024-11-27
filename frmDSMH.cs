using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopBanGiay
{
    public partial class frmDSMH : Form
    {
        public List<Shoes> shoesList = new List<Shoes>();
        public frmDSMH()
        {
            InitializeComponent();
        }

       
       
    private void frmDSMH_Load(object sender, EventArgs e)
    {
            //panelTop.BackColor = Color.FromArgb(34, 31, 31);

            shoesList.Add(new Shoes(1, "Air Max 90", "Nike", "Black", 42, 120.99m, 5, "Sport", "", ""));
            shoesList.Add(new Shoes(2, "Yezzy 350", "Nike", "Black", 42, 150.99m, 5, "Sport", "", ""));
            shoesList.Add(new Shoes(3, "Chuck Taylor All Star", "Converse", "Red", 41, 60.00m, 10, "Casual", "", ""));
            shoesList.Add(new Shoes(4, "Gel-Kayano 27", "Asics", "Blue", 44, 130.75m, 4, "Running", "", ""));
            shoesList.Add(new Shoes(5, "Classic Leather", "Reebok", "Grey", 42, 90.25m, 7, "Casual", "", ""));
            shoesList.Add(new Shoes(6, "Stan Smith", "Adidas", "Green", 40, 75.50m, 8, "Casual", "", ""));
            shoesList.Add(new Shoes(7, "Pegasus 38", "Nike", "Black", 45, 110.00m, 6, "Running", "", ""));
            shoesList.Add(new Shoes(8, "Clyde Court", "Puma", "Orange", 44, 85.99m, 5, "Basketball", "", ""));
            shoesList.Add(new Shoes(9, "Old Skool", "Vans", "Black", 43, 65.00m, 9, "Casual", "", ""));
            shoesList.Add(new Shoes(10, "Fresh Foam 1080", "New Balance", "Grey", 42, 140.99m, 3, "Running", "", ""));
            shoesList.Add(new Shoes(11, "ZoomX Vaporfly", "Nike", "White", 46, 250.00m, 2, "Running", "", ""));
            shoesList.Add(new Shoes(12, "Suede Classic", "Puma", "Brown", 41, 75.99m, 6, "Casual", "", ""));

            AddShoesFromListToListView();

        }
        private void AddShoesFromListToListView()
        {
            //ID,Name,Brand,Color,Size,Price,Quantity,Type,Description,ImagaLink
            //lvGiay.Items.Clear(); 

            foreach (var shoe in shoesList)
            {

                
                ListViewGroup group = null;
                foreach (ListViewGroup existingGroup in listView1.Groups)
                {
                    if (existingGroup.Header == shoe.Brand)
                    {
                        group = existingGroup;
                        break;
                    }
                }

               
                if (group == null)
                {
                    group = new ListViewGroup(shoe.Brand);
                    listView1.Groups.Add(group);
                }

                // Create a new ListViewItem and add sub-items
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(shoe.ID.ToString());
                item.SubItems.Add(shoe.Name);
                item.SubItems.Add(shoe.Size.ToString());
                item.SubItems.Add(shoe.Color);
                item.SubItems.Add(shoe.Price.ToString("C"));
                item.SubItems.Add(shoe.Quantity.ToString());
                item.SubItems.Add(shoe.Type.ToString());

                // Check stock availability and add the appropriate status
                if (shoe.Quantity > 0)
                {
                    item.SubItems.Add("Còn hàng"); // In stock
                }
                else
                {
                    item.SubItems.Add("Hết hàng"); // Out of stock
                }

                // Assign the item to the corresponding group
                item.Group = group;

                // Add the item to the ListView
                listView1.Items.Add(item);



            }
        }
    }
}
