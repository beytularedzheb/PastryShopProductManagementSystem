﻿namespace PastryShopProductManagementSystem.CustomControls
{
    using System;
    using System.Windows.Forms;

    public class DataGridViewNumericUpDownColumn : DataGridViewColumn
    {
        public DataGridViewNumericUpDownColumn() : base(new NumericUpDownCell())
        {
        }

        public DataGridViewNumericUpDownColumn(DataGridViewCell cell) : base(cell)
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }

            set
            {
                // Ensure that the cell used for the template is a NumericUpDownCell.
                if ((value != null) && !value.GetType().IsAssignableFrom(typeof(NumericUpDownCell)))
                {
                    throw new InvalidCastException("Must be a NumericUpDownCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    /// <summary>
    /// An auxilary class to NumericUpDownColumn that carries out the cell editing.
    /// </summary>
    public class NumericUpDownCell : DataGridViewTextBoxCell
    {
        public NumericUpDownCell()
        {
            this.Style.Format = "0.#######";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            NumericUpDownEditingControl ctl = (NumericUpDownEditingControl)DataGridView.EditingControl;
            ctl.Value = Convert.ToDecimal(this.Value);
        }

        public override Type EditType
        {
            // Return the type of the editing contol that NumericUpDownCell uses.
            get { return typeof(NumericUpDownEditingControl); }
        }

        public override Type ValueType
        {
            // Return the type of the value that NumericUpDownCell contains.
            get { return typeof(decimal); }
        }

        public override object DefaultNewRowValue
        {
            // Default value for a newly added row in the grid
            get { return 0m; }
        }
    }

    /// <summary>
    /// An auxilary class to NumericUpDownColumn that supplies the appropriate overridden interfaces to the normal NumericUpDown control.
    /// </summary>
    class NumericUpDownEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNum;

        public NumericUpDownEditingControl()
        {
            this.Minimum = 0m;
            this.Maximum = 9999999999m;
            this.DecimalPlaces = 7;
            this.Value = 0m;
        }

        virtual public object EditingControlFormattedValue
        {
            get { return this.Value.ToString(); }

            set
            {
                if (value is int)
                {
                    this.Value = int.Parse(value.ToString());
                }
                else if (value is decimal || value is string)
                {
                    this.Value = decimal.Parse(value.ToString());
                }
            }
        }

        virtual public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get { return rowIndexNum; }
            set { rowIndexNum = value; }
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        public DataGridView EditingControlDataGridView
        {
            get { return dataGridViewControl; }
            set { dataGridViewControl = value; }
        }

        public bool EditingControlValueChanged
        {
            get { return valueIsChanged; }
            set { valueIsChanged = value; }
        }

        public Cursor EditingControlCursor
        {
            get { return base.Cursor; }
        }

        Cursor IDataGridViewEditingControl.EditingPanelCursor
        {
            get { return EditingControlCursor; }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            // Notify the DataGridView that the contents of the cell have changed.
            valueIsChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
