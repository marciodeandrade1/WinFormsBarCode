using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;


namespace WinFormsBarCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGerarCodigoBarras_Click(object sender, EventArgs e)
        {
            //Encoder
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 300,
                    Height = 100,
                    Margin = 10
                },
                Renderer = new BitmapRenderer()
            };
            var bitmap = writer.Write(txtCodigo.Text);
            pictureBox1.Image = bitmap;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            //Decoder
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null) 
            {
                txtDecode.Text = result.Text;
            }
        }
    }
}
