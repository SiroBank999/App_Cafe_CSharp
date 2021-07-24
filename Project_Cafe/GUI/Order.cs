using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Order : UserControl
    {
        static Order instance;
        public string nameTable;
        public int idTable;
        public Order()
        {
            InitializeComponent();
            
        }
        public void LoadData()
        {
            lbNameTable.Text = NameTable;
        }
        public void LoadBill()
        {
            LVBill.Items.Clear();
            double total = 0;
            List<ItemBill> listitems = BUS_ItemBill.Instance.getListItemByTable(IdTable);
            foreach(ItemBill item  in listitems)
            {
                ListViewItem viewItem = new ListViewItem(item.FoodName);
                viewItem.SubItems.Add(item.Count.ToString());
                viewItem.SubItems.Add(item.Price.ToString());
                total += item.Price * item.Count;
                LVBill.Items.Add(viewItem);

            }
            LBMoney.Text = total.ToString("C").Replace(",00", "");
            

        }
        
        public string NameTable { get => nameTable; set => nameTable = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public static Order Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new Order();
                return instance;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            OrderLoad();
            
        }
        public void showControl(Control control)
        {
          
            FLFood.Controls.Add(control);
        }
        public void OrderLoad()
        {
            FLFood.Controls.Clear();
            List<Foods> listfood = BUS_Food.Instance.getListFood();
            foreach (Foods food in listfood)
            {
                UFood ufood = new UFood();
                ufood.IdFood = food.IdFood;
                ufood.IdTable = IdTable;
                ufood.ImageFood = food.ImageFood;
                ufood.NameFood = food.NameFood;
                ufood.Label_.Click += LAddFood_Click ;
                ufood.Price = food.PriceFood.ToString("C").Replace(",00", "");
                ufood.getLoadFood();

                showControl(ufood);
            }
        }

        private void LAddFood_Click(object sender, EventArgs e)
        {
            LoadBill();
        }
    }
}
