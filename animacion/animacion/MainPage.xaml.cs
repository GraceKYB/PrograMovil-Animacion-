using System;
using Xamarin.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;
using System.Reflection;

namespace animacion
{
    public partial class MainPage : ContentPage
    {
        private bool _isPlaying = false;
        public MainPage()
        {
            InitializeComponent();

            // Configuración del gráfico
            var plotModel = new PlotModel { Title = "Gráfico de barra" };
            plotModel.Series.Add(new BarSeries
            {
                ItemsSource = new[]
                {
                    new BarItem { Value = 10 },
                    new BarItem { Value = 20 },
                    new BarItem { Value = 30 }
                }
            });

            plotview.Model = plotModel;

            // Deshabilitar botón de Pausa inicialmente
            btnPause.IsEnabled = false;
        }


        
        private void Play_Clicked(object sender, EventArgs e)
            {
                try
                {
                    if (!_isPlaying)
                    {
                        DependencyService.Get<IAudioPlayer>().PlayAudio("audio");
                        _isPlaying = true;

                        btnPlay.IsEnabled = false;
                        btnPause.IsEnabled = true;
                    }
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "OK");
                }
            }

        private void Pause_Clicked(object sender, EventArgs e)
            {
                try
                {
                    if (_isPlaying)
                    {
                        DependencyService.Get<IAudioPlayer>().PauseAudio();
                        _isPlaying = false;

                        btnPlay.IsEnabled = true;
                        btnPause.IsEnabled = false;
                    }
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "OK");
                }
            }
        }
    }
