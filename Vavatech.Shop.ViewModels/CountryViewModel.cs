using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.ViewModels
{
    public class CountryViewModel : BaseViewModel
    {
        private readonly ICountryService countryService;
        private readonly ICityService cityService;

        public IEnumerable<Country> Countries { get; set; }

        private Country selectedCountry;
        private IEnumerable<City> cities;
        private City selectedCity;

        public Country SelectedCountry
        {
            get => selectedCountry;
            set
            {
                selectedCountry = value;
                OnPropertyChanged();
            }
        }

        public City SelectedCity
        {
            get => selectedCity; set
            {
                selectedCity = value;
                OnPropertyChanged();
            }
        }

        private void SetCities(Country country)
        {
            Cities = cityService.Get(country.Id);
        }

        public IEnumerable<City> Cities
        {
            get => cities; set
            {
                cities = value;
                OnPropertyChanged();

                
            }
        }

        public CountryViewModel(ICountryService countryService, ICityService cityService)
        {
            this.countryService = countryService;
            this.cityService = cityService;

            this.PropertyChanged += CountryViewModel_PropertyChanged;

            Load();
        }

        private void Load()
        {
            Countries = countryService.Get();
        }

        private void CountryViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedCountry))
            {
                SetCities(SelectedCountry);
            }
        }
    }
}
