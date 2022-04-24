using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CryptoBlockChainApp
{
    // TODO - AGREGAR IMAGENES
    // TODO - FILTROS DE COLUMNAS
    // TODO - SELECCIONAR VIAJES PARA MI
    // TODO - SOLO AGREGAR UN RIDE PORR CONDSUCTOR
    public partial class CryptoRide : Form
    {
        private User user;
        private int currentavatarNum = 1;
        private List<Ride> rides = new List<Ride>();
        private List<Label> labels;
        public CryptoRide()
        {
            InitializeComponent();
            SetAvatar(currentavatarNum);

            Label[] labelsArray = { publishridewarningLabel, bidresultLabel }; // You can add labels to clear on init!
            labels = new List<Label>(labelsArray);
            ClearWarningLabels(labels);
        }

        private void SetAvatar(int currentavatarNum)
        {
            currentavatarnumLabel.Text = currentavatarNum.ToString();
        }


        #region Buttons
        private void offerpublishButton_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                publishridewarningLabel.Text = "Please define a user!";
                return;
            }
                try
            {
                ClearLabel(publishridewarningLabel);
               Ride ride = new Ride(GetUnusedID(), user.avatarNum, user.ethereumAddress, locationComboBox.Text, int.Parse(availableseatsComboBox.Text), dateTimePicker1.Value, dateTimePicker2.Value,double.Parse(costTextBox.Text));
               rides.Add(ride);
            }
            catch
            {
                publishridewarningLabel.Text = "You must fill all fields correctly!";
            }
           

            UpdateGUI();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            user = new User(currentavatarNum, usernameTextBox.Text, ethereumaddressTextBox.Text);

            UpdateGUI();
        }
        private void nextavatarButton_Click(object sender, EventArgs e)
        {
            if (currentavatarNum >= 5) return;
            currentavatarNum++;
            SetAvatar(currentavatarNum);

            UpdateGUI();
        }

        private void previousavatarButton_Click(object sender, EventArgs e)
        {
            if (currentavatarNum <= 1) return;
            currentavatarNum--;
            SetAvatar(currentavatarNum);

            UpdateGUI();
        }
        #endregion

        #region Updaters
        private void UpdateGUI()
        {
            UpdateOfferTable();
                if (rides.Count >= 50)
                {
                    offerpublishButton.Enabled = false;
                }
                else
                {
                    offerpublishButton.Enabled = true;
                }
            
        }

        private void UpdateOfferTable()
        {
            OfferTravels.Items.Clear();
            foreach (Ride item in rides)
            {
                AddRideToOfferTable(item);

            }
        }

        private void AddRideToOfferTable(Ride ride)
        {
            ListViewItem item = new ListViewItem(ride.id.ToString());
            item.SubItems.Add(ride.avatarNum.ToString());
            item.SubItems.Add(ride.date.Day + "/" + ride.date.Month + "/" + ride.date.Year.ToString());
            item.SubItems.Add(ride.time.TimeOfDay.ToString());
            item.SubItems.Add(ride.location);
            item.SubItems.Add(ride.avSeats.ToString());
            item.SubItems.Add("$"+ride.cost.ToString());
            OfferTravels.Items.Add(item);
        }
        #endregion

        #region Labels
        private void ClearWarningLabels(List<Label> labels)
        {
            foreach (Label item in labels)
            {
                ClearLabel(item);
            }
            publishridewarningLabel.Text = "";
            bidresultLabel.Text = "";
        }
        private void ClearLabel(Label label)
        {
            label.Text = "";
        }
        #endregion

        #region MiscFunctions
        private int GetUnusedID()
        {
        Label:
            Random random = new Random();
            int i = random.Next(0, 51);
            foreach (Ride item in rides)
            {

                if (item.id == i) goto Label;
            }

            return i;
        }
        private void OfferTravels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
