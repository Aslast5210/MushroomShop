using System.Data;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Test121231
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        private List<Mush> mushrooms = new List<Mush>();


        public Form1()
        {
            InitializeComponent();
        }

        private void LoadComboBoxItems()
        {
            comboBox1.Items.Clear();

            foreach (Customer customer in customers)
            {
                comboBox1.Items.Add(customer.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // เพิ่มข้อมูลประเภทเห็ด
            comboBox2.Items.Add("เห็ดนางฟ้า");
            comboBox2.Items.Add("เห็ดเข็มทอง");
            comboBox2.Items.Add("เห็ดออรินจิ");

            LoadCustomers();
            LoadComboBoxItems();

        }
        private void LoadCustomers()
        {
            string[] lines = File.ReadAllLines("customers.csv");

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                string name = data[0];
                string address = data[1];
                string phoneNumber = data[2];

                Customer customer = new Customer(name, address, phoneNumber);
                customers.Add(customer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = textBox2.Text;
            string phoneNumber = textBox3.Text;
            string type = comboBox2.SelectedItem.ToString();
            double weight = double.Parse(textBox4.Text);

            // สร้าง object ลูกค้า
            Customer customer = new Customer(name, address, phoneNumber);

            // สร้าง object เห็ด
            Mush mushroom = new Mush(type, (int)weight);

            // คำนวนราคา
            double price = Sale.GetPrice(type, weight);

            // บันทึกข้อมูลลูกค้า
            customers.Add(customer);

            // บันทึกข้อมูลการซื้อขาย
            mushrooms.Add(mushroom);

            // เพิ่มข้อมูลใน DataGridView
            dgvCustomers.Rows.Add(name, address, phoneNumber, type, weight, price);

            // บันทึกข้อมูลเป็นไฟล์ .csv
            //SaveToFile();

            MessageBox.Show("บันทึกข้อมูลเสร็จสิ้น");
            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            Customer customer = customers.Find(c => c.Name == name);

            if (customer != null)
            {
                textBox1.Text = customer.Name;
                textBox2.Text = customer.Address;
                textBox3.Text = customer.PhoneNumber;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCustomers.CurrentCell.RowIndex;
            dgvCustomers.Rows.RemoveAt(rowIndex);

        }
        private void SaveToFile()
        {
            // สร้าง SaveFileDialog ใหม่
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // ตั้งค่าชื่อไฟล์เริ่มต้น
            saveFileDialog.FileName = "Customers.csv";

            // ตั้งค่าตัวกรองไฟล์
            saveFileDialog.Filter = "ไฟล์ CSV (*.csv)|*.csv";

            // แสดง SaveFileDialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // สร้าง StringBuilder ใหม่
                StringBuilder sb = new StringBuilder();

                // วนลูปแถวใน DataGridView
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    // เพิ่มค่าแต่ละเซลล์ในแถวไปยัง StringBuilder
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value + ",");
                    }

                    // เพิ่มบรรทัดใหม่
                    sb.AppendLine();
                }

                // บันทึก StringBuilder ไปยังไฟล์
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());

                // แสดงข้อความแจ้งเตือน
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salebutt_Click(object sender, EventArgs e)
        {
            Sale sales = new Sale();

            // ดึงข้อมูลจาก comboBox
            string type = comboBox2.SelectedItem.ToString();
            double weight = int.Parse(textBox4.Text);



            // เรียกใช้ method GetPrice
            double total = Sale.GetPrice(type, weight);

            textBox5.Text = total.ToString("C");
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // สร้าง SaveFileDialog ใหม่
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // ตั้งค่าชื่อไฟล์เริ่มต้น
            saveFileDialog.FileName = "customers.csv";

            // ตั้งค่าตัวกรองไฟล์
            saveFileDialog.Filter = "ไฟล์ CSV (*.csv)|*.csv";

            // แสดง SaveFileDialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // สร้าง StringBuilder ใหม่
                StringBuilder sb = new StringBuilder();

                // วนลูปแถวใน DataGridView
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    // เพิ่มค่าแต่ละเซลล์ในแถวไปยัง StringBuilder
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value + ",");
                    }

                    // เพิ่มบรรทัดใหม่
                    sb.AppendLine();
                }

                // บันทึก StringBuilder ไปยังไฟล์
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());

                // แสดงข้อความแจ้งเตือน
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog ใหม่
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // ตั้งค่าตัวกรองไฟล์
            openFileDialog.Filter = "ไฟล์ CSV (*.csv)|*.csv";

            // แสดง OpenFileDialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dgvCustomers.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4], allDATASplited[5], allDATASplited[6]);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}