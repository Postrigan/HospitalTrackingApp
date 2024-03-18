using HospitalTrackingApp.Classes;
using HospitalTrackingApp.Models;
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
using System.Windows.Threading;

namespace HospitalTrackingApp.UI.Wnds
{
    /// <summary>
    /// Логика взаимодействия для WndMain.xaml
    /// </summary>
    public partial class WndMain : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public WndMain()
        {
            InitializeComponent();

            Manager.GeneratePersonLocations(100);

            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += timer_Tick;
            //timer.Start();

            //UpdatePersonLocations(Manager.personLocations);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Manager.GeneratePersonLocations(100);

            UpdatePersonLocations(Manager.personLocations);
        }

        void UpdatePersonLocations(List<PersonLocation> personLocations)
        {
            foreach (var element in MainCanvas.Children)
            {
                ListView currentListView = element as ListView;

                if (element is ListView)
                    currentListView.Items.Clear();
            }

            foreach (PersonLocation personLocation in personLocations)
            {
                Ellipse ellPerson = new Ellipse();
                ellPerson.Height = 16;
                ellPerson.Width = 16;
                ellPerson.Fill = personLocation.PersonRole == "Клиент" ? Brushes.Green : Brushes.Blue;
                ellPerson.ToolTip = $"Код посетителя: {personLocation.PersonCode} | Роль: {personLocation.PersonRole} | Направление: {personLocation.LastSecurityPointDirection} | Номер СКУД: {personLocation.LastSecurityPointNumber} | Время посещения: {personLocation.LastSecurityPointTime.ToShortTimeString()}";

                if(personLocation.LastSecurityPointDirection == "in")
                {
                    switch (personLocation.LastSecurityPointNumber)
                    {
                        case 0:
                            ACS0.Items.Add(ellPerson);
                            break;
                        case 1:
                            ACS1.Items.Add(ellPerson);
                            break;
                        case 2:
                            ACS2.Items.Add(ellPerson);
                            break;
                        case 3:
                            ACS3.Items.Add(ellPerson);
                            break;
                        case 4:
                            ACS4.Items.Add(ellPerson);
                            break;
                        case 5:
                            ACS5.Items.Add(ellPerson);
                            break;
                        case 6:
                            ACS6.Items.Add(ellPerson);
                            break;
                        case 7:
                            ACS7.Items.Add(ellPerson);
                            break;
                        case 8:
                            ACS8.Items.Add(ellPerson);
                            break;
                        case 9:
                            ACS9.Items.Add(ellPerson);
                            break;
                        case 10:
                            ACS10.Items.Add(ellPerson);
                            break;
                        case 11:
                            ACS11.Items.Add(ellPerson);
                            break;
                        case 12:
                            ACS12.Items.Add(ellPerson);
                            break;
                        case 13:
                            ACS13.Items.Add(ellPerson);
                            break;
                        case 14:
                            ACS14.Items.Add(ellPerson);
                            break;
                        case 15:
                            ACS15.Items.Add(ellPerson);
                            break;
                        case 16:
                            ACS16.Items.Add(ellPerson);
                            break;
                        case 17:
                            ACS17.Items.Add(ellPerson);
                            break;
                        case 18:
                            ACS18.Items.Add(ellPerson);
                            break;
                        case 19:
                            ACS19.Items.Add(ellPerson);
                            break;
                        case 20:
                            ACS20.Items.Add(ellPerson);
                            break;
                        case 21:
                            ACS21.Items.Add(ellPerson);
                            break;
                        case 22:
                            ACS22.Items.Add(ellPerson);
                            break;
                    }
                }
                else
                {
                    ACSCoridor.Items.Add(ellPerson);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            UpdatePersonLocations(Manager.personLocations);
            Button button = sender as Button;
            button.IsEnabled = false;
        }
    }
}
