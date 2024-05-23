using System.Windows.Forms;

namespace SearchinGFoRNumbers
{
    public partial class Form1 : Form
    {
        // private CustomLinkedList<int> _lst = new CustomLinkedList<int>();


        private List<int> numbers = new List<int>(); // Store the extracted numbers

    

        public Form1()
        {
            InitializeComponent();
            RenderList();
        }



        private void SaveNumbersToFile()
        {
            // Choose a file name and path
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить список чисел";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                // Write the numbers to the file
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (int number in numbers)
                    {
                        writer.WriteLine(number);
                    }
                }
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            SaveNumbersToFile();
            /*
            CОХРАНЕНИЕ СПИСКА В ФАЙЛ*/
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); 
            numbers.Clear();
            string text = textBox1.Text; // Get text from the textbox

            // Extract numbers from the text
            numbers.AddRange(NumberHelper.ExtractNumbers(text));
         
            // Display the list of numbers in Panel1
            panel1.Controls.Clear(); // Clear any existing content in Panel1
            if (numbers.Count > 0)
            {
                MessageBox.Show("Числа найдены и добавлены в список!", "Информация");
                Label numbersLabel = new Label();
                numbersLabel.Text = string.Join(", ", numbers); // Join the numbers with commas
                numbersLabel.AutoSize = true;
                numbersLabel.Location = new Point(10, 10);
                panel1.Controls.Add(numbersLabel);
            }
            else
            {
                MessageBox.Show("В тексте не обнаружено чисел.", "Информация");
            }
            // Create a single Label to hold all the numbers separated by commas
      
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Clear the Panel1
            numbers.Clear(); // Clear the numbers list
            RenderList(); // Update the list display
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Clear the TextBox
        }


        private void RenderList()
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(70, 70);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }
    }
}
