using StatePattern2.Command;
using StatePattern2.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace StatePattern2.ViewModel
{
   public class AppViewModel:BaseViewModel
    {
        public Ellipse Dot { get; set; }
        public Rectangle Back { get; set; }
        private string path;

        Thickness LeftSide = new Thickness(-39, 0, 0, 0);
        Thickness RightSide = new Thickness(0, 0, -39, 0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(197, 14, 46));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(20, 159, 91));
        private bool Toggled = false;
        public string Path
        {
            get { return path; }
            set { path = value; OnPropertyChanged(); }
        }

        public RelayCommand PlayCommand { get; set; }
        public RelayCommand PauseCommand { get; set; }
        public RelayCommand StopCommand { get; set; }
        public RelayCommand OnOffCommand { get; set; }
        public RelayCommand DragCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public RelayCommand DotCommand { get; set; }
        public  MediaPlayer player  { get; set; } = new MediaPlayer();

        public bool Toggled1 { get => Toggled; set => Toggled = value; }

        public bool click { get; set; }

        public AppViewModel()
        {
            MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.ChangeState(new OffState());

            BackCommand = new RelayCommand((e) =>
            {
           
                if (!Toggled)
                {
                    musicPlayer.ChangeState(new OnState());
                    Dot.Fill = On;
                    Toggled = true;
                    Dot.Margin = RightSide;
                    click = true;
                }
                else
                {
                    musicPlayer.ChangeState(new OffState());
                    Dot.Fill = Off;
                    Toggled = false;
                    Dot.Margin = LeftSide;
                    click = false;
                }
            });

            DotCommand = new RelayCommand((e) =>
            {
               
                if (!Toggled)
                {
                    musicPlayer.ChangeState(new OnState());
                    Dot.Fill = On;
                    Toggled = true;
                    Dot.Margin = RightSide;
                    click = true;
                }
                else
                {
                    musicPlayer.ChangeState(new OffState());
                    Dot.Fill = Off;
                    Toggled = false;
                    Dot.Margin = LeftSide;
                    click = false;

                }
            });


            PlayCommand = new RelayCommand((e) =>
            {
                if (path != null)
                {
                    
                    player.Open(new Uri(path));
                    player.Play();
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            },(p)=> {

                return musicPlayer.GetCanPlay();
            });

            PauseCommand = new RelayCommand((e) =>
            {
                if (path != null)
                {
                    player.Pause();
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }, (p) => {

                return musicPlayer.GetCanPause();
            });

            StopCommand = new RelayCommand((e) =>
            {
                if (path != null)
                {
                    player.Stop();
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
            , (p) => {

                return musicPlayer.GetCanStop();
            });



        }
        





    }
}
