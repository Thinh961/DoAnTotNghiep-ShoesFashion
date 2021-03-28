import { Component, OnInit } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"

@Component({
  selector: 'app-show-ncc',
  templateUrl: './show-ncc.component.html',
})
export class ShowNccComponent implements OnInit {
  constructor(private service:SharedService) { }

  SupplierList:any=[];


  ModalTitle:string;
  ActivateAddEdit:boolean=false;
  suppliers:any;

  ngOnInit() {
    this.refreshSuppList();
  }

  // Thêm sản phẩm
  addClick(){
    this.suppliers={
      id:0,
      supplierName:"",
      phone:"",
      address:"",
    }
    this.ModalTitle="Thêm NCC";
    this.ActivateAddEdit=true;
  }

  editClick(item){
    this.suppliers=item;
    this.ModalTitle="Sửa NCC";
    this.ActivateAddEdit=true;
  }

  deleteClick(item){
    if(confirm("Bạn có chắc chắn xóa?")){
      this.service.deleteSupp(item.id).subscribe(data =>{
        alert("Xóa thành công!")
        this.refreshSuppList();
      })
    }
  }

  closeClick(){
    this.ActivateAddEdit=false;
    this.refreshSuppList();
  }

  // refresh dữ liệu trả về từ Products(ProductsList)
  refreshSuppList(){
    this.service.getSuppList().subscribe(data=>{
      this.SupplierList=data;
      // this.DepartmentListWithoutFilter=data;
    });
  }

}
