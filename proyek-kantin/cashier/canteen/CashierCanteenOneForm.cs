﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyek_kantin
{
    public partial class CashierCanteenOneForm : Form
    {
        public CashierCanteenOneForm()
        {
            InitializeComponent();
        }

        /** variable for count food order data  */
        private int labelCount = 1;

        private static int rice = 5000;
        private static int chick = 10000;
        private static int veg = 7000;
        private static int nood = 12000;

        /** logic for button plus one and minus one */
        private void Btn_Plus_One_Click(object sender, EventArgs e)
        {

            /** 
             * this logic is for counting order and set into 
             * labelCount and textBox for rice price
             */
            int ricePrice = int.Parse(tbRicePrice.Text);
            int riceRes = ricePrice + rice;
            tbRicePrice.Text = riceRes.ToString();

            int riceCount = int.Parse(labelCountRice.Text);
            int countResRice = riceCount + labelCount;
            labelCountRice.Text = countResRice.ToString();
        }

        private void Btn_Min_One_Click(object sender, EventArgs e)
        {
            int ricePrice = int.Parse(tbRicePrice.Text);
            int riceCount = int.Parse(labelCountRice.Text);

            if (ricePrice >= rice && riceCount >= labelCount) {

                int riceRes = ricePrice - rice;
                tbRicePrice.Text = riceRes.ToString();

                int countResRice = riceCount - labelCount;
                labelCountRice.Text = countResRice.ToString();
            } 
        }

        /** logic for button plus and minus two */
        private void Btn_Plus_Two_Click(object sender, EventArgs e)
        {
            int chickPrice = int.Parse(tbChickPrice.Text);
            int chickRes = chickPrice + chick;
            tbChickPrice.Text = chickRes.ToString();

            int chickCount = int.Parse(labelCountChick.Text);
            int countResChick = chickCount + labelCount;
            labelCountChick.Text = countResChick.ToString();
        }

        private void Btn_Min_Two_Click(object sender, EventArgs e)
        {
            int chickPrice = int.Parse(tbChickPrice.Text);
            int chickCount = int.Parse(labelCountChick.Text);

            if (chickPrice >= chick && chickCount >= labelCount) {
                int chickRes = chickPrice - chick;
                tbChickPrice.Text = chickRes.ToString();

                int countResChick = chickCount - labelCount;
                labelCountChick.Text = countResChick.ToString();
            }
        }

        /** this is logic for plus and minus at food three */
        private void Btn_Plus_Three_Click(object sender, EventArgs e)
        {
            int vegPrice = int.Parse(tbVegetablePrice.Text);
            int vegRes = vegPrice + veg;
            tbVegetablePrice.Text = vegRes.ToString();

            int vegCount = int.Parse(labelCountVeg.Text);
            int countResVeg = vegCount + labelCount;
            labelCountVeg.Text = countResVeg.ToString();
        }

        private void Btn_Min_Three_Click(object sender, EventArgs e)
        {
            int vegPrice = int.Parse(tbVegetablePrice.Text);
            int vegCount = int.Parse(labelCountVeg.Text);

            if (vegPrice >= veg && vegCount >= labelCount) {
                int vegRes = vegPrice - veg;
                tbVegetablePrice.Text = vegRes.ToString();

                int countResVeg = vegCount - labelCount;
                labelCountVeg.Text = countResVeg.ToString();
            }
        }

        /** button logic for plus and minus at four */
        private void Btn_Plus_Four_Click(object sender, EventArgs e)
        {
            int noodPrice = int.Parse(tbNoodlePrice.Text);
            int noodRes = noodPrice + nood;
            tbNoodlePrice.Text = noodRes.ToString();

            int noodCount = int.Parse(labelCountNood.Text);
            int countResNood = noodCount + labelCount;
            labelCountNood.Text = countResNood.ToString();
        }

        private void Btn_Min_Four_Click(object sender, EventArgs e)
        {
            int noodPrice = int.Parse(tbNoodlePrice.Text);
            int noodCount = int.Parse(labelCountNood.Text);

            if (noodPrice >= chick && noodCount >= labelCount)
            {
                int noodRes = noodPrice - nood;
                tbNoodlePrice.Text = noodRes.ToString();

                int countResNood = noodCount - labelCount;
                labelCountNood.Text = countResNood.ToString();
            }
        }
    }
}