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

        public bool IsTransferBeforeFiveYears()
        {


            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = dp_CR_first_reg_date.Value.Date;

            TimeSpan ts = d1 - d2;

            int days = ts.Days;
            int daysPerYear = 365;
            int noOfYears = 5;
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



        public class Utilities
        {


            void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }


        private void RMVMain_Load(object sender, EventArgs e)
        {
            //Restric the user to select future dates in below datepickers
            dp_CR_last_printed_date.MaxDate = DateTime.Now;
            dp_CR_first_reg_date.MaxDate = DateTime.Now;

            //Handling minum date to select (8 years to backdated from today)
            dp_CR_first_reg_date.MinDate = DateTime.Today.AddYears(-8);
            dp_CR_last_printed_date.MinDate = DateTime.Today.AddYears(-8);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checking whether 6 months completed from last printed date and output to label
            bool resultMonths = IsSixMonthCompleted();

            if (resultMonths)
            {
                lb_sixmonth.Text = "6 Months Completed";

            }
            else
            {
                lb_sixmonth.Text = "6 Months Not Completed From Last Transfer";
            }

            //checking whether 7 years completed from CR first registered date and output to label

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
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Are you sure", "RMV CHARGE CALCULATOR",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RMV CHARGE CALCULATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        double isAbsoulteOwnerFee = 2500.00;
        double isAbsoulteOwnerDeletion = 1300.00;
        double isMortgageFee = 450.00;
        double isMortgageFeeDeletion = 550.00;
        double isOneDayService = 1400.00;
        double isProviceChange = 3300.00;

        double sixMonthNotCompletedFeeMotorCar = 7000.00;
        double sixMonthNotCompletedFeeMotorCoach = 6000.00;
        double sixMonthNotCompletedFeeMotorBus = 6000.00;
        double sixMonthNotCompletedFeeDPVehicle = 6000.00;

        double isDuplicatedCR = 15000.00;
        double isDuplicatedCRDualPurpose = 10000.00;
        double isDuplicatedCRMotorCoach = 10000.00;
        double isDuplicatedCRMotorBus = 10000.00;

        int noOfPreOwnersForTax = 0;


        double transferSaleTax = 3000.00;

        double isPerTransferCharge = 3750.00;
        double isPerTransferChargeMotorBus = 3750.00;
        double isPerTransferChargeMotorLorry = 3750.00;
        double isPerTransferChargeDPVehicle = 3750.00;
        double isPerTransferChargeMotorTractor = 2250.00;
        double isPerTransferChargeMotorThreeWheeler = 1150.00;





        double isWHT = 1000.00;

        double totalRMV;








        private void bt_calculate_RMV_Click(object sender, EventArgs e)
        {

            double total = 0;
            double totalTransferFee = 0;

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
                                if (cb_vehicle_category.Text == "Motor Car")
                                {
                                    total = total + isDuplicatedCR;
                                }
                                else if (cb_vehicle_category.Text == "Motor Bus")
                                {
                                    total = total + isDuplicatedCRMotorBus;
                                }
                                else if (cb_vehicle_category.Text == "Dual Purpose Vehicle")
                                {
                                    total = total + isDuplicatedCRDualPurpose;
                                }
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
                    if (cb_vehicle_category.Text == "Motor Car")
                    {
                        total = total + sixMonthNotCompletedFeeMotorCar;
                    }
                    else if (cb_vehicle_category.Text == "Motor Bus")
                    {
                        total = total + sixMonthNotCompletedFeeMotorBus;
                    }
                    else if (cb_vehicle_category.Text == "Dual Purpose Vehicle")
                    {
                        total = total + sixMonthNotCompletedFeeDPVehicle;
                    }

                }
                else
                {
                    //total += total;
                }

                //Calculating Total Transfer Fee Based On user entered no of transfers (Vehicle Type Wise)

                if (cb_vehicle_category.Text == "Motor Car")
                {
                    totalTransferFee = (Convert.ToDouble(tb_no_of_transfers.Text)) * isPerTransferCharge;
                    total = total + totalTransferFee;
                }

                if (cb_vehicle_category.Text == "Motor Bus")
                {
                    totalTransferFee = (Convert.ToDouble(tb_no_of_transfers.Text)) * isPerTransferChargeMotorBus;
                    total = total + totalTransferFee;
                }

                if (cb_vehicle_category.Text == "Dual Purpose Vehicle")
                {
                    totalTransferFee = (Convert.ToDouble(tb_no_of_transfers.Text)) * isPerTransferChargeDPVehicle;
                    total = total + totalTransferFee;
                }

                if (cb_vehicle_category.Text == "Motor Lorry")
                {
                    totalTransferFee = (Convert.ToDouble(tb_no_of_transfers.Text)) * isPerTransferChargeMotorLorry;
                    total = total + totalTransferFee;
                }

                if (cb_vehicle_category.Text == "Motor Tractor")
                {
                    totalTransferFee = (Convert.ToDouble(tb_no_of_transfers.Text)) * isPerTransferChargeMotorTractor;
                    total = total + totalTransferFee;
                }

                if (cb_vehicle_category.Text == "Motor Three Wheel")
                {
                    totalTransferFee = (Convert.ToDouble(tb_no_of_transfers.Text)) * isPerTransferChargeMotorThreeWheeler;
                    total = total + totalTransferFee;
                }





                //Calculating Whether WHT applicable for the RMV transfer

                bool beforeFive = IsTransferBeforeFiveYears();
                if (!beforeFive && tb_no_of_transfers.Text == "1")
                {
                    if (cb_vehicle_category.Text == "Motor Car" || cb_vehicle_category.Text == "Dual Purpose Vehicle" || cb_vehicle_category.Text == "Motor Tractor")
                    {
                        total = total + isWHT;
                    }
                }


                //Calculting Transfer Sale Tax Only For Motor Car Category

                bool sevenyears = IsSevenYearsCompleted();
                if (!sevenyears)
                {
                    if (cb_vehicle_category.Text == "Motor Car" && tb_no_of_prev_owners.Text == "0")
                    {
                        total = total + transferSaleTax;
                    }
                }
                else
                {
                    //total += total;
                }

                //Final RMV Charge to the label

                lb_charge.Text = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void IsAbsoluteOwnerShipChanged(object sender, EventArgs e)
        {

        }
      



        private void bt_reset_Click(object sender, EventArgs e)
        {
            //foreach (var control in this.gb_checkbox_charges.Controls)
            //{
            //    if (control is CheckBox)
            //    {
            //        CheckBox checkBox = (CheckBox)control;
            //        checkBox.Checked = false;
            //        lb_charge.Text = "";
            //    }
            //}

            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("This cannot be undone", "This Action Cannot Undone",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    RMVMain NewForm = new RMVMain();
                    NewForm.Show();
                    this.Dispose(false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RMV CHARGE CALCULATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        private void dp_CR_last_printed_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dp_CR_first_reg_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_no_of_transfers_KeyPress(object sender, KeyPressEventArgs e)
        {

            //restrict the user to enter the charcters in the text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -0))
            {
                e.Handled = true;
            }
        }

        private void tb_no_of_prev_owners_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Restric the user to enter charcters in the tex box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -0))
            {
                e.Handled = true;
            }
        }
    }
}
