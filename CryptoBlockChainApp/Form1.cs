using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace CryptoBlockChainApp
{
    // TODO/OPTIONAL - SALVAR EN UN FILE USERS(OBJ) LIST AND RIDES(OBJ) LIST -> INITIALIZE THIS OBJECTS
    // 
    // TODO - PUT ethereum 
    // TODO - LOAD WALLET MUST!!
    public partial class CryptoRide : Form
    {
        private User user;
        private List<User> users = new List<User>();    
        private int currentavatarNum = 1;
        private List<Ride> rides = new List<Ride>();
        private List<Label> labels;

        //IMAGES Handle
        String proyectpath = "C:\\Users\\hrswf\\OneDrive\\Docs\\VSProjects\\CryptoRide\\CryptoBlockChainApp\\"; //PUT THE FOLDER WHERE THE IMAGES ARE
       List<Image> images= new List<Image>();
        public CryptoRide()
        {
            InitializeComponent();
            SetAvatar(currentavatarNum);

            Label[] labelsArray = { publishridewarningLabel, bidresultLabel }; // You can add labels to clear on init!
            labels = new List<Label>(labelsArray);
            ClearWarningLabels(labels);


            //IMAGES HANDLE
            Image[] temp_imags = { Image.FromFile(proyectpath + "prof1.jpg"), Image.FromFile(proyectpath + "prof2.jpg"), Image.FromFile(proyectpath + "prof3.jpg"),
            Image.FromFile(proyectpath + "prof4.jpg"),Image.FromFile(proyectpath + "prof5.jpg")};
            
            images = temp_imags.ToList();
            ImageList imagelist = new ImageList();
            imagelist.ImageSize = new Size(50, 50);
            foreach (Image image in images)
            {
                imagelist.Images.AddRange(images.ToArray());
            }
            
            offerridesListView.SmallImageList = imagelist;
            myridesListView.SmallImageList = imagelist;
            avatarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
            avatarPictureBox.Image = images[currentavatarNum - 1];
        }

       

        private Ride SelectOfferRide()
        {
       
            foreach (ListViewItem item in offerridesListView.Items)
            {
                if (item.Focused || item.Selected)
                {
                    return FindRide(int.Parse(item.SubItems[1].Text));
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

        private bool ValidateDate(User user, Ride selectedride)
        {
            if (selectedride == null) { ShowLabel("No ride selected!", bidresultLabel, LabelType.critical); return false; }
            if (user.ethereumAddress == selectedride.ethereumAddress) {ShowLabel("You cannot add a ride you published.", bidresultLabel, LabelType.critical); return false; }
            if (selectedride.avSeats <= 0) {  ShowLabel("No available seats!", bidresultLabel, LabelType.critical); return false; }
            
            bool temp_bool = false;
            if (user.myrides.Count <= 0) return true;
            foreach (Ride temp_ride in user.myrides)
            {
                if (temp_ride.date != selectedride.date) return true;
                temp_bool = !DoRangesCollide(temp_ride.fromTime.Ticks, temp_ride.toTime.Ticks, selectedride.fromTime.Ticks, selectedride.toTime.Ticks);
            }
            if(!temp_bool) ShowLabel("You cannot have two trips at the same time.", bidresultLabel, LabelType.critical);
            return temp_bool;

        }
        private void SetAvatar(int currentavatarNum)
        {
            currentavatarnumLabel.Text = currentavatarNum.ToString();
            try
            {
                avatarPictureBox.Image = images[currentavatarNum - 1];
            }
            catch (Exception ex)
            {
            }
        }
        private bool DoRangesCollide(long from1,long to1, long from2, long to2) // Si collisionan me da true
        {
            if (from1 >= from2 && to1 <= to2) return true;   // if selectedride is within the range of any users ride
            if (from1 <= from2 && to1 >= to2) return true;   // if selectedride is bigger and collides with any users ride
            if (from1<to2 && to1 > to2)return true;       // if selectedride from time is within range
            if (from1< from2 && to1 > from2)return true;   // if selectedride to time is within range
            return false;
        }

        private bool ValidatePublishRides(Ride selected_ride,long from, long to)
        {

            if (rides.Count <= 0) return true;

            bool temp_bool = true;

            foreach (Ride temp_ride in rides)
            {
                if (temp_ride.ethereumAddress == user.ethereumAddress)
                {
                    temp_bool =  temp_ride.date==selected_ride.date & !DoRangesCollide(from, to, temp_ride.fromTime.Ticks, temp_ride.toTime.Ticks); // Si hay collisionan regresamos true...
                }
               
            }
            return temp_bool;
        }
        #region Buttons
        private void bidButton_Click(object sender, EventArgs e)
        {
            
            Ride selected_ride = SelectOfferRide();
            if (ValidateDate(user, selected_ride))
            {
                //TODO ETH SMART CONTRACT VALIDATION FOR TRANSACTION between user.ethereumaddress y selected_ride.ethereumaddress
                selected_ride.avSeats--;
                if(selected_ride.avSeats<=0)
                {
                    rides.RemoveAt(rides.FindIndex(r => r.ethereumAddress == selected_ride.ethereumAddress)); // si el asiento 
                }
                user.myrides.Add(selected_ride);
                ShowLabel("Success: Smart contract completed", bidresultLabel, LabelType.good);
            }

            UpdateGUI();
        }
        private void offerpublishButton_Click(object sender, EventArgs e)
        {

            if (user == null) return;
            if (user.activeOfferRide != null) { ShowLabel("Cannot publish more than one offer!", publishridewarningLabel, LabelType.warning); return; }
            try
            {
                ClearLabel(publishridewarningLabel);

                if (fromDateTimePicker.Value >= toDateTimePicker.Value) { 
                    ShowLabel("Ride hours are not factible.", publishridewarningLabel, LabelType.warning); return; }
 

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

                /* VALIDATION FOR PUBLISHING MULTIPLE TRIPS!!
                 * 
                  if (!ValidatePublishRides(ride,fromDateTimePicker.Value.Ticks, toDateTimePicker.Value.Ticks)){
                    ShowLabel("Cannot publish two rides in the same time range", publishridewarningLabel, LabelType.warning); return;
                }
                */

                user.activeOfferRide = ride;
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
            bool userExisted = false;
            user = new User(currentavatarNum, usernameTextBox.Text, ethereumaddressTextBox.Text);
            if (users.Count > 0)
            {
                foreach (User temp_user in users)
                {
                    if (temp_user.ethereumAddress == ethereumaddressTextBox.Text) // Si ya existía esa ethereum address no creamos otro perfil y recuperamnos datos
                    {
                        currentavatarNum = temp_user.avatarNum;
                        user = temp_user;
                        userExisted = true;
                    }
                }
                
            }

            if(!userExisted)users.Add(user);
            UpdateGUI();
        }
        private void nextavatarButton_Click(object sender, EventArgs e)
        {
            if (currentavatarNum >= 5) return;
            currentavatarNum++;
            SetAvatar(currentavatarNum);

        }
        private void previousavatarButton_Click(object sender, EventArgs e)
        {
            if (currentavatarNum <= 1) return;
            currentavatarNum--;
            SetAvatar(currentavatarNum);;
        }
        #endregion
        #region Updaters
        private void UpdateGUI()
        {
            avatarPictureBox.Image = images[currentavatarNum - 1];
            if (user == null  ) return;

            //Update User View
            ethereumaddressTextBox.Text = user.ethereumAddress;
            usernameTextBox.Text = user.name;

            if (rides.Count > 0) UpdateListViews(user.myrides);
            if(rides.Count == 0) offerridesListView.Items.Clear();

            if (rides.Count >= 50)
                {
                    offerpublishButton.Enabled = false;
                }
                else
                {
                    offerpublishButton.Enabled = true;
                }
            
            //Update rides
            /*
            List<int> indexerr = new List<int>(); 
            foreach (Ride temp_ride in rides)
            {
                if (temp_ride.toTime < DateTime.Now.Date)indexerr.Add(rides.FindIndex(r => r == temp_ride));
            }

            foreach(int i in indexerr)
            {
                foreach (User user in users)
                {
                    if(user.ethereumAddress==rides[i].ethereumAddress)
                    {
                        user.activeOfferRide = null;
                    }
                }
                rides.RemoveAt(i);
            }
            */
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
            ListViewItem item = myridesListView.Items.Add("", ride.avatarNum-1); 
            item.SubItems.Add(ride.id.ToString());
            item.SubItems.Add(ride.date.Day + "/" + ride.date.Month + "/" + ride.date.Year.ToString());
            item.SubItems.Add(ride.fromTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.toTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.location);
        }

        private void addofferListView(Ride ride)
        {
            if (ride == null) return;
            ListViewItem item = offerridesListView.Items.Add("", ride.avatarNum-1);
            item.SubItems.Add(ride.id.ToString());
            item.SubItems.Add(ride.date.Day + "/" + ride.date.Month + "/" + ride.date.Year.ToString());
            item.SubItems.Add(ride.fromTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.toTime.TimeOfDay.ToString());
            item.SubItems.Add(ride.location);
            item.SubItems.Add(ride.avSeats.ToString());
            item.SubItems.Add("$"+ride.cost.ToString());
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
                case LabelType.good:
                    clr = Color.Green;
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
            //TODO Optional Filtrado de columnas
        }


        #endregion

        private void loadwalletButton_OnClick(object sender, EventArgs e)
        {
            //TODO Load wallet functionality
        }
    }
}
