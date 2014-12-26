using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using JariZ;
using System.Windows.Threading;
using Hardcodet.Wpf.TaskbarNotification;

namespace Spotifytest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string sArtist { get; set; }
        public string sTitle { get; set; }
        public string sAlbum { get; set; }
        SpotifyInfo Spot = new SpotifyInfo(3000);

        public MainWindow()
        {
            InitializeComponent();
            B_Enabled.Checked += B_Enabled_Checked;
            Spot.TrackChanged += Spot_TrackChanged;
        }

        void B_Enabled_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)(sender as CheckBox).IsChecked)
                Spot.StartPolling();
            else
                Spot.StopPolling();
        }

        void Spot_TrackChanged(SpotifyInfo SpotifyAuto, EventArgs e)
        {
            ShowBalloon(this, null);
        }


        private void ShowBalloon(object sender, RoutedEventArgs e)
        {
            string BalloonText = String.Format("{0} - {1}", Spot.Status.track.artist_resource.name,Spot.Status.track.track_resource.name);
            Balloon.ShowBalloonTip("Spotify Info", BalloonText, BalloonIcon.Info);
        }

    }

    public class SpotifyInfo : SpotifyAPI
    {
        public delegate void TrackHandler(SpotifyInfo SpotifyAuto,EventArgs e);
        public event TrackHandler TrackChanged;
        private DispatcherTimer timer;
        private string OldTrack;

        public SpotifyInfo(double PollRate)
            : base(SpotifyAPI.GetOAuth(), "127.0.0.1")
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(PollRate);
            timer.Tick += timer_Tick;
        }

        public void StartPolling()
        {
            timer.Start();
        }

        public void StopPolling()
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Responses.CFID cfid = this.CFID;
            Responses.Status Info = this.Status;
            if (Info.track != null)
            {
                if(Info.track.track_resource.name != OldTrack)
                {
                    TrackChanged(this, e);
                    OldTrack = Info.track.track_resource.name;
                }
            }
        }
    }

}
