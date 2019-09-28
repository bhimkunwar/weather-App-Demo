import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {

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

    
