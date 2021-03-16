import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {
  readonly url = "https://60326a0da223790017acf117.mockapi.io/userdata";

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
