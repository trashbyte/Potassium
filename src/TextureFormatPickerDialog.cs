using LibGC.Texture;
using LibGC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Potassium
{
    /// <summary>
    /// Offers the user to pick one of the given GcTextureFormats from the list.
    /// After showing the dialog, use DialogResult (OK/Cancel) to determine the choice of the user.
    /// </summary>
    public partial class GcTextureFormatPickerDialog : Form
    {
        /// <summary>
        /// Get the currently selected GcTextureFormat.
        /// </summary>
        public GcTextureFormat SelectedFormat
        {
            get
            {
                return (GcTextureFormat)cmbFormat.SelectedValue;
            }
        }

        /// <summary>
        /// Create a new GcTextureFormat picker dialog.
        /// </summary>
        /// <param name="availableFormats">The choices to make available to the user.</param>
        /// <param name="defaultFormat">The default format to be selected by the picker.</param>
        public GcTextureFormatPickerDialog(IEnumerable<GcTextureFormat> availableFormats, GcTextureFormat defaultFormat)
        {
            if (availableFormats == null)
                throw new ArgumentNullException("availableFormats");
            if (!availableFormats.Contains(defaultFormat))
                throw new ArgumentOutOfRangeException("defaultFormat", "Default format not in list of available formats.");

            InitializeComponent();

            // Populate the format combobox from the available formats
            cmbFormat.ValueMember = "Key";
            cmbFormat.DisplayMember = "Value";
            cmbFormat.DataSource = new BindingSource(availableFormats
                .Select(g => new { Key = g, Value = string.Format("{0} ({1})", g, EnumUtils.GetEnumDescription(g)) }).ToArray(), null);

            // Select the default format given
            cmbFormat.SelectedValue = defaultFormat;
        }
    }
}
