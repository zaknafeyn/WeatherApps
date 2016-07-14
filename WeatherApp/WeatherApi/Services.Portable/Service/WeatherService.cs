﻿using System.Threading.Tasks;
using Services.Portable.API;
using Services.Portable.DTO;
using Services.Portable.DTO.Api;

namespace Services.Portable.Service
{
    public class WeatherService : IWeatherService
    {
        private readonly WeatherApi _weatherApi;

        public WeatherService()
        {
            _weatherApi = new WeatherApi();
        }

        internal WeatherService(WeatherApi weatherApi)
        {
            _weatherApi = weatherApi;
        }

        public async Task<CityWeatherResult> GetWeatherByCityNameAsync(string cityName)
        {
            var result = await _weatherApi.GetWeatherByCityNameAsync(cityName);
            return result;
        }

        public async Task<CityWeatherResult> GetWeatherByCityIdAsync(int cityId)
        {
            var result = await _weatherApi.GetWeatherByCityIdAsync(cityId);
            return result;
        }

        public async Task<CityWeatherResult> GetWeatherByCoordsAsync(Coordinates coords)
        {
            var result = await _weatherApi.GetWeatherByCoordAsync(coords);
            return result;
        }

        public async Task<CityWeatherForecastResult> GetWeatherForecastByCityNameAsync(string cityName)
        {
            var result = await _weatherApi.GetWeatherForecastByCityNameAsync(cityName);
            return result;
        }

        public async Task<CityWeatherForecastResult> GetWeatherForecastByCityIdAsync(int cityId)
        {
            var result = await _weatherApi.GetWeatherForecastByCityIdAsync(cityId);
            return result;
        }

        public async Task<CityWeatherForecastResult> GetWeatherForecastByCoordsAsync(Coordinates coords)
        {
            var result = await _weatherApi.GetWeatherForecastByCoordsAsync(coords);
            return result;
        }
    }
}