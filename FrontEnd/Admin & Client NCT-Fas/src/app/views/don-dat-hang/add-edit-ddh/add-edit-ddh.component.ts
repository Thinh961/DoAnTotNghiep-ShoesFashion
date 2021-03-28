import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"
import { ShowDdhComponent } from '../show-ddh/show-ddh.component';

@Component({
  selector: 'app-add-edit-ddh',
  templateUrl: './add-edit-ddh.component.html',
  styleUrls: ['./add-edit-ddh.component.scss']
})
export class AddEditDdhComponent implements OnInit {

  constructor(
    private service:SharedService,
    private showOrd:ShowDdhComponent,
  ) { }

  @Input() orders:any;
    id:string;
    customerId:string;
    phoneShip:string;
    addressShip:string;
    total:string;
    createDate:string;
    status:string;

    CustomerList:any=[];

  ngOnInit() {
    this.loadCusList();
    this.showOrd.refreshOrdersList();

  }

  loadCusList(){
    this.service.getCusList().subscribe((data:any)=>{
      this.CustomerList=data;

      this.id = this.orders.id;
      this.customerId = this.orders.customerId;
      this.phoneShip = this.orders.phoneShip;
      this.addressShip = this.orders.addressShip;
      this.total = this.orders.total;
      this.createDate = this.orders.createDate;
      this.status = this.orders.status;
    })
  }

  Close(){
    this.showOrd.refreshOrdersList();
  }

  add(){
    var val = {
      id:this.id,
      customerId:this.customerId,
      phoneShip:this.phoneShip,
      addressShip:this.addressShip,
      total:this.total,
      createDate:this.createDate,
      status:this.status,
    };
    this.service.addCate(val).subscribe(res =>{
      // alert(res.toString());
      // console.log(res)
      alert("Thêm thành công!");
      this.showOrd.refreshOrdersList();
    });
  }


  update(){
    var val = {
      id:this.id,
      customerId:this.customerId,
      phoneShip:this.phoneShip,
      addressShip:this.addressShip,
      total:this.total,
      createDate:this.createDate,
      status:this.status,
    };
    // console.log(val)
    this.service.updateCate(val).subscribe(res =>{
      // alert(res.toString());
      alert("Đã cập nhật!");
      // this.showProd.closeClick();
      this.showOrd.refreshOrdersList();
    });
  }

}

