namespace RepositoryPattern
{
    public partial class Form1 : Form
    {
        IProductRepository _productRepository;

        public Form1(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _productRepository.GetProducts();
            lblTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
        }
    }
}