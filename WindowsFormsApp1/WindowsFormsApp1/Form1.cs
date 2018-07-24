using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello"); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            transactionPanel.Hide();
            userPanel.Hide();
            equipmentPanel.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionPanel.Show();
            userPanel.Hide();
            equipmentPanel.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionPanel.Hide();
            userPanel.Show();
            equipmentPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEquipmentPanel_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CanonT2i_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Canon T2i - Camera");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteSelection_Click(object sender, EventArgs e)
        {
            //deletes selected items from ListView
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btn_CanonT3i_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Canon T3i - Camera");
        }

        private void btn_CanonT5i_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Canon T5i - Camera");
        }

        private void btn_Canon50D_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Canon 50D - Camera");
        }

        private void btn_TascamHH_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Tascam Handheld - Audio Recorder");
        }

        private void btn_Tascam60D_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Tascam 60DMKII - Audio Recorder");
        }

        private void btn_Other_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Audio (Other) - Audio Equipment");
        }

        private void btnSD2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("SD Card 2 or 4 GB - Media Storage");
        }

        private void btnSD8_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("SD Card 8 to 16 GB - Media Storage");
        }

        private void btnSD32_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("SD Card 32GB or larger - Media Storage");
        }

        private void btn_Canon60D_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Canon 60D - Camera");
        }

        private void btn_CanonC100_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Canon C100 - Camera");
        }

        private void btn_CanonC300_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Canon C300 - Camera");
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Prime Lens - Camera Lens");
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Zoom Lens - Camera Lens");
        }

        private void btnUV_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("UV Filter - Camera Lens Filter");
        }

        private void btn_Polarizer_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Polarizer Filter - Camera Lens Filter");
        }

        private void btnBatteryGrip_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Battery Grip - Camera Accessories");
        }

        private void btnBatteryCharger_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Battery Charger - Camera Accessories");
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Battery (Spare) - Camera Accessories");
        }

        private void btn_Blimp_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Blimp - Audio Accessories");
        }

        private void btn_Fuzzy_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Fuzzy - Audio Accessories");
        }

        private void btn_XLR6_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("XLR 6 feet - Audio Cable");
        }

        private void btn_XLR12_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("XLR 12 feet - Audio Cable");
        }

        private void btn_XLR20_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("XLR 20 feet - Audio Cable");
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Shotgun Mic - Microphone");
        }

        private void btnHandheld_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Handheld Mic - Microphone");
        }

        private void btnLavWireless_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Lavalier Wireless Mic - Microphone");
        }

        private void btnLavWired_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Lavalier Wired Mic - Microphone");
        }

        private void btnTripod_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Tripod - Camera Mount");
        }

        private void btnMonopod_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Monopod - Camera Mount");
        }

        private void btnHiHat_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Hi Hat - Camera Mount");
        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Slider - Camera Mount");
        }

        private void btnJib_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Jib - Camera Mount");
        }

        private void btnGorillaPod_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("GorillaPod - Camera Mount");
        }

        private void btnLightingKit_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Lighting Kit - Lighting");
        }

        private void btnInkie_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Mole-Richardson Inkie - Lighting");
        }

        private void btnTweenie_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Mole-Richardson Tweenie - Lighting");
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Lowel DP - Lighting");
        }

        private void btnTota_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Lowel Tota - Lighting");
        }

        private void btnLEDPanel_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("LED Panel - Lighting");
        }

        private void btnFresnelOther_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Fresnel (Other) - Lighting");
        }

        private void btnFlood_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Flood Light - Lighting");
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Flash - Lighting");
        }

        private void btnFlexFill_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("FlexFill - Lighting");
        }
    }
}
