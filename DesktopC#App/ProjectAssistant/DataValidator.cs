using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant
{
    internal class DataValidator
    {
        public static bool isTextBoxFilled(TextBox tb)
        {
            if (!tb.Enabled)
            {
                return true;
            }
            else if (!string.IsNullOrWhiteSpace(tb.Text)) {
                return true;
            }
            else {
                tb.BackColor = System.Drawing.Color.LightCoral;
                MessageBox.Show("Please fill in the required field: " + tb.PlaceholderText, "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static bool isComboBoxSelected(ComboBox cb)
        {
            if (!cb.Enabled)
            {
                return true;
            }
            else if (cb.SelectedIndex > 0)
            {
                return true;
            }
            else
            {
                cb.BackColor = System.Drawing.Color.LightCoral;
                MessageBox.Show("Please select an option from the dropdown: " + cb.Name, "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static bool isCheckedListBoxChecked(CheckedListBox clb)
        {
            if (!clb.Enabled)
            {
                return true;
            }
            else if (clb.CheckedItems.Count > 0)
            {
                return true;
            }
            else
            {
                clb.BackColor = System.Drawing.Color.LightCoral;
                MessageBox.Show("Please select at least one option from the list: " + clb.Name, "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static bool validateControls(Control container)
        {
            if (container.HasChildren)
            {
                foreach (Control child in container.Controls)
                {
                    if (!validateControls(child))
                    {
                        return false;
                    }
                }
                return true;
            }
            else if(container is TextBox) { 
                return isTextBoxFilled((TextBox)container);
            }
            else if(container is ComboBox) {
                return isComboBoxSelected((ComboBox)container);
            }
            else if(container is CheckedListBox) {
                return isCheckedListBoxChecked((CheckedListBox)container);
            }
            else {
                return true;
            }
        }
    }
}
