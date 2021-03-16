import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})

export class CrudSkillsService {
    constructor(private http: HttpClient) {}
    readonly url = "https://5fa6173a085bf700163de216.mockapi.io/hachinet/skills";

    GetSkills() {
        return this.http.get(this.url);
    }
}