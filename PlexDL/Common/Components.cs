using System.Windows.Forms;

namespace PlexDL.Components
{
    public class FlatDataGridView : DataGridView
    {
        public string RowsEmptyText { get; set; } = "No Data Found";

        public FlatDataGridView()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Paint += new PaintEventHandler(this.DGVPaint);
            this.ColumnHeadersDefaultCellStyle = new FlatDGVColumnHeaderStyle();
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DefaultCellStyle = new FlatDGVCellStyle();
            this.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EnableHeadersVisualStyles = false;
            this.MultiSelect = false;
            this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RowHeadersVisible = false;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        public void DGVPaint(object sender, PaintEventArgs e)
        {
            if (this.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, RowsEmptyText,
                    this.Font, this.ClientRectangle,
                    this.ForeColor, this.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }

    public class FlatDGVCellStyle : DataGridViewCellStyle
    {
        public FlatDGVCellStyle()
        {
            this.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        }
    }

    public class FlatDGVColumnHeaderStyle : DataGridViewCellStyle
    {
        public FlatDGVColumnHeaderStyle()
        {
            this.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.SelectionForeColor = System.Drawing.Color.White;
            this.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        }
    }
}