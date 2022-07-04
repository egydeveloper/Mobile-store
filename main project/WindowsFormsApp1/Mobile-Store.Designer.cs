namespace main
{
    partial class Mobile_Store
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
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.container = new System.Windows.Forms.Panel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mob = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.cust = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.bill = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mobdash = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accessdash = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.custdash = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Bills = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.container);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(250, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(441, 442);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // container
            // 
            this.container.AutoSize = true;
            this.container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(441, 442);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mob,
            this.acc,
            this.cust,
            this.bill,
            this.accordionControlElement5});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(250, 442);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mob
            // 
            this.mob.Name = "mob";
            this.mob.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mob.Text = "Mobiles";
            this.mob.Click += new System.EventHandler(this.Mob_Click);
            // 
            // acc
            // 
            this.acc.Name = "acc";
            this.acc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acc.Text = "Accessories";
            this.acc.Click += new System.EventHandler(this.Acc_Click);
            // 
            // cust
            // 
            this.cust.Name = "cust";
            this.cust.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.cust.Text = "Customers";
            this.cust.Click += new System.EventHandler(this.Cust_Click);
            // 
            // bill
            // 
            this.bill.Name = "bill";
            this.bill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.bill.Text = "Bills";
            this.bill.Click += new System.EventHandler(this.AccordionControlElement4_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mobdash,
            this.accessdash,
            this.custdash,
            this.Bills});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Dashboard";
            // 
            // mobdash
            // 
            this.mobdash.Name = "mobdash";
            this.mobdash.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mobdash.Text = "Mobiles Detailes";
            this.mobdash.Click += new System.EventHandler(this.Mobdash_Click);
            // 
            // accessdash
            // 
            this.accessdash.Name = "accessdash";
            this.accessdash.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accessdash.Text = "Accessories Detailes";
            this.accessdash.Click += new System.EventHandler(this.Accessdash_Click);
            // 
            // custdash
            // 
            this.custdash.Name = "custdash";
            this.custdash.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.custdash.Text = "Customers Detailes";
            this.custdash.Click += new System.EventHandler(this.Custdash_Click);
            // 
            // Bills
            // 
            this.Bills.Name = "Bills";
            this.Bills.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Bills.Text = "Bills Detailes";
            this.Bills.Click += new System.EventHandler(this.Bills_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // Mobile_Store
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Mobile_Store";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Mobile_Store";
            this.Load += new System.EventHandler(this.Mobile_Store_Load);
            this.Resize += new System.EventHandler(this.Mobile_Store_Resize);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mob;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement cust;
        private DevExpress.XtraBars.Navigation.AccordionControlElement bill;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mobdash;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accessdash;
        private DevExpress.XtraBars.Navigation.AccordionControlElement custdash;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Bills;
        private System.Windows.Forms.Panel container;
    }
}