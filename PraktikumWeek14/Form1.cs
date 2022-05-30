using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "SELECT `team_name`, CONCAT(manager_name , ' (' , nat.nation , ')') as Manager , CONCAT(home_stadium , ', ' , city , ' (' , capacity , ')') as Stadium, concat(`player_name`,'(',(n.jumlah_goal + n.jumlah_goal_penalty),')')as `Top Scorer`, concat(`player_name`,'. ' ,(n.jumlah_kartu_kuning),' Yellow Card and ',n.jumlah_kartu_merah,' Red Card') AS 'Worst Discipline' FROM team t, manager m, nationality nat, dmatch d, dt_Newman n WHERE t.manager_id = m.manager_id and t.team_id = d.team_id AND d.player_id = n.player_id and m.nationality_id = nat.nationality_id AND d.player_id= n.player_id GROUP BY t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            labelTeamName.Text = dt.Rows[0][0].ToString();
            labelManager.Text = dt.Rows[0][1].ToString();
            labelStadium.Text = dt.Rows[0][2].ToString();
            labelTopScorer.Text = dt.Rows[0][3].ToString();
            labelDicipline.Text = dt.Rows[0][4].ToString();

            sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = 'A001' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = 'A001' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dgv = new DataTable();
            sqlAdapter.Fill(dgv);
            dataGridView1.DataSource = dgv;
            dataGridView1.Columns.RemoveAt(0);
        }

        private void buttonLastPrev_Click(object sender, EventArgs e)
        {
            counter = 0;
            sqlQuery = "SELECT `team_name`, CONCAT(manager_name , ' (' , nat.nation , ')') as Manager , CONCAT(home_stadium , ', ' , city , ' (' , capacity , ')') as Stadium, concat(`player_name`,'(',(n.jumlah_goal + n.jumlah_goal_penalty),')')as `Top Scorer`, concat(`player_name`,'. ' ,(n.jumlah_kartu_kuning),' Yellow Card and ',n.jumlah_kartu_merah,' Red Card') AS 'Worst Discipline' FROM team t, manager m, nationality nat, dmatch d, dt_Newman n WHERE t.manager_id = m.manager_id and t.team_id = d.team_id AND d.player_id = n.player_id and m.nationality_id = nat.nationality_id AND d.player_id= n.player_id GROUP BY t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable lastPrev = new DataTable();
            sqlAdapter.Fill(lastPrev);
            labelTeamName.Text = lastPrev.Rows[counter][0].ToString();
            labelManager.Text = lastPrev.Rows[counter][1].ToString();
            labelStadium.Text = lastPrev.Rows[counter][2].ToString();
            labelTopScorer.Text = lastPrev.Rows[counter][3].ToString();
            labelDicipline.Text = lastPrev.Rows[counter][4].ToString();

            sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = 'A001' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = 'A001' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dgv = new DataTable();
            sqlAdapter.Fill(dgv);
            dataGridView1.DataSource = dgv;
            dataGridView1.Columns.RemoveAt(0);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (counter <= 0)
            {
                MessageBox.Show("Sudah data pertama");
            }
            else
            {
                counter--;
                sqlQuery = "SELECT `team_name`, CONCAT(manager_name , ' (' , nat.nation , ')') as Manager , CONCAT(home_stadium , ', ' , city , ' (' , capacity , ')') as Stadium, concat(`player_name`,'(',(n.jumlah_goal + n.jumlah_goal_penalty),')')as `Top Scorer`, concat(`player_name`,'. ' ,(n.jumlah_kartu_kuning),' Yellow Card and ',n.jumlah_kartu_merah,' Red Card') AS 'Worst Discipline' FROM team t, manager m, nationality nat, dmatch d, dt_Newman n WHERE t.manager_id = m.manager_id and t.team_id = d.team_id AND d.player_id = n.player_id and m.nationality_id = nat.nationality_id AND d.player_id= n.player_id GROUP BY t.team_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable lastPrev = new DataTable();
                sqlAdapter.Fill(lastPrev);
                labelTeamName.Text = lastPrev.Rows[counter][0].ToString();
                labelManager.Text = lastPrev.Rows[counter][1].ToString();
                labelStadium.Text = lastPrev.Rows[counter][2].ToString();
                labelTopScorer.Text = lastPrev.Rows[counter][3].ToString();
                labelDicipline.Text = lastPrev.Rows[counter][4].ToString();

                sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = 'A001' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = 'A001' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dgv = new DataTable();
                sqlAdapter.Fill(dgv);
                dataGridView1.DataSource = dgv;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (counter >= 19)
            {
                MessageBox.Show("Sudah data terakhir");
            }
            else
            {
                counter++;
                sqlQuery = "SELECT `team_name`, CONCAT(manager_name , ' (' , nat.nation , ')') as Manager , CONCAT(home_stadium , ', ' , city , ' (' , capacity , ')') as Stadium, concat(`player_name`,'(',(n.jumlah_goal + n.jumlah_goal_penalty),')')as `Top Scorer`, concat(`player_name`,'. ' ,(n.jumlah_kartu_kuning),' Yellow Card and ',n.jumlah_kartu_merah,' Red Card') AS 'Worst Discipline' FROM team t, manager m, nationality nat, dmatch d, dt_Newman n WHERE t.manager_id = m.manager_id and t.team_id = d.team_id AND d.player_id = n.player_id and m.nationality_id = nat.nationality_id AND d.player_id= n.player_id GROUP BY t.team_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable lastPrev = new DataTable();
                sqlAdapter.Fill(lastPrev);
                labelTeamName.Text = lastPrev.Rows[counter][0].ToString();
                labelManager.Text = lastPrev.Rows[counter][1].ToString();
                labelStadium.Text = lastPrev.Rows[counter][2].ToString();
                labelTopScorer.Text = lastPrev.Rows[counter][3].ToString();
                labelDicipline.Text = lastPrev.Rows[counter][4].ToString();

                sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = 'A001' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = 'A001' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dgv = new DataTable();
                sqlAdapter.Fill(dgv);
                dataGridView1.DataSource = dgv;
                dataGridView1.Columns.RemoveAt(0);
            }
        }

        private void buttonLastNext_Click(object sender, EventArgs e)
        {
            counter = 19;
            sqlQuery = "SELECT `team_name`, CONCAT(manager_name , ' (' , nat.nation , ')') as Manager , CONCAT(home_stadium , ', ' , city , ' (' , capacity , ')') as Stadium, concat(`player_name`,'(',(n.jumlah_goal + n.jumlah_goal_penalty),')')as `Top Scorer`, concat(`player_name`,'. ' ,(n.jumlah_kartu_kuning),' Yellow Card and ',n.jumlah_kartu_merah,' Red Card') AS 'Worst Discipline' FROM team t, manager m, nationality nat, dmatch d, dt_Newman n WHERE t.manager_id = m.manager_id and t.team_id = d.team_id AND d.player_id = n.player_id and m.nationality_id = nat.nationality_id AND d.player_id= n.player_id GROUP BY t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable lastPrev = new DataTable();
            sqlAdapter.Fill(lastPrev);
            labelTeamName.Text = lastPrev.Rows[counter][0].ToString();
            labelManager.Text = lastPrev.Rows[counter][1].ToString();
            labelStadium.Text = lastPrev.Rows[counter][2].ToString();
            labelTopScorer.Text = lastPrev.Rows[counter][3].ToString();
            labelDicipline.Text = lastPrev.Rows[counter][4].ToString();

            sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = ' + team.Rows[counter1][3].ToString() + ' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = ' + team.Rows[counter1][3].ToString() + ' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dgv = new DataTable();
            sqlAdapter.Fill(dgv);
            dataGridView1.DataSource = dgv;
            dataGridView1.Columns.RemoveAt(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
