using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INF04PlaylistaD
{
    
    public partial class MainWindow : Window
    {
        public class Album
        {
            public string Artist { get; set; }

            public string Title { get; set; }

            public int TrackCount { get; set; }

            public int ReleaseYear { get; set; }
            public int Downloads { get; set; }

            public Album(string artist, string title, int trackCount, int releaseYear, int downloads)
            {
                Artist = artist;
                Title = title;
                TrackCount = trackCount;
                ReleaseYear = releaseYear;
                Downloads = downloads;
            }
        }

        public List<Album> sampleAlbums = new List<Album>
    {
        // Gorillaz
        new Album("Gorillaz",
                  "The Now Now",
                  11,
                  2018,
                  11000102),

        // My Chemical Romance
        new Album("My Chemical Romance",
                  "The Black Parade",
                  14,
                  2006,
                  304666444),

        // Wilki
        new Album("Wilki",
                  "wilki",
                  16,
                  1992,
                  4000230)
    };
        public int currentAlbumIndex = 0; 
        public MainWindow()
        {
            InitializeComponent();
            Refresh();

        }
        public void Refresh()
        {
            lblArtist.Content = sampleAlbums[currentAlbumIndex].Artist;
            lblTitle.Content = sampleAlbums[currentAlbumIndex].Title;
            lblCount.Content = sampleAlbums[currentAlbumIndex].TrackCount;
            lblYear.Content = sampleAlbums[currentAlbumIndex].ReleaseYear;
            lblDownloads.Content = sampleAlbums[currentAlbumIndex].Downloads;

        }
       
        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            sampleAlbums[currentAlbumIndex].Downloads += 1;
            Refresh();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (currentAlbumIndex == 0)
            {
                currentAlbumIndex = sampleAlbums.Count - 1;
            }
            else
            {
                currentAlbumIndex--;
            }
            Refresh();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentAlbumIndex == sampleAlbums.Count - 1)
            {
                currentAlbumIndex = 0;
            }
            else
            {
                currentAlbumIndex++;
            }
            Refresh();
        }
    }
}