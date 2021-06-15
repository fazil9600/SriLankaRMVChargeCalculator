
namespace SriLankaRMVCalculator
{
    partial class RMVMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_years = new System.Windows.Forms.Label();
            this.lb_sixmonth = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_print_now = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_generate_print = new System.Windows.Forms.Button();
            this.bt_calculate_RMV = new System.Windows.Forms.Button();
            this.chb_is_one_day_service = new System.Windows.Forms.CheckBox();
            this.chb_is_province_change = new System.Windows.Forms.CheckBox();
            this.chb_is_dup_CR = new System.Windows.Forms.CheckBox();
            this.chb_is_mt_deletion = new System.Windows.Forms.CheckBox();
            this.chb_is_ab_deletion = new System.Windows.Forms.CheckBox();
            this.chb_is_mortageg = new System.Windows.Forms.CheckBox();
            this.chb_is_absolute_ownership = new System.Windows.Forms.CheckBox();
            this.tb_print_screen = new System.Windows.Forms.TextBox();
            this.tb_no_of_transfers = new System.Windows.Forms.TextBox();
            this.tb_no_of_prev_owners = new System.Windows.Forms.TextBox();
            this.dp_CR_last_printed_date = new System.Windows.Forms.DateTimePicker();
            this.dp_CR_first_reg_date = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_process_first = new System.Windows.Forms.Button();
            this.tb_vehicle_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_transfer_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_vehicle_category = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_charge = new System.Windows.Forms.Label();
            this.gb_checkbox_charges = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.gb_checkbox_charges.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(7, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(838, 13);
            this.panel4.TabIndex = 49;
            // 
            // lb_years
            // 
            this.lb_years.AutoSize = true;
            this.lb_years.ForeColor = System.Drawing.Color.Red;
            this.lb_years.Location = new System.Drawing.Point(195, 332);
            this.lb_years.Name = "lb_years";
            this.lb_years.Size = new System.Drawing.Size(34, 15);
            this.lb_years.TabIndex = 48;
            this.lb_years.Text = "Years";
            // 
            // lb_sixmonth
            // 
            this.lb_sixmonth.AutoSize = true;
            this.lb_sixmonth.ForeColor = System.Drawing.Color.Red;
            this.lb_sixmonth.Location = new System.Drawing.Point(645, 332);
            this.lb_sixmonth.Name = "lb_sixmonth";
            this.lb_sixmonth.Size = new System.Drawing.Size(48, 15);
            this.lb_sixmonth.TabIndex = 47;
            this.lb_sixmonth.Text = "Months";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(1256, 37);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(77, 28);
            this.bt_exit.TabIndex = 42;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_print_now
            // 
            this.bt_print_now.Location = new System.Drawing.Point(1176, 649);
            this.bt_print_now.Name = "bt_print_now";
            this.bt_print_now.Size = new System.Drawing.Size(116, 39);
            this.bt_print_now.TabIndex = 43;
            this.bt_print_now.Text = "PRINT NOW";
            this.bt_print_now.UseVisualStyleBackColor = true;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(153, 645);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(116, 39);
            this.bt_reset.TabIndex = 46;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = true;
            // 
            // bt_generate_print
            // 
            this.bt_generate_print.Location = new System.Drawing.Point(1037, 649);
            this.bt_generate_print.Name = "bt_generate_print";
            this.bt_generate_print.Size = new System.Drawing.Size(116, 39);
            this.bt_generate_print.TabIndex = 44;
            this.bt_generate_print.Text = "GENERATE PRINT";
            this.bt_generate_print.UseVisualStyleBackColor = true;
            // 
            // bt_calculate_RMV
            // 
            this.bt_calculate_RMV.Location = new System.Drawing.Point(7, 645);
            this.bt_calculate_RMV.Name = "bt_calculate_RMV";
            this.bt_calculate_RMV.Size = new System.Drawing.Size(116, 39);
            this.bt_calculate_RMV.TabIndex = 45;
            this.bt_calculate_RMV.Text = "CALCULATE RMV";
            this.bt_calculate_RMV.UseVisualStyleBackColor = true;
            this.bt_calculate_RMV.Click += new System.EventHandler(this.bt_calculate_RMV_Click);
            // 
            // chb_is_one_day_service
            // 
            this.chb_is_one_day_service.AutoSize = true;
            this.chb_is_one_day_service.Location = new System.Drawing.Point(6, 149);
            this.chb_is_one_day_service.Name = "chb_is_one_day_service";
            this.chb_is_one_day_service.Size = new System.Drawing.Size(122, 19);
            this.chb_is_one_day_service.TabIndex = 41;
            this.chb_is_one_day_service.Text = "Is One Day Service";
            this.chb_is_one_day_service.UseVisualStyleBackColor = true;
            // 
            // chb_is_province_change
            // 
            this.chb_is_province_change.AutoSize = true;
            this.chb_is_province_change.Location = new System.Drawing.Point(168, 111);
            this.chb_is_province_change.Name = "chb_is_province_change";
            this.chb_is_province_change.Size = new System.Drawing.Size(127, 19);
            this.chb_is_province_change.TabIndex = 40;
            this.chb_is_province_change.Text = "Is Province Change";
            this.chb_is_province_change.UseVisualStyleBackColor = true;
            // 
            // chb_is_dup_CR
            // 
            this.chb_is_dup_CR.AutoSize = true;
            this.chb_is_dup_CR.Location = new System.Drawing.Point(6, 111);
            this.chb_is_dup_CR.Name = "chb_is_dup_CR";
            this.chb_is_dup_CR.Size = new System.Drawing.Size(112, 19);
            this.chb_is_dup_CR.TabIndex = 39;
            this.chb_is_dup_CR.Text = "Is Duplicated CR";
            this.chb_is_dup_CR.UseVisualStyleBackColor = true;
            // 
            // chb_is_mt_deletion
            // 
            this.chb_is_mt_deletion.AutoSize = true;
            this.chb_is_mt_deletion.Location = new System.Drawing.Point(168, 72);
            this.chb_is_mt_deletion.Name = "chb_is_mt_deletion";
            this.chb_is_mt_deletion.Size = new System.Drawing.Size(136, 19);
            this.chb_is_mt_deletion.TabIndex = 38;
            this.chb_is_mt_deletion.Text = "Is Mortgage Deletion";
            this.chb_is_mt_deletion.UseVisualStyleBackColor = true;
            // 
            // chb_is_ab_deletion
            // 
            this.chb_is_ab_deletion.AutoSize = true;
            this.chb_is_ab_deletion.Location = new System.Drawing.Point(168, 35);
            this.chb_is_ab_deletion.Name = "chb_is_ab_deletion";
            this.chb_is_ab_deletion.Size = new System.Drawing.Size(198, 19);
            this.chb_is_ab_deletion.TabIndex = 37;
            this.chb_is_ab_deletion.Text = "Is Absoulute Ownership Deletion";
            this.chb_is_ab_deletion.UseVisualStyleBackColor = true;
            // 
            // chb_is_mortageg
            // 
            this.chb_is_mortageg.AutoSize = true;
            this.chb_is_mortageg.Location = new System.Drawing.Point(6, 72);
            this.chb_is_mortageg.Name = "chb_is_mortageg";
            this.chb_is_mortageg.Size = new System.Drawing.Size(89, 19);
            this.chb_is_mortageg.TabIndex = 36;
            this.chb_is_mortageg.Text = "Is Mortgage";
            this.chb_is_mortageg.UseVisualStyleBackColor = true;
            // 
            // chb_is_absolute_ownership
            // 
            this.chb_is_absolute_ownership.AutoSize = true;
            this.chb_is_absolute_ownership.Location = new System.Drawing.Point(6, 35);
            this.chb_is_absolute_ownership.Name = "chb_is_absolute_ownership";
            this.chb_is_absolute_ownership.Size = new System.Drawing.Size(151, 19);
            this.chb_is_absolute_ownership.TabIndex = 35;
            this.chb_is_absolute_ownership.Text = "Is Absoulute Ownership";
            this.chb_is_absolute_ownership.UseVisualStyleBackColor = true;
            this.chb_is_absolute_ownership.CheckedChanged += new System.EventHandler(this.IsAbsoluteOwnerShipChanged);
            // 
            // tb_print_screen
            // 
            this.tb_print_screen.Location = new System.Drawing.Point(984, 214);
            this.tb_print_screen.Multiline = true;
            this.tb_print_screen.Name = "tb_print_screen";
            this.tb_print_screen.Size = new System.Drawing.Size(339, 429);
            this.tb_print_screen.TabIndex = 34;
            // 
            // tb_no_of_transfers
            // 
            this.tb_no_of_transfers.Location = new System.Drawing.Point(645, 368);
            this.tb_no_of_transfers.Name = "tb_no_of_transfers";
            this.tb_no_of_transfers.Size = new System.Drawing.Size(200, 23);
            this.tb_no_of_transfers.TabIndex = 33;
            this.tb_no_of_transfers.Text = "0";
            // 
            // tb_no_of_prev_owners
            // 
            this.tb_no_of_prev_owners.Location = new System.Drawing.Point(195, 364);
            this.tb_no_of_prev_owners.Name = "tb_no_of_prev_owners";
            this.tb_no_of_prev_owners.Size = new System.Drawing.Size(200, 23);
            this.tb_no_of_prev_owners.TabIndex = 32;
            this.tb_no_of_prev_owners.Text = "0";
            // 
            // dp_CR_last_printed_date
            // 
            this.dp_CR_last_printed_date.Location = new System.Drawing.Point(645, 306);
            this.dp_CR_last_printed_date.Name = "dp_CR_last_printed_date";
            this.dp_CR_last_printed_date.Size = new System.Drawing.Size(200, 23);
            this.dp_CR_last_printed_date.TabIndex = 31;
            // 
            // dp_CR_first_reg_date
            // 
            this.dp_CR_first_reg_date.Location = new System.Drawing.Point(195, 308);
            this.dp_CR_first_reg_date.Name = "dp_CR_first_reg_date";
            this.dp_CR_first_reg_date.Size = new System.Drawing.Size(200, 23);
            this.dp_CR_first_reg_date.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(7, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 10);
            this.panel3.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(7, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 10);
            this.panel2.TabIndex = 28;
            // 
            // bt_process_first
            // 
            this.bt_process_first.Location = new System.Drawing.Point(678, 185);
            this.bt_process_first.Name = "bt_process_first";
            this.bt_process_first.Size = new System.Drawing.Size(75, 23);
            this.bt_process_first.TabIndex = 27;
            this.bt_process_first.Text = ">";
            this.bt_process_first.UseVisualStyleBackColor = true;
            // 
            // tb_vehicle_number
            // 
            this.tb_vehicle_number.Location = new System.Drawing.Point(465, 185);
            this.tb_vehicle_number.Name = "tb_vehicle_number";
            this.tb_vehicle_number.Size = new System.Drawing.Size(182, 23);
            this.tb_vehicle_number.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1068, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "PRINT RMV CHARGES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(316, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Vehicle Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(465, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "No Of Transfers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(465, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "CR Last Printed Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "No Of Previous Owners";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "CR First Registred Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Transfer Type";
            // 
            // cb_transfer_type
            // 
            this.cb_transfer_type.FormattingEnabled = true;
            this.cb_transfer_type.Items.AddRange(new object[] {
            "Transfering Vehicle",
            "Non Transfering Vehicle"});
            this.cb_transfer_type.Location = new System.Drawing.Point(153, 254);
            this.cb_transfer_type.Name = "cb_transfer_type";
            this.cb_transfer_type.Size = new System.Drawing.Size(121, 23);
            this.cb_transfer_type.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vehicle Category";
            // 
            // cb_vehicle_category
            // 
            this.cb_vehicle_category.FormattingEnabled = true;
            this.cb_vehicle_category.Items.AddRange(new object[] {
            "Motor Car",
            "Motor Coach",
            "Motor Lorry",
            "Motor Three Wheel",
            "Motor Cycle"});
            this.cb_vehicle_category.Location = new System.Drawing.Point(153, 185);
            this.cb_vehicle_category.Name = "cb_vehicle_category";
            this.cb_vehicle_category.Size = new System.Drawing.Size(121, 23);
            this.cb_vehicle_category.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(247, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 93);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "SRI LANKA RMV CHARGES CALCULATOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(598, 611);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 32);
            this.label10.TabIndex = 51;
            this.label10.Text = "Total RMV Charge";
            // 
            // lb_charge
            // 
            this.lb_charge.AutoSize = true;
            this.lb_charge.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_charge.Location = new System.Drawing.Point(852, 611);
            this.lb_charge.Name = "lb_charge";
            this.lb_charge.Size = new System.Drawing.Size(0, 32);
            this.lb_charge.TabIndex = 51;
            // 
            // gb_checkbox_charges
            // 
            this.gb_checkbox_charges.Controls.Add(this.chb_is_absolute_ownership);
            this.gb_checkbox_charges.Controls.Add(this.chb_is_mortageg);
            this.gb_checkbox_charges.Controls.Add(this.chb_is_ab_deletion);
            this.gb_checkbox_charges.Controls.Add(this.chb_is_mt_deletion);
            this.gb_checkbox_charges.Controls.Add(this.chb_is_dup_CR);
            this.gb_checkbox_charges.Controls.Add(this.chb_is_province_change);
            this.gb_checkbox_charges.Controls.Add(this.chb_is_one_day_service);
            this.gb_checkbox_charges.Location = new System.Drawing.Point(12, 438);
            this.gb_checkbox_charges.Name = "gb_checkbox_charges";
            this.gb_checkbox_charges.Size = new System.Drawing.Size(463, 201);
            this.gb_checkbox_charges.TabIndex = 52;
            this.gb_checkbox_charges.TabStop = false;
            this.gb_checkbox_charges.Text = "Additional Charges";
            // 
            // RMVMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 725);
            this.Controls.Add(this.gb_checkbox_charges);
            this.Controls.Add(this.lb_charge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lb_years);
            this.Controls.Add(this.lb_sixmonth);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_print_now);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_generate_print);
            this.Controls.Add(this.bt_calculate_RMV);
            this.Controls.Add(this.tb_print_screen);
            this.Controls.Add(this.tb_no_of_transfers);
            this.Controls.Add(this.tb_no_of_prev_owners);
            this.Controls.Add(this.dp_CR_last_printed_date);
            this.Controls.Add(this.dp_CR_first_reg_date);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_process_first);
            this.Controls.Add(this.tb_vehicle_number);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_transfer_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_vehicle_category);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RMVMain";
            this.Text = "RMVMain";
            this.Load += new System.EventHandler(this.RMVMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_checkbox_charges.ResumeLayout(false);
            this.gb_checkbox_charges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_years;
        private System.Windows.Forms.Label lb_sixmonth;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_print_now;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_generate_print;
        private System.Windows.Forms.Button bt_calculate_RMV;
        private System.Windows.Forms.CheckBox chb_is_one_day_service;
        private System.Windows.Forms.CheckBox chb_is_province_change;
        private System.Windows.Forms.CheckBox chb_is_dup_CR;
        private System.Windows.Forms.CheckBox chb_is_mt_deletion;
        private System.Windows.Forms.CheckBox chb_is_ab_deletion;
        private System.Windows.Forms.CheckBox chb_is_mortageg;
        private System.Windows.Forms.CheckBox chb_is_absolute_ownership;
        private System.Windows.Forms.TextBox tb_print_screen;
        private System.Windows.Forms.TextBox tb_no_of_transfers;
        private System.Windows.Forms.TextBox tb_no_of_prev_owners;
        private System.Windows.Forms.DateTimePicker dp_CR_last_printed_date;
        private System.Windows.Forms.DateTimePicker dp_CR_first_reg_date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_process_first;
        private System.Windows.Forms.TextBox tb_vehicle_number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_transfer_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_vehicle_category;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_charge;
        private System.Windows.Forms.GroupBox gb_checkbox_charges;
    }
}