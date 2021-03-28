import { Component, OnInit } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"

@Component({
  selector: 'app-show-kh',
  templateUrl: './show-kh.component.html',
  styleUrls: ['./show-kh.component.scss']
})
export class ShowKhComponent implements OnInit {

  constructor(private service:SharedService) { }

  CustomerList:any=[];


  ModalTitle:string;
  ActivateAddEdit:boolean=false;
  customer:any;

  CustomerIdFilter:string="";
  CustomerFullNameFilter:string="";
  CustomerUsernameFilter:string="";
  CustomerPhoneFilter:string="";
  CustomerListWithoutFilter:any=[];


  ngOnInit() {
    this.refreshCusList();
  }

  // Thêm sản phẩm
  addClick(){
    this.customer={
      id:0,
      fullName:"",
      username:"",
      password:"",
      phone:"",
    }
    this.ModalTitle="Thêm người dùng";
    this.ActivateAddEdit=true;
  }

  editClick(item){
    this.customer=item;
    this.ModalTitle="Sửa thông tin người dùng";
    this.ActivateAddEdit=true;
  }

  deleteClick(item){
    if(confirm("Bạn có chắc chắn xóa?")){
      this.service.deleteCus(item.id).subscribe(data =>{
        alert("Xóa thành công!")
        this.refreshCusList();
      })
    }
  }

  closeClick(){
    this.ActivateAddEdit=false;
    this.refreshCusList();
  }

  // refresh dữ liệu trả về từ Products(ProductsList)
  refreshCusList(){
    this.service.getCusList().subscribe(data=>{
      this.CustomerList=data;
      this.CustomerListWithoutFilter=data;
    });
  }

  FilterFn(){
    var CustomerIdFilter = this.CustomerIdFilter;
    var CustomerFullNameFilter = this.CustomerFullNameFilter;
    var CustomerUsernameFilter = this.CustomerUsernameFilter;
    var CustomerPhoneFilter = this.CustomerPhoneFilter;

    this.CustomerList = this.CustomerListWithoutFilter.filter(function (el){
      return el.id.toString().toLowerCase().includes(
        CustomerIdFilter.toString().trim().toLowerCase()
      )&&
        el.fullName.toString().toLowerCase().includes(
          CustomerFullNameFilter.toString().trim().toLowerCase()
        )&&
        el.username.toString().toLowerCase().includes(
          CustomerUsernameFilter.toString().trim().toLowerCase()
        )&&
        el.phone.toString().toLowerCase().includes(
          CustomerPhoneFilter.toString().trim().toLowerCase()
        )
    });
  }

}

