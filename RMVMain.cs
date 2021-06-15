using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SriLankaRMVCalculator
{
    public partial class RMVMain : Form
    {
        public RMVMain()
        {
            InitializeComponent();
        }

        public bool IsSixMonthCompleted()
        {


            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = dp_CR_last_printed_date.Value.Date;

            TimeSpan ts = d1 - d2;

            int days = ts.Days;


            if (days >= 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSevenYearsCompleted()
        {


            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = dp_CR_first_reg_date.Value.Date;

            TimeSpan ts = d1 - d2;

            int days = ts.Days;
            int daysPerYear = 365;
            int noOfYears = 7;
            int totalDaysToCalculate = daysPerYear * noOfYears;



            if (days >= totalDaysToCalculate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            private void RMVMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checking whether 6 months completed from last printed date
            bool resultMonths = IsSixMonthCompleted();

            if (resultMonths)
            {
                lb_sixmonth.Text = "6 Months Completed";

            }
            else
            {
                lb_sixmonth.Text = "6 Months Not Completed From Last Transfer";
            }

            //checking whether 7 years completed from CR first registered date

            bool resultYears = IsSevenYearsCompleted();

            if (resultYears)
            {
                lb_years.Text = "7 Years Completed";

            }
            else
            {
                lb_years.Text = "7 Years Not Completed From First Transfer";
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double isAbsoulteOwnerFee = 3800.00;
        double isAbsoulteOwnerDeletion = 4500.00;
        double isMortgageFee = 1800.00;
        double isMortgageFeeDeletion = 800.00;
        double isOneDayService = 3800.00;
        double isDuplicatedCR = 3800.00;
        double isProviceChange = 3800.00;

        double sixMonthNotCompletedFee = 6000.00;
        double transferSaleTax = 7000.00;

        double isPerTransferCharge = 3750.00;
        double isWHT = 1000.00;

        double totalRMV;



        




        private void bt_calculate_RMV_Click(object sender, EventArgs e)
        {
            //if (chb_is_absolute_ownership.Checked == true)
            //{
            //    totalRMV += isAbsoulteOwnerFee;
            //}
            //else
            //{
            //    totalRMV -= isAbsoulteOwnerFee;
            //}

            //if (totalRMV >= 0)
            //{
            //    lb_charge.Text = totalRMV.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid RMV");
            //}

            double total = 0;
            double totalTransferFee = 0;
            double transferSaleTax = 0 ;
            try
            {

                foreach (var control in this.gb_checkbox_charges.Controls)
                {
                    if (control is CheckBox)
                    {
                        if (((CheckBox)control).Checked)
                        {
                            if (((CheckBox)control).Name == "chb_is_absolute_ownership")
                            {
                                total = total + isAbsoulteOwnerFee;
                            }
                            else if (((CheckBox)control).Name == "chb_is_ab_deletion")
                            {
                                total = total + isAbsoulteOwnerDeletion;
                            }
                            else if (((CheckBox)control).Name == "chb_is_mortageg")
                            {
                                total = total + isMortgageFee;
                            }
                            else if (((CheckBox)control).Name == "chb_is_mt_deletion")
                            {
                                total = total + isMortgageFeeDeletion;
                            }
                            else if (((CheckBox)control).Name == "chb_is_dup_CR")
                            {
                                total = total + isDuplicatedCR;
                            }
                            else if (((CheckBox)control).Name == "chb_is_one_day_service")
                            {
                                total = total + isOneDayService;
                            }
                            else if (((CheckBox)control).Name == "chb_is_province_change")
                            {
                                total = total + isProviceChange;
                            }

                        }
                        else
                        {

                        }

                    }
                }
                //Calculating Six Month Not Completed Fee
                bool valueadded = IsSixMonthCompleted();
                if (!valueadded)
                {
                    total = total + sixMonthNotCompletedFee;
                }

                //Calculating Total Transfer Fee Based On user entered no of transfers
                totalTransferFee = (Convert.ToDouble(tb_no_of_transfers.Text)) * isPerTransferCharge;


                //Calculting Transfer Sale Tax Only For Motor Car Category
                //bool sevenyears = IsSevenYearsCompleted();
                //if (!sevenyears)
                //{
                //    if (cb_vehicle_category.SelectedValue.ToString() == "Motor Car")
                //    {
                //        total = total + transferSaleTax;
                //    }
                //}



                //Final RMV Charge
                total = total + sixMonthNotCompletedFee + totalTransferFee;
                lb_charge.Text = total.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void IsAbsoluteOwnerShipChanged(object sender, EventArgs e)
        {

        }
    }
}
