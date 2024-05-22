namespace lab2tochno
{
    public partial class Form1 : Form
    {
        private CustomLinkedList<int> _lst = new CustomLinkedList<int>();

        private int Value => (int)numericUpDown1.Value;

        public Form1()
        {
            InitializeComponent();
            RenderList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            _lst.Add(Value);
            RenderList();
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            _lst.SwapSecondAndPrenul();
            RenderList();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            _lst.Remove(Value);
            RenderList();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            _lst.Clear();
            RenderList();
        }

        private void RenderList()
        {
            string listString = string.Join(" ", _lst);
            if (_lst.Count == 0) listString = "На данный момент список пуст";
            label_list.Text = listString;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}