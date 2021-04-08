using System;
using System.IO;
using System.Windows.Forms;

namespace Civan_AI_UI
{
    public partial class Form1 : Form
    {
        String csvFile = @"C:\Civan\db.civan";
        String imageDB = @"C:\Civan\images\";
        String patientName { get; set; }
        String gender { get; set; }
        String age { get; set; }
        String cigesPerDay = "0";
        String BPmeds { get; set; }
        String prevalentHyp { get; set; }
        String diabetesStr { get; set; }
        String totCholStr { get; set; }
        String sysBPStr { get; set; }
        String diaBPStr { get; set; }
        String glucoseStr { get; set; }
        String imageName { get; set; }
        String imagePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateVeriables();

            StreamWriter sw = new StreamWriter(csvFile);

            sw.Write(patientName+
                "$"+ gender+
                "$"+ age+
                "$"+ cigesPerDay+
                "$"+ BPmeds+
                "$"+ diabetesStr+
                "$"+ prevalentHyp+
                "$"+ sysBPStr+
                "$"+ totCholStr+
                "$"+ diaBPStr+
                "$"+ glucoseStr+
                "$"+ imageName+ "$");

            sw.Close(); sw.Dispose();

            StreamReader sr = new StreamReader(csvFile);
            string oku = "";

            while (!sr.EndOfStream)
            {

                oku += sr.ReadLine();

            }
            string[] ll = oku.Split("\n");
            ll = ll[ll.Length - 1].Split(",");
            MessageBox.Show(ll[ll.Length-1].ToUpper());
        }

        private void UpdateVeriables()
        {
            patientName = name.Text;
            gender = genderBox.SelectedItem.ToString();
            age = agePanel.Value.ToString();
            if (cigsPerDayCheck.Checked) cigesPerDay = cigsPerDay.Value.ToString();
            if (BPMeds.Checked) BPmeds = "1";
            if (diabetes.Checked) diabetesStr = "1";
            if (hyp.Checked) prevalentHyp = "1";
            sysBPStr = sysBP.Value.ToString();
            totCholStr = totChol.Value.ToString();
            diaBPStr = diaBP.Value.ToString();
            glucoseStr = glucose.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genderBox.Items.Add("Male"); genderBox.Items.Add("Famale");
            genderBox.SelectedItem = "Male"; 
        }

        private void cigsPerDayCheck_CheckedChanged(object sender, EventArgs e)
        {
            cigsPerDay.Enabled = !cigsPerDay.Enabled;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt="Image(*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                imagePathTB.Text = imagePath;

                imageName = ofd.SafeFileName;

                File.Copy(imagePath, imageDB + imageName);
            }
            else{}            
        }
    }
}
