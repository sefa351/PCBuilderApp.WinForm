using PCBuilder.Business;
using PCBuilder.Entities;
using System;
using System.Drawing; // Renkler için gerekli (Color.Red vs.)
using System.Windows.Forms;

namespace PCBuilderApp
{
    public partial class Form1 : Form
    {
        // Business katmaný servisi
        ProductService _service = new ProductService();

        public Form1()
        {
            InitializeComponent();

            // Tasarýmda arka planý ayarlamadýysan buradan garantile
            this.BackColor = Color.FromArgb(32, 32, 32);
        }

        // --- FORM YÜKLENÝRKEN ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Ýþlemcileri ve Güç Kaynaklarýný Yükle
            LoadDataToCombo(cmbCpu, _service.GetCPUs());
            LoadDataToCombo(cmbPsu, _service.GetPSUs());

            // 2. Diðer Kutularý Temizle
            ClearCombos(cmbAnakart, cmbRam, cmbGpu);

            // 3. Sepeti baþlangýçta boþalt
            UpdateCartSummary();
        }

        // --- ÝÞLEMCÝ SEÇÝLÝNCE ---
        private void cmbCpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCpu.SelectedIndex == -1 || !(cmbCpu.SelectedValue is int selectedCpuId))
            {
                ClearCombos(cmbAnakart, cmbRam, cmbGpu);
                UpdateCartSummary(); // Sepeti güncelle (temizle)
                return;
            }

            // Anakartlarý getir
            var compatibleMBs = _service.GetCompatibleMotherboards(selectedCpuId);
            LoadDataToCombo(cmbAnakart, compatibleMBs);

            // Alt parçalarý temizle
            ClearCombos(cmbRam, cmbGpu);

            // SONUÇ: Sepeti güncelle
            UpdateCartSummary();
        }

        // --- ANAKART SEÇÝLÝNCE ---
        private void cmbAnakart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnakart.SelectedIndex == -1 || !(cmbAnakart.SelectedValue is int selectedMbId))
            {
                ClearCombos(cmbRam, cmbGpu);
                UpdateCartSummary();
                return;
            }

            // RAM ve GPU'larý getir
            LoadDataToCombo(cmbRam, _service.GetCompatibleRAMs(selectedMbId));
            LoadDataToCombo(cmbGpu, _service.GetCompatibleGPUs(selectedMbId));

            // SONUÇ: Sepeti güncelle
            UpdateCartSummary();
        }

        // --- DÝÐER PARÇALAR SEÇÝLÝNCE ---
        private void cmbRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartSummary();
        }

        private void cmbGpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartSummary();
        }

        private void cmbPsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartSummary();
        }

        // ============================================================
        //              YARDIMCI METOTLAR
        // ============================================================

        private void LoadDataToCombo(ComboBox combo, object dataSource)
        {
            combo.DataSource = null;
            combo.DisplayMember = "Name";
            combo.ValueMember = "Id";
            combo.DataSource = dataSource;
            combo.SelectedIndex = -1;
        }

        private void ClearCombos(params ComboBox[] combos)
        {
            foreach (var combo in combos)
            {
                combo.DataSource = null;
                combo.Items.Clear();
            }
        }

        // ============================================================
        //           YENÝ SEPET VE HESAPLAMA METODU (TEK METOT)
        // ============================================================
        private void UpdateCartSummary()
        {
            // 1. Temizlik
            lstSepet.Items.Clear();
            decimal totalPrice = 0;
            int totalTDP = 0;

            // Ýç Metot: Ýsmi kýsaltýr ve hizalar
            void AddToCart(string category, Product? product)
            {
                if (product != null)
                {
                    // 1. ÝSMÝ KISALTMA MANTIÐI
                    // Ürün ismi 28 karakterden uzunsa, 25'ini alýp sonuna "..." ekleyelim.
                    // Böylece yanýndaki fiyat sütunu asla kaymaz.
                    string urunIsmi = product.Name;
                    if (urunIsmi.Length > 28)
                    {
                        urunIsmi = urunIsmi.Substring(0, 25) + "...";
                    }

                    // 2. HÝZALAMA VE EKLEME
                    // PadRight(30) diyerek isme 30 karakterlik yer ayýrýyoruz.
                    string line = $"{category.PadRight(15)} | {urunIsmi.PadRight(30)} | {product.Price:C2}";

                    lstSepet.Items.Add(line);

                    // Fiyat ve Güç hesaplamalarý aynen devam eder
                    totalPrice += product.Price;

                    if (product is CPU c) totalTDP += c.TDP;
                    if (product is GPU g) totalTDP += g.TDP;
                }
            }

            // 2. Parçalarý Sepete Ekle
            AddToCart("ÝÞLEMCÝ", cmbCpu.SelectedItem as CPU);
            AddToCart("ANAKART", cmbAnakart.SelectedItem as Motherboard);
            AddToCart("RAM", cmbRam.SelectedItem as RAM);
            AddToCart("EKRAN KARTI", cmbGpu.SelectedItem as GPU);
            AddToCart("GÜÇ KAYNAÐI", cmbPsu.SelectedItem as PowerSupply);

            // Sabit yük
            if (totalTDP > 0) totalTDP += 50;

            // 3. Fiyatý Güncelle
            // Eðer lblToplamFiyat tasarýmda yoksa hata verir, ismini kontrol et!
            lblToplamFiyat.Text = $"TOPLAM: {totalPrice:C2}";

            // 4. Güç Kontrolü
            var psu = cmbPsu.SelectedItem as PowerSupply;
            if (psu != null)
            {
                if (psu.Wattage >= totalTDP)
                {
                    lblWattDurumu.Text = $"[OK] SÝSTEM UYUMLU (Tüketim: {totalTDP}W / PSU: {psu.Wattage}W)";
                    lblWattDurumu.ForeColor = Color.LightGreen;
                }
                else
                {
                    lblWattDurumu.Text = $"? GÜÇ YETERSÝZ! (Gereken: {totalTDP}W / PSU: {psu.Wattage}W)";
                    lblWattDurumu.ForeColor = Color.Red;
                }
            }
            else
            {
                lblWattDurumu.Text = $"Tahmini Tüketim: {totalTDP}W";
                lblWattDurumu.ForeColor = Color.Gray;
            }
        }

        private void lblWattDurumu_Click(object sender, EventArgs e)
        {

        }

        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}