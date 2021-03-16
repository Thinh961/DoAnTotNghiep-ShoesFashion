import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Course } from '../_models/courses';

@Injectable({
    providedIn: 'root'
})

export class CrudEmployeeService {
    readonly url = "https://6018d45a971d850017a4049c.mockapi.io/api/getcourse";

    constructor(private http: HttpClient) { }

    createCourse(val) {
        return this.http.post(this.url, val);
    }

    getCourse() {
        return this.http.get(this.url);
    }

    EditCourse(val) {
        return this.http.put(this.url + "/" + val.id, val);
    }

    DeleteCourse(id) {
        return this.http.delete(this.url + "/" + id);
    }
}
