namespace kaktuszGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGVLoad();
        }

        private void DGVLoad()
        {
            DGV.Rows.Clear();
            db db = new db("SELECT * FROM novenytermesztes");
            while (db.Dr.Read())
            {
                DGV.Rows.Add(db.Dr[1], (int)db.Dr[3] == 1 ? "Könnyû" : (int)db.Dr[3] == 2 ? "Mérsékelt" : "Nehéz", $"{db.Dr[4]} ml/h", $"{db.Dr[5]} lm", db.Dr[2]);
            }
        }
        private void DGVLoad(string input)
        {
            DGV.Rows.Clear();
            db db = new db($"SELECT * FROM novenytermesztes WHERE nev LIKE '%{input}%'");
            while (db.Dr.Read())
            {
                DGV.Rows.Add(db.Dr[1], (int)db.Dr[3] == 1 ? "Könnyû" : (int)db.Dr[3] == 2 ? "Mérsékelt" : "Nehéz", $"{db.Dr[4]} ml/h", $"{db.Dr[5]} lm", db.Dr[2]);
            }
        }

        private void tb_keres_TextChanged(object sender, EventArgs e)
        {
            if (tb_keres.TextLength > 0)
            {
                DGVLoad(tb_keres.Text);
            }
            else
            {
                DGVLoad();
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{DGV.Rows[e.RowIndex].Cells[4].Value}", "tudományos név");
        }
    }
}
