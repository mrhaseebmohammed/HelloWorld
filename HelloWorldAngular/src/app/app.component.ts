import { HelloWorldService } from './Services/HelloWorldService';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  helloWorld = '';

  constructor(private helloWorldService: HelloWorldService) { }

  ngOnInit() {
    this.helloWorldService.getHelloWorld().subscribe(data => this.helloWorld = data);
  }


}
