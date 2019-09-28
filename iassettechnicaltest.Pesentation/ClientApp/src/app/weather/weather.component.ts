import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html'
})

export class WeatherComponent {
  weather: any;
  result: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get(baseUrl + 'api/Weather/Get').subscribe(result => {
      this.weather = [
        result
      ];
      this.weather = JSON.parse(this.weather);
      console.log(this.weather)
    }, error => console.error(error));
  }
}
