
namespace FlowLayout
{
    partial class TestGroupRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result_Textbox = new System.Windows.Forms.TextBox();
            this.Date_Textbox = new System.Windows.Forms.TextBox();
            this.Type_Textbox = new System.Windows.Forms.TextBox();
            this.Station_Textbox = new System.Windows.Forms.TextBox();
            this.TestPlanName_Textbox = new System.Windows.Forms.TextBox();
            this.MaterialNumber_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Result_Textbox
            // 
            this.Result_Textbox.Location = new System.Drawing.Point(0, 0);
            this.Result_Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Result_Textbox.Name = "Result_Textbox";
            this.Result_Textbox.Size = new System.Drawing.Size(78, 20);
            this.Result_Textbox.TabIndex = 0;
            this.Result_Textbox.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // Date_Textbox
            // 
            this.Date_Textbox.Location = new System.Drawing.Point(77, 0);
            this.Date_Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Date_Textbox.Name = "Date_Textbox";
            this.Date_Textbox.Size = new System.Drawing.Size(128, 20);
            this.Date_Textbox.TabIndex = 0;
            this.Date_Textbox.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // Type_Textbox
            // 
            this.Type_Textbox.Location = new System.Drawing.Point(203, 0);
            this.Type_Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Type_Textbox.Name = "Type_Textbox";
            this.Type_Textbox.Size = new System.Drawing.Size(192, 20);
            this.Type_Textbox.TabIndex = 0;
            this.Type_Textbox.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // Station_Textbox
            // 
            this.Station_Textbox.Location = new System.Drawing.Point(394, 0);
            this.Station_Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Station_Textbox.Name = "Station_Textbox";
            this.Station_Textbox.Size = new System.Drawing.Size(186, 20);
            this.Station_Textbox.TabIndex = 0;
            this.Station_Textbox.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // TestPlanName_Textbox
            // 
            this.TestPlanName_Textbox.Location = new System.Drawing.Point(579, 0);
            this.TestPlanName_Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.TestPlanName_Textbox.Name = "TestPlanName_Textbox";
            this.TestPlanName_Textbox.Size = new System.Drawing.Size(162, 20);
            this.TestPlanName_Textbox.TabIndex = 0;
            this.TestPlanName_Textbox.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // MaterialNumber_Textbox
            // 
            this.MaterialNumber_Textbox.Location = new System.Drawing.Point(740, 0);
            this.MaterialNumber_Textbox.Margin = new System.Windows.Forms.Padding(0);
            this.MaterialNumber_Textbox.Name = "MaterialNumber_Textbox";
            this.MaterialNumber_Textbox.Size = new System.Drawing.Size(196, 20);
            this.MaterialNumber_Textbox.TabIndex = 0;
            this.MaterialNumber_Textbox.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // TestGroupRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.MaterialNumber_Textbox);
            this.Controls.Add(this.TestPlanName_Textbox);
            this.Controls.Add(this.Station_Textbox);
            this.Controls.Add(this.Type_Textbox);
            this.Controls.Add(this.Date_Textbox);
            this.Controls.Add(this.Result_Textbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TestGroupRow";
            this.Size = new System.Drawing.Size(936, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result_Textbox;
        private System.Windows.Forms.TextBox Date_Textbox;
        private System.Windows.Forms.TextBox Type_Textbox;
        private System.Windows.Forms.TextBox Station_Textbox;
        private System.Windows.Forms.TextBox TestPlanName_Textbox;
        private System.Windows.Forms.TextBox MaterialNumber_Textbox;
    }
}
