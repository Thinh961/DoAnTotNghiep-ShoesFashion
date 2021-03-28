import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"
import { ShowNccComponent } from '../show-ncc/show-ncc.component';

@Component({
  selector: 'app-add-edit-ncc',
  templateUrl: './add-edit-ncc.component.html',
})
export class AddEditNccComponent implements OnInit {

  SupplierList:any=[];
  CategoryList:any=[];

  constructor(
    private service:SharedService,
    private showSupp:ShowNccComponent
  ) { }

  @Input() suppliers:any;
    id:string;
    supplierName:string;
    phone:string;
    address:string;

  ngOnInit() {
    this.showSupp.refreshSuppList();
    this.id = this.suppliers.id;
    this.supplierName = this.suppliers.supplierName;
    this.phone = this.suppliers.phone;
    this.address = this.suppliers.address;
  }

  // refresh dữ liệu trả về từ Supplier(SuppList)
  // refreshSuppList(){
  //   this.service.getSuppList().subscribe(data =>{
  //    this.SupplierList = data;
  //   });
  // }

  // refresh dữ liệu trả về từ Category(CategoryList)
  // refreshCategoList(){
  //   this.service.getCateList().subscribe(data =>{
  //    this.CategoryList = data;
  //   });
  // }

  Close(){
    this.showSupp.refreshSuppList();
  }

  add(){
    var val = {
      id:this.id,
      supplierName:this.supplierName,
      phone:this.phone,
      address:this.address,
    };
    this.service.addSupp(val).subscribe(res =>{
      // alert(res.toString());
      // console.log(res)
      alert("Thêm thành công!");
      this.showSupp.refreshSuppList();
    });
  }


  update(){
    var val = {
      id:this.id,
      supplierName:this.supplierName,
      phone:this.phone,
      address:this.address,
    };
    // console.log(val)
    this.service.updateSupp(val).subscribe(res =>{
      // alert(res.toString());
      alert("Đã cập nhật!");
      // this.showProd.closeClick();
      this.showSupp.refreshSuppList();
    });
  }

}

