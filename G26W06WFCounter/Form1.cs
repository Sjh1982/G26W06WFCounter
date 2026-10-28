namespace G26W06WFCounter
{
    public partial class Form1 : Form
    {
        private int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void OnAdd(object sender, EventArgs e)
        {
            labelCount.Text = $"{++count}";
        }
    }
}
