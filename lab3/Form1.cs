using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    groupBox2.Visible = true;
                    groupBox2.BringToFront();
                    groupBox3.Visible = false;
                    label20.Visible = true;
                    label21.Visible = true;
                    textBox10.Visible = true;
                    button1.Enabled = true;
                    break;

                case 1:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    groupBox3.BringToFront();
                    label20.Visible = false;
                    label21.Visible = false;
                    textBox10.Visible = false;
                    button1.Enabled = true;
                    break;

                case 2:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    textBox10.Visible = false;
                    button1.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Невозможная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double length) == false)
                {
                    MessageBox.Show("Неверный формат длины", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (double.TryParse(textBox2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double width) == false)
                {
                    MessageBox.Show("Неверный формат ширины", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (double.TryParse(textBox3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double height) == false)
                {
                    MessageBox.Show("Неверный формат высоты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double toilet_area = 0;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        if (double.TryParse(textBox4.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out toilet_area) == false)
                        {
                            MessageBox.Show("Неверный формат площади санузла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (double.TryParse(textBox5.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double bathroom_area) == false)
                        {
                            MessageBox.Show("Неверный формат площади ванной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (double.TryParse(textBox6.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double kithen_area) == false)
                        {
                            MessageBox.Show("Неверный формат площади кухни", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (double.TryParse(textBox7.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double hallway_area) == false)
                        {
                            MessageBox.Show("Неверный формат площади прихожей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Place apartment = new Apartment(length, width, height, toilet_area, bathroom_area, kithen_area, hallway_area);
                        double apartment_area = apartment.GetArea();
                        double apartment_volume = apartment.GetVolume();
                        double apartment_live_area = apartment.GetLiveArea();
                        textBox8.Text = Convert.ToString(apartment_area);
                        textBox9.Text = Convert.ToString(apartment_volume);
                        textBox10.Text = Convert.ToString(apartment_live_area);
                        break;

                    case 1:
                        if (double.TryParse(textBox11.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out toilet_area) == false)
                        {
                            MessageBox.Show("Неверный формат площади санузла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Office office = new Office(length, width, height, toilet_area);
                        double office_area = office.GetArea();
                        double office_volume = office.GetVolume();
                        textBox8.Text = Convert.ToString(office_area);
                        textBox9.Text = Convert.ToString(office_volume);
                        break;

                    default:
                        Storage storage = new Storage(length, width, height);
                        double storage_area = storage.GetArea();
                        double storage_volume = storage.GetVolume();
                        textBox8.Text = Convert.ToString(storage_area);
                        textBox9.Text = Convert.ToString(storage_volume);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
