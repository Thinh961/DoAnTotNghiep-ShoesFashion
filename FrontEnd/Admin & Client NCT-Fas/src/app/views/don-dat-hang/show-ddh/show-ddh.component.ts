import { Component, OnInit } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"

@Component({
  selector: 'app-show-ddh',
  templateUrl: './show-ddh.component.html',
  styleUrls: ['./show-ddh.component.scss']
})
export class ShowDdhComponent implements OnInit {

  constructor(private service:SharedService) { }

  OrdersList:any=[];


  ModalTitle:string;
  ActivateAddEdit:boolean=false;
  orders:any;

  ngOnInit() {
    this.refreshOrdersList();
  }

  // Thêm sản phẩm
  addClick(){
    this.orders={
      id:0,
      customerId:"",
      userName:"",
      phoneShip:"",
      addressShip:"",
      total:"",
      createDate:"",
      status:"",
    }
    this.ModalTitle="Thêm đơn hàng";
    this.ActivateAddEdit=true;
  }

  editClick(item){
    this.orders=item;
    this.ModalTitle="Sửa đơn hàng";
    this.ActivateAddEdit=true;
  }

  deleteClick(item){
    if(confirm("Bạn có chắc chắn xóa?")){
      this.service.deleteOrder(item.id).subscribe(data =>{
        alert("Xóa thành công!")
        this.refreshOrdersList();
      });
    }
  }

  closeClick(){
    this.ActivateAddEdit=false;
    this.refreshOrdersList();
  }

  // refresh dữ liệu trả về từ Products(ProductsList)
  refreshOrdersList(){
    this.service.getOrderList().subscribe(data=>{
      this.OrdersList=data;
      // this.DepartmentListWithoutFilter=data;
    });
  }

}

