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
using System.Diagnostics;

namespace CryptoBlockChainApp
{
    // TODO - AGREGAR IMAGENES
    // TODO - SOLO AGREGAR UN RIDE OFFER POR CONDUCTOR
    // TODO - VALIDAR HORAS QUE NO CHOQUEN EN MYRIDES

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

        private Ride SelectOfferRide()
        {
       
            foreach (ListViewItem item in offerridesListView.Items)
            {
                if (item.Focused || item.Selected)
                {
                    return FindRide(int.Parse(item.SubItems[0].Text));
                }
            }
            return null;
        }
        private Ride FindRide(int ID)
        {
            foreach (Ride item in rides)
            {
                if (ID == item.id)
                    return item;
            }
            return null;
        }


        #region Buttons
        private void bidButton_Click(object sender, EventArgs e)
        {
            Ride selected_ride = SelectOfferRide();
            user.myrides.Add(selected_ride);
            UpdateGUI();
        }
        private void offerpublishButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Sup1");
            if (user == null)
            {
                ShowLabel("Please define a user!", publishridewarningLabel, LabelType.warning);
                return;
               
            }
            try
            {
                Debug.WriteLine("Finally Entered");
                ClearLabel(publishridewarningLabel);
                if (fromDateTimePicker.Value >= toDateTimePicker.Value) { ShowLabel("Ride hours are not factible.", publishridewarningLabel, LabelType.warning); return; }
                Ride ride = new Ride(
                    GetUnusedID(),
                    user.avatarNum,
                    user.ethereumAddress,
                    locationComboBox.Text,
                    int.Parse(availableseatsComboBox.Text),
                    dateTimePicker1.Value,
                    fromDateTimePicker.Value,
                    toDateTimePicker.Value,
                    double.Parse(costTextBox.Text));
               rides.Add(ride);
            }
            catch
            {
                ShowLabel("You must fill all fields correctly!", publishridewarningLabel, LabelType.warning);
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
            if (user != null && rides.Count > 0)
            {
                Debug.WriteLine("ola");
                UpdateListViews(user.myrides);
            }
                if (rides.Count >= 50)
                {
                    offerpublishButton.Enabled = false;
                }
                else
                {
                    offerpublishButton.Enabled = true;
                }
            
        }

        private void UpdateListViews(List<Ride> userRides)
        {
            offerridesListView.Items.Clear();
            myridesListView.Items.Clear();
            foreach (Ride item in rides)
            {
                addofferListView(item);

            }
            foreach (Ride item in userRides)
            {
                addmyridesListView(item);
            }
        }
        private void addmyridesListView(Ride ride)
        {
            if (ride == null) return;
            ListViewItem item = new ListViewItem(ride.id.ToString());
            item.SubItems.Add(ride.avatarNum.ToString());
            item.SubItems.Add(ride.date.Day + "/" + ride.date.Month + "/" + ride.date.Year.ToString());
            item.SubItems.Add(ride.fromTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.toTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.location);
            myridesListView.Items.Add(item);
        }
        private void addofferListView(Ride ride)
        {
            ListViewItem item = new ListViewItem(ride.id.ToString());
            item.SubItems.Add(ride.avatarNum.ToString());
            item.SubItems.Add(ride.date.Day + "/" + ride.date.Month + "/" + ride.date.Year.ToString());
            item.SubItems.Add(ride.fromTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.toTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.location);
            item.SubItems.Add(ride.avSeats.ToString());
            item.SubItems.Add("$"+ride.cost.ToString());
            offerridesListView.Items.Add(item);
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
        private void ShowLabel(String str, Label label, LabelType lbltype)
        {
            Color clr = Color.White;
            switch (lbltype)
            {
                case LabelType.neutral:
                    clr = Color.Black;
                    break;
                case LabelType.warning:
                    clr = Color.DarkOrange;
                    break;
                case LabelType.critical:
                    clr = Color.Red;
                    break;
            }
            label.Text = str;
            label.ForeColor = clr;
            label.Enabled = true;
        }
        private void ClearLabel(Label label)
        {
            label.Text = "";
            label.Enabled = false;
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
            //TODO Filtrado de columnas
        }

        #endregion

        
    }
}
