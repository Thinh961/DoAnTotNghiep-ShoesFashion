import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from '../../../_services/shared.service';
import { ShowKhComponent } from '../show-kh/show-kh.component';

@Component({
  selector: 'app-add-edit-kh',
  templateUrl: './add-edit-kh.component.html',
  styleUrls: ['./add-edit-kh.component.scss']
})
export class AddEditKhComponent implements OnInit {

  constructor(
    private service:SharedService,
    private showCus:ShowKhComponent,
  ) { }

  @Input() customer:any;
    id:string;
    fullName:string;
    username:string;
    password:string;
    phone:string;

  ngOnInit() {
    this.loadCusList();
    this.showCus.refreshCusList();

  }

  loadCusList(){
    this.service.getCusList().subscribe((data:any) =>{
      this.id = this.customer.id;
      this.fullName = this.customer.fullName;
      this.username = this.customer.username;
      this.password = this.customer.password;
      this.phone = this.customer.phone;
    });
  }

  Close(){
    this.showCus.refreshCusList();
  }

  add(){
    var val = {
      id:this.id,
      fullName:this.fullName,
      username:this.username,
      password:this.password,
      phone:this.phone,
    };
    this.service.addCus(val).subscribe(res =>{
      // alert(res.toString());
      // console.log(res)
      alert("Thêm thành công!");
      this.showCus.refreshCusList();
    });
  }


  update(){
    var val = {
      id:this.id,
      fullName:this.fullName,
      username:this.username,
      password:this.password,
      phone:this.phone,
    };
    // console.log(val)
    this.service.updateCus(val).subscribe(res =>{
      // alert(res.toString());
      alert("Đã cập nhật!");
      // this.showProd.closeClick();
      this.showCus.refreshCusList();
    });
  }

}
