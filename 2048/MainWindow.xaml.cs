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
        //globale Variablen
        double verhältnisbreite = 1;
        double verhältnishöhe = 1;

        Button spielstart = new Button();
        Button einstellungen = new Button();
        Button beenden = new Button();
        Button zurück = new Button();

        Hauptmenü mainmenu = new Hauptmenü();
        Einstellungen settings = new Einstellungen();


        public int spielfeldgröße = 4;          //Wie viele Spielfelder
        Color innen = Color.FromRgb(255, 0, 0);
        Color rand = Color.FromRgb(0, 0, 0);

        public MainWindow()
        { 
            InitializeComponent();

            //Eigenschaften: Button zum Starten des Spiels//---------------------------------------------------------------------------------------------------------------------------------------------------//

            spielstart.Width = 100;
            spielstart.Height = 30;
            spielstart.Content = "Starten";
            

            Canvas.SetTop(spielstart, 150);
            Canvas.SetLeft(spielstart, 150);
            mycanvas1.Children.Add(spielstart);

            spielstart.Click += Spielstart_Click;

            //Eigenschaften: Button zum Öffnen der Einstellungen//---------------------------------------------------------------------------------------------------------------------------------------------//          

            einstellungen.Width = 100;
            einstellungen.Height = 30;
            einstellungen.Content = "Einstellungen";
            

            Canvas.SetTop(einstellungen, 200);
            Canvas.SetLeft(einstellungen, 150);
            mycanvas1.Children.Add(einstellungen);

            einstellungen.Click += Einstellungen_Click;

            //Eigenschaften: Button zum zurüch gehen in den Einstellungen//---------------------------------------------------------------------------------------------------------------------------------------------//          

            zurück.Width = 100;
            zurück.Height = 30;
            zurück.Content = "zurück";

            Canvas.SetTop(zurück, 100);
            Canvas.SetLeft(zurück, 150);            
            mycanvas1.Children.Add(zurück);

            zurück.Click += zurück_Click;
            zurück.Visibility = Visibility.Hidden;

            //Eigenschaften: Button zum Beenden der Anwendung//------------------------------------------------------------------------------------------------------------------------------------------------//

            beenden.Width = 100;
            beenden.Height = 30;
            beenden.Content = "Beenden";
           

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
            zurück.Visibility = Visibility.Hidden;
        }

        public void HauptmenüAusblenden()
        {
            zurück.Visibility = Visibility.Hidden;
            spielstart.Visibility = Visibility.Hidden;
            einstellungen.Visibility = Visibility.Hidden;
            beenden.Visibility = Visibility.Hidden;
         
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public void EinstellungenAnzeigen()
        {
            HauptmenüAusblenden();
           
            zurück.Visibility = Visibility.Visible;
        }


        public void EinstellungenAusblenden()
        {
            HauptmenüAnzeigen();

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
                    double Width = 40 ;
                    double Height = 40 ;
                    rectangle.Width = Width;
                    rectangle.Height = Height;
                    rectangle.Stroke = new SolidColorBrush(rand);
                    rectangle.Fill = new SolidColorBrush(innen);

                    Canvas.SetTop(rectangle, i * (Height + 20) );
                    Canvas.SetLeft(rectangle, o * (Width + 20) );
                    mycanvas1.Children.Add(rectangle);

                }
            }





        }


        //Click_Events-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        private void Spielstart_Click(object sender, RoutedEventArgs e)         //Spiel starten nachdem Starten gecklickt wurde
        {
            HauptmenüAusblenden();
            spiel();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        private void Einstellungen_Click(object sender, RoutedEventArgs e)      //Einstellungen anzeigen nachdem Einstellungen gecklickt wurden 
        {
            EinstellungenAnzeigen();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void zurück_Click(object sender, RoutedEventArgs e)      //Einstellungen anzeigen nachdem Einstellungen gecklickt wurden 
        {
            HauptmenüAnzeigen();
        }










        private void Sizegeändert(object sender, SizeChangedEventArgs e)
        {

            int breite =(int)mycanvas1.ActualWidth;     //Ruft die Breite des Canvas ab 
            int höhe = (int)mycanvas1.ActualHeight;     //Ruft die Höhe des canvas ab 
            /*
            verhältnisbreite = breite / 800;
            double x= breite / 800;
            Console.WriteLine("Breite = "+breite);
            Console.WriteLine("Höhe = " + höhe);
            Console.WriteLine("Verhältnis= " + verhältnisbreite);
            Console.WriteLine(x*800);
            */
        }
    }
}
