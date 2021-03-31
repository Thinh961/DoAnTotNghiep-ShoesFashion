import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly ApiUrl="http://localhost:5000/api";
  readonly PhotoUrl="http://localhost:5000/Photos";


  constructor(private http: HttpClient) { }

  // CRUD - PRODUCTS
  getProdList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/products');
  }

  addProducts(val:any){
    return this.http.post(this.ApiUrl+'/products',val);
  }

  updateProducts(val:any){
    return this.http.put(this.ApiUrl+'/products/'+ val.id,val);
  }

  deleteProducts(val:any){
    return this.http.delete(this.ApiUrl+'/products/'+val);
  }

  // CRUD - SUPPLIER
  getSuppList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/suppliers');
  }

  addSupp(val:any){
    return this.http.post(this.ApiUrl+'/suppliers',val);
  }

  updateSupp(val:any){
    return this.http.put(this.ApiUrl+'/suppliers/'+val.id,val);
  }

  deleteSupp(val:any){
    return this.http.delete(this.ApiUrl+'/suppliers/'+val);
  }

  // CRUD - CATEGORY
  getCateList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/categories');
  }

  addCate(val:any){
    return this.http.post(this.ApiUrl+'/categories',val);
  }

  updateCate(val:any){
    return this.http.put(this.ApiUrl+'/categories/'+val.id,val);
  }

  deleteCate(val:any){
    return this.http.delete(this.ApiUrl+'/categories/'+val);
  }
  // CRUD - NEWS
  getNewsList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/news');
  }

  addNews(val:any){
    return this.http.post(this.ApiUrl+'/news',val);
  }

  updateNews(val:any){
    return this.http.put(this.ApiUrl+'/news/'+val.id,val);
  }

  deleteNews(val:any){
    return this.http.delete(this.ApiUrl+'/news/'+val);
  }

  // CRUD - ADMIN
  getAdmList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/admins');
  }

  addAdmin(val:any){
    return this.http.post(this.ApiUrl+'/admins',val);
  }

  updateAdm(val:any){
    return this.http.put(this.ApiUrl+'/admins/'+val.id,val);
  }

  deleteAdm(val:any){
    return this.http.delete(this.ApiUrl+'/admins/'+val);
  }

  // CRUD - Customer
  getCusList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/customers');
  }

  addCus(val:any){
    return this.http.post(this.ApiUrl+'/customers',val);
  }

  updateCus(val:any){
    return this.http.put(this.ApiUrl+'/customers/'+val.id,val);
  }

  deleteCus(val:any){
    return this.http.delete(this.ApiUrl+'/customers/'+val);
  }

  // CRUD - ORDERS
  getOrderList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/orders');
  }

  addOrder(val:any){
    return this.http.post(this.ApiUrl+'/orders',val);
  }

  updateOrder(val:any){
    return this.http.put(this.ApiUrl+'/orders/'+val.id,val);
  }

  deleteOrder(val:any){
    return this.http.delete(this.ApiUrl+'/orders/'+val);
  }


  // Upload Ảnh
  UploadPhoto(val:any){
    return this.http.post(this.ApiUrl+'/products/saveFile',val)
  }

}
