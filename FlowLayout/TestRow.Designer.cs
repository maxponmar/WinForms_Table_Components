
namespace FlowLayout
{
    partial class TestRow
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
            this.ID = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.MeasurementUnit = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.LSL = new System.Windows.Forms.TextBox();
            this.USL = new System.Windows.Forms.TextBox();
            this.AttributeDescription = new System.Windows.Forms.TextBox();
            this.Details_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(0, 0);
            this.ID.Margin = new System.Windows.Forms.Padding(0);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 0;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ID.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(99, 0);
            this.Description.Margin = new System.Windows.Forms.Padding(0);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(158, 20);
            this.Description.TabIndex = 1;
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Description.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // MeasurementUnit
            // 
            this.MeasurementUnit.Location = new System.Drawing.Point(832, 0);
            this.MeasurementUnit.Margin = new System.Windows.Forms.Padding(0);
            this.MeasurementUnit.Name = "MeasurementUnit";
            this.MeasurementUnit.ReadOnly = true;
            this.MeasurementUnit.Size = new System.Drawing.Size(54, 20);
            this.MeasurementUnit.TabIndex = 2;
            this.MeasurementUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MeasurementUnit.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(256, 0);
            this.Value.Margin = new System.Windows.Forms.Padding(0);
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Size = new System.Drawing.Size(193, 20);
            this.Value.TabIndex = 3;
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // LSL
            // 
            this.LSL.Location = new System.Drawing.Point(448, 0);
            this.LSL.Margin = new System.Windows.Forms.Padding(0);
            this.LSL.Name = "LSL";
            this.LSL.ReadOnly = true;
            this.LSL.Size = new System.Drawing.Size(193, 20);
            this.LSL.TabIndex = 4;
            this.LSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LSL.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // USL
            // 
            this.USL.Location = new System.Drawing.Point(640, 0);
            this.USL.Margin = new System.Windows.Forms.Padding(0);
            this.USL.Name = "USL";
            this.USL.ReadOnly = true;
            this.USL.Size = new System.Drawing.Size(193, 20);
            this.USL.TabIndex = 5;
            this.USL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.USL.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // AttributeDescription
            // 
            this.AttributeDescription.Location = new System.Drawing.Point(99, 19);
            this.AttributeDescription.Margin = new System.Windows.Forms.Padding(0);
            this.AttributeDescription.Name = "AttributeDescription";
            this.AttributeDescription.ReadOnly = true;
            this.AttributeDescription.Size = new System.Drawing.Size(787, 20);
            this.AttributeDescription.TabIndex = 6;
            this.AttributeDescription.Click += new System.EventHandler(this.CopyTextboxToClipboard);
            // 
            // Details_Label
            // 
            this.Details_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Details_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details_Label.Location = new System.Drawing.Point(0, 20);
            this.Details_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Details_Label.Name = "Details_Label";
            this.Details_Label.Size = new System.Drawing.Size(99, 19);
            this.Details_Label.TabIndex = 7;
            this.Details_Label.Text = "Details ->";
            this.Details_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Details_Label);
            this.Controls.Add(this.AttributeDescription);
            this.Controls.Add(this.USL);
            this.Controls.Add(this.LSL);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.MeasurementUnit);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ID);
            this.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Name = "TestRow";
            this.Size = new System.Drawing.Size(886, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox MeasurementUnit;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox LSL;
        private System.Windows.Forms.TextBox USL;
        private System.Windows.Forms.TextBox AttributeDescription;
        private System.Windows.Forms.Label Details_Label;
    }
}
