using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieSim
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Główna funkcja gry. Te rzeczy mają miejsce kiedy gra startuje.
        /// - ustawia nazwy nagłówków w dataGridViewUpgrades
        /// - tworzy nową kolumnę na obrazki w dataGridViewUpgrades
        /// - ustawia dataGridViewUpgrades jako niesortowalne
        /// - wypełnia dataGridViewUpgrades danymi
        /// - wypełnia upgradeList oraz cityList
        /// - startuje timerCount
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            this.Text = GameData.Title;

            dataGridViewUpgrades.ColumnCount = 3;
            dataGridViewUpgrades.Columns[0].HeaderText = "Nazwa ulepszenia";
            dataGridViewUpgrades.Columns[1].HeaderText = "Liczba posiadanych";
            dataGridViewUpgrades.Columns[2].HeaderText = "Koszt kupna";
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            dataGridViewUpgrades.Columns.Insert(0, imgColumn);
            foreach (DataGridViewColumn c in dataGridViewUpgrades.Columns)
                c.SortMode = DataGridViewColumnSortMode.NotSortable;

            GameData.fillupgradeList();
            GameData.fillcityList();
            
            UpdateupgradeList();
            timerCount.Start();
        }

        /// <summary>
        /// Funkcja obsługująca zdarzenie kupienia ulepszenia.
        /// - zwiększa Zombies.PerClick oraz Zombies.PerTick w zależności od typu ulepszenia
        /// - zwiększa koszt kupna kolejnego ulepszenia tego samego typu o 25%
        /// - zwiększa liczbę posiadanych ulepszeń tego typu
        /// </summary>
        /// <param name="upgradeIndex"></param>
        private void BuyUpgrade(int upgradeIndex)
        {
            Upgrade u = GameData.upgradeList[upgradeIndex];
            GameData.Zombies.PerClick += u.ZombiesPerClick;
            GameData.Zombies.PerTick += u.ZombiesPerTick;
            GameData.Zombies.BrainsCount -= u.CurrentCost;
            double newCost = Math.Round(u.CurrentCost * 1.25);
            u.CurrentCost = Convert.ToInt64(newCost);
            u.Count++;
            UpdateZombieAmounts();
            UpdateupgradeList();
        }
        /// <summary>
        /// Funkcja updatująca liczbę posiadanych zombie/mózgów
        /// </summary>
        private void UpdateZombieAmounts()
        {
            textBoxZombieCount.Text = GameData.Zombies.Count.ToString();
            textBoxBrainsCount.Text = GameData.Zombies.BrainsCount.ToString();
            labelZombiesPerSecond.Text = GameData.Zombies.PerTick.ToString() + " zombie na sekundę";
            labelZombiesPerClick.Text = GameData.Zombies.PerClick.ToString() + " zombie na klika";
            foreach (Upgrade u in GameData.upgradeList)
            {
                if (GameData.Zombies.OldCount <= u.OriginalCost && GameData.Zombies.Count >= u.OriginalCost)
                    UpdateupgradeList();
            }
        }
        /// <summary>
        /// Funkcja updatująca dataGridViewUpgrades po wykupieniu/obblokowaniu ulepszenia
        /// - odblokowuje ulepszenie do kupna, jeśli liczba zombie wyprodukowanych od początku gry przekroczyła oryginalny koszt ulepszenia
        /// - odświeża listę ulepszen, jeśli jakieś zostało kupione
        /// </summary>
        private void UpdateupgradeList()
        {
            dataGridViewUpgrades.Rows.Clear();
            foreach (Upgrade u in GameData.upgradeList)
            {
                if (GameData.Zombies.Count >= u.OriginalCost)
                {
                    object pic = ZombieSim.Properties.Resources.ResourceManager.GetObject(u.Picture);
                    Image img = new Bitmap((Image)pic);
                    DataGridViewRow row = new DataGridViewRow();
                    dataGridViewUpgrades.Rows.Add(img, u.Name, u.Count, u.CurrentCost);
                }
            }
            dataGridViewUpgrades.Refresh();
        }
        /// <summary>
        /// Funkcja sprawdzająca, czy liczba wszystkich posiadanych zombie przekroczyła populację danego miasta/państwa. 
        /// Jeśli tak, to miasto/państwo zostaje odblokowane jako zniszczone.
        /// </summary>
        private void CheckForDestroyedCities()
        {
            foreach (City c in GameData.cityList)
            {
                if (GameData.Zombies.OldCount <= c.Population && GameData.Zombies.Count >= c.Population && c.Unlocked == false)
                {
                    c.Unlocked = true;
                    MessageBox.Show("Gratulacje! Cała populacja "+ c.Name + " w liczbie "+c.Population + " osób została zamieniona w zombie. Dobra robota!",
                        GameData.Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Funkcja sprawdzająca, czy zostały spełnione warunki wygranej (zamienienie całego świata w zombie)
        /// </summary>
        /// <returns></returns>
        private bool CheckForWin()
        {
            if (GameData.Zombies.Count >= 7600000001)
            {
                timerCount.Stop();
                pictureBoxButton.Enabled = false;
                MessageBox.Show("Gratulacje, wygrałeś grę! \n" +
                    "Cała ludzkość została z sukcesem zamieniona w zombie. Mam nadzieję, że jesteś z siebie zadowolony.",
                    GameData.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Funkcja obsługująca pokazywanie okienka pomocy po kliknięciu w buttonHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GameData.GameDescription,
                GameData.Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        /// <summary>
        /// Funkcja obsługująa pokazywanie okienka osiągnięć po kliknięciu w buttonAchievement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAchievement_Click(object sender, EventArgs e)
        {
            string achievements = "ZNISZCZONE MIASTA/PAŃSTWA:\n";
            foreach (City c in GameData.cityList)
            {
                if (c.Unlocked)
                    achievements += c.Name + "\n";
            }
            MessageBox.Show(achievements,
                GameData.Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        /// <summary>
        /// Funkcja obsługująca główny timer w grze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
            if (!CheckForWin()) //jeśli warunek wygranej nie został spełniony i gra może kontynuować
            {
                GameData.Zombies.addZombies(GameData.Zombies.PerTick);
                UpdateZombieAmounts();
                CheckForDestroyedCities();
            }
        }
        /// <summary>
        /// Funkcja odpowiedialna za zwiększanie ilości posiadanych zombie za każdym kliknieciem w Wielki Czerwony Przycisk Zaglady.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!CheckForWin()) //jeśli warunek wygranej nie został spełniony i gra może kontynuować
            {
                GameData.Zombies.addZombies(GameData.Zombies.PerClick);
                pictureBoxButton.Image = ZombieSim.Properties.Resources.buttonPushed;
                UpdateZombieAmounts();
            }
        }
        /// <summary>
        /// Funkcja odpowiedzialna za zmianę obrazka Wielkiego Czerwonego Przycisk Zagłady.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxButton.Image = ZombieSim.Properties.Resources.buttonReady;
        }
        
        /// <summary>
        /// Funkcja obsługująca klikanie w komórki daraGridViewUpgrades (aby można było kupować ulepszenia).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUpgrades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (GameData.Zombies.BrainsCount >= GameData.upgradeList[e.RowIndex].CurrentCost)
                    BuyUpgrade(e.RowIndex);
                else MessageBox.Show("Nie posiadasz wystarczającej ilości mózgów, żeby kupić to ulepszenie!", 
                    "Brak funduszy", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Stop);
            }
        }
        /// <summary>
        /// Pokazuje opis ulepszenia po najechaniu na nie myszką.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUpgrades_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string toolTipText;
            if (e.RowIndex >= 0)
            {
                string upgradeName = dataGridViewUpgrades.Rows[e.RowIndex].Cells[1].Value.ToString();
                foreach (Upgrade u in GameData.upgradeList)
                {
                    if (u.Name ==upgradeName)
                    {
                        toolTipText = u.Name.ToUpper()
                                            + " [posiadane: " + u.Count + "] "
                                            + "[koszt: " + u.CurrentCost + "]"
                                            + "\n\n" + u.Description
                                            + "\n\nProdukuje " + u.ZombiesPerTick + " zombie na sekundę"
                                            + "\nDaje " + u.ZombiesPerClick + " zombie na klika";
                        DataGridViewCell cell = this.dataGridViewUpgrades.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        cell.ToolTipText = toolTipText;
                    }
                }
            }
        }
    }
}
