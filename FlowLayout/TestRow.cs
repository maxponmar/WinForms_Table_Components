using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowLayout
{
    public partial class TestRow : UserControl
    {
        public TestRow(string ID, string Description, string Value, string LSL, string USL, string MeasurementUnit, string AttributeDescription)
        {
            InitializeComponent();

            this.ID.Text = ID;
            this.Description.Text = Description;
            this.Value.Text = Value;
            this.LSL.Text = LSL;
            this.USL.Text = USL;
            this.MeasurementUnit.Text = MeasurementUnit;

            if (String.IsNullOrEmpty(AttributeDescription))
                DeactivateAttributeDescription();
            else
                ActivateAttributeDescription(AttributeDescription);
        }

        private void ActivateAttributeDescription(string AttributeDescription)
        {
            this.Size = new Size(886, 38);
            this.AttributeDescription.Visible = true;
            this.AttributeDescription.Enabled = true;
            Details_Label.Visible = true;
            Details_Label.Enabled = true;
            this.AttributeDescription.Text = AttributeDescription;
        }

        private void DeactivateAttributeDescription()
        {
            this.Size = new Size(886, 19);
            this.AttributeDescription.Visible = false;
            this.AttributeDescription.Enabled = false;
            Details_Label.Visible = false;
            Details_Label.Enabled = false;
        }

        private void CopyTextboxToClipboard(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                Clipboard.SetText(textBox.Text);
            }
        }
    }
}
