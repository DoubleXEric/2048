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

namespace _2048
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button spielstart = new Button();
        Button einstellungen = new Button();
        Button beenden = new Button();

        Hauptmenü mainmenu = new Hauptmenü();
        Einstellungen settings = new Einstellungen();


        public int spielfeldgröße = 4;
        Color innen = Color.FromRgb(255, 0, 0);
        Color rand = Color.FromRgb(0, 0, 0);

        public MainWindow()
        { 
            InitializeComponent();

            //Eigenschaften: Button zum Starten des Spiels//---------------------------------------------------------------------------------------------------------------------------------------------------//

            spielstart.Width = 100;
            spielstart.Height = 30;
            spielstart.Content = "Starten";
            spielstart.Visibility = Visibility.Visible;

            Canvas.SetTop(spielstart, 150);
            Canvas.SetLeft(spielstart, 150);
            mycanvas1.Children.Add(spielstart);

            spielstart.Click += Spielstart_Click;

            //Eigenschaften: Button zum Öffnen der Einstellungen//---------------------------------------------------------------------------------------------------------------------------------------------//          

            einstellungen.Width = 100;
            einstellungen.Height = 30;
            einstellungen.Content = "Einstellungen";
            einstellungen.Visibility = Visibility.Visible;

            Canvas.SetTop(einstellungen, 200);
            Canvas.SetLeft(einstellungen, 150);
            mycanvas1.Children.Add(einstellungen);

            einstellungen.Click += Einstellungen_Click;

            //Eigenschaften: Button zum Beenden der Anwendung//------------------------------------------------------------------------------------------------------------------------------------------------//

            beenden.Width = 100;
            beenden.Height = 30;
            beenden.Content = "Beenden";
            beenden.Visibility = Visibility.Visible;

            Canvas.SetTop(beenden, 250);
            Canvas.SetLeft(beenden, 150);
            mycanvas1.Children.Add(beenden);

            beenden.Click += Beenden_Click;          
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public void HauptmenüAnzeigen()
        {
            spielstart.Visibility = Visibility.Visible;
            einstellungen.Visibility = Visibility.Visible;
            beenden.Visibility = Visibility.Visible;
        }

        public void HauptmenüAusblenden()
        {
            spielstart.Visibility = Visibility.Hidden;
            einstellungen.Visibility = Visibility.Hidden;
            beenden.Visibility = Visibility.Hidden;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public void EinstellungenAnzeigen()
        {
            
        }

        public void EinstellungenAusblenden()
        {
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public void spiel()
        {
            for (int i = 0; i < spielfeldgröße; i++)
            {
                for (int o = 0; o < spielfeldgröße; o++)
                {
                    string rectname = "rt_" + i + "" + o;

                    Rectangle rectangle = new Rectangle();
                    rectangle.Name = rectname;
                    rectangle.Width = 40;
                    rectangle.Height = 40;
                    rectangle.Stroke = new SolidColorBrush(rand);
                    rectangle.Fill = new SolidColorBrush(innen);

                    Canvas.SetTop(rectangle, i * 40 + 20);
                    Canvas.SetLeft(rectangle, o * 40 + 20);
                    mycanvas1.Children.Add(rectangle);

                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        private void Spielstart_Click(object sender, RoutedEventArgs e)
        {
            HauptmenüAusblenden();
            spiel();
        }

        private void Einstellungen_Click(object sender, RoutedEventArgs e)
        {
            EinstellungenAnzeigen();
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
