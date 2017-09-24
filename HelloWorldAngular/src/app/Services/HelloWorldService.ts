import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class HelloWorldService {
    constructor(
        private http: Http
    ) { }

    getHelloWorld() {
        return this.http.get('http://localhost:5000/api/Translate?word=helloWorld&culture=en-US')
            .map((res: Response) => res.text());
    }
}
