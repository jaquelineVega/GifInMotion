﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GifInMotion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void BtnCarouselView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MoviesCarousel());
        }

        private async  void BtnCollectionView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.CollectionMovies());
        }
    }
}