import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { sanpham } from '../_models/san-pham';

@Injectable({
  providedIn: 'root'
})
export class SanPhamService {
  readonly url = "http://localhost:5000/api/products";

  constructor(private http: HttpClient) { }

  create(val) {
      return this.http.post(this.url, val);
  }

  getAll() {
      return this.http.get<sanpham>(this.url);
  }

  update(val) {
      return this.http.put(this.url + "/" + val.id, val);
  }

  delete(id) {
      return this.http.delete(this.url + "/" + id);
  }
}
