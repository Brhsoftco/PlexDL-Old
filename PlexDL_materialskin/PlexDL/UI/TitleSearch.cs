using PlexDL.Common.Structures;
using System;
using System.Data;
using System.Windows.Forms;

namespace PlexDL.UI
{
    public partial class frmSearch : Form
    {
        public SearchOptions SearchContext = new SearchOptions();

        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtSearchTerm.Text == "") || (cbxSearchColumn.SelectedItem.ToString() == ""))
                {
                    MessageBox.Show("Please enter required values or exit search", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void populateColumns()
        {
            cbxSearchColumn.Items.Clear();
            foreach (DataColumn column in SearchContext.SearchCollection.Columns)
            {
                cbxSearchColumn.Items.Add(column.ColumnName);
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            populateColumns();
        }

        public static SearchOptions ShowSearch(SearchOptions settings)
        {
            frmSearch frm = new frmSearch();
            frm.SearchContext = settings;
            SearchOptions result = new SearchOptions();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                result.SearchColumn = frm.cbxSearchColumn.SelectedItem.ToString();
                result.SearchTerm = frm.txtSearchTerm.Text;
                return result;
            }
            return result;
        }
    }
}